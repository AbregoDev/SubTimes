using System;
using SubTimes;
using System.Windows.Forms;
using System.IO;

namespace SubTimes2
{
    public partial class Form1 : Form
    {
        System.Collections.Generic.List<Subti> subs = new System.Collections.Generic.List<Subti>();
        string path;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string lain, taim, body;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.Filter = "Subtitles file (*.srt)|*.srt";
                openFileDialog.RestoreDirectory = true;


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;
                    lblPath.Text = path;
                    btnApply.Enabled = true;
                    lblOK.Visible = false;

                    using (StreamReader sr = new StreamReader(openFileDialog.OpenFile(), System.Text.Encoding.Default))
                    {
                        
                        while ((lain = sr.ReadLine()) != null)
                        {
                            taim = sr.ReadLine();

                            string s;
                            body = string.Empty;

                            while ((s = sr.ReadLine()) != string.Empty)
                                body += $"{s}\n";

                            var sub = new Subti()
                            {
                                num = lain,
                                start = new Moment(sbyte.Parse(taim.Substring(0, 2)), sbyte.Parse(taim.Substring(3, 2)), sbyte.Parse(taim.Substring(6, 2)), short.Parse(taim.Substring(9, 3))),
                                end = new Moment(sbyte.Parse(taim.Substring(17, 2)), sbyte.Parse(taim.Substring(20, 2)), sbyte.Parse(taim.Substring(23, 2)), short.Parse(taim.Substring(26, 3))),
                                sub = body
                            };

                            subs.Add(sub);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newTime = $"{tbxHours.Text}:{tbxMinutes.Text}:{tbxSeconds.Text},{tbxMiliseconds.Text}";

            if (rdb2.Checked)
                foreach (Subti sub in subs)
                {
                    sub.start.SubstractTime(sbyte.Parse(newTime.Substring(1, 2)), sbyte.Parse(newTime.Substring(4, 2)), sbyte.Parse(newTime.Substring(7, 2)), short.Parse(newTime.Substring(10, 3)));
                    sub.end.SubstractTime(sbyte.Parse(newTime.Substring(1, 2)), sbyte.Parse(newTime.Substring(4, 2)), sbyte.Parse(newTime.Substring(7, 2)), short.Parse(newTime.Substring(10, 3)));
                }
            else
                foreach (Subti sub in subs)
                {
                    sub.start.AddTime(sbyte.Parse(newTime.Substring(0, 2)), sbyte.Parse(newTime.Substring(3, 2)), sbyte.Parse(newTime.Substring(6, 2)), short.Parse(newTime.Substring(9, 3)));
                    sub.end.AddTime(sbyte.Parse(newTime.Substring(0, 2)), sbyte.Parse(newTime.Substring(3, 2)), sbyte.Parse(newTime.Substring(6, 2)), short.Parse(newTime.Substring(9, 3)));
                }

            using (StreamWriter sw = new StreamWriter($"{path.Substring(0, path.Length - 4)}[Fixed].srt"))
            {
                foreach (Subti sub in subs)
                {
                    sw.WriteLine(sub.num);
                    sw.WriteLine(string.Format("{0:D2}:{1:D2}:{2:D2},{3:D3} --> {4:D2}:{5:D2}:{6:D2},{7:D3}", sub.start.hour, sub.start.min, sub.start.sec, sub.start.milisec, sub.end.hour, sub.end.min, sub.end.sec, sub.end.milisec));
                    sw.WriteLine(sub.sub);
                }
            }

            //Clean file
            lblPath.Text = "Choose path of the srt file";
            tbxHours.Text = tbxMinutes.Text = tbxSeconds.Text = "00";
            tbxMiliseconds.Text = "000";
            rdb1.Checked = true;
            btnApply.Enabled = false;
            lblOK.Visible = true;
        }
    }
}
