using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Subti> subs = new List<Subti>();
            string lain, taim, body;

            Console.WriteLine("Inserte ruta y nombre de archivo .srt");
            string path = Console.ReadLine();

            using(StreamReader sr = File.OpenText(path))
            {
                while((lain = sr.ReadLine()) != null)
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

            Console.WriteLine("Ingrese la cantidad a adelantar (HH:MM:SS,mmm) o atrasar (-HH:MM:SS,mmm)");
            string newTime = Console.ReadLine();

            if(newTime[0] == '-')
                foreach(Subti sub in subs)
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

            using(StreamWriter sw = new StreamWriter($"{path.Substring(0, path.Length - 4)}_timeFix.srt"))
            {
                foreach(Subti sub in subs)
                {
                    sw.WriteLine(sub.num);
                    sw.WriteLine(string.Format("{0:D2}:{1:D2}:{2:D2},{3:D3} --> {4:D2}:{5:D2}:{6:D2},{7:D3}", sub.start.hour, sub.start.min, sub.start.sec, sub.start.milisec, sub.end.hour, sub.end.min, sub.end.sec, sub.end.milisec));
                    sw.WriteLine(sub.sub);
                }
            }
        }
    }

    public class Subti
    {
        public string num { get; set; }
        public Moment start { get; set; }
        public Moment end { get; set; }
        public string sub { get; set; }
    }

    public class Moment
    {
        public sbyte hour { get; set; }
        public sbyte min { get; set; }
        public sbyte sec { get; set; }
        public short milisec { get; set; }

        public Moment(sbyte hour, sbyte min, sbyte sec, short milisec)
        {
            this.hour = hour;
            this.min = min;
            this.sec = sec;
            this.milisec = milisec;
        }

        public void AddTime(short milisec)
        {
            if ((this.milisec += milisec) >= 1000)
            {
                this.milisec -= 1000;
                AddTime(1, 0);
            }
        }

        public void AddTime(sbyte sec, short milisec)
        {
            AddTime(milisec);

            if((this.sec += sec) >= 60)
            {
                this.sec -= 60;
                AddTime(1, 0, 0);
            }
        }

        public void AddTime(sbyte min, sbyte sec, short milisec)
        {
            AddTime(sec, milisec);

            if ((this.min += min) >= 60)
            {
                this.min -= 60;
                AddTime(1, 0, 0, 0);
            }
        }

        public void AddTime(sbyte hour, sbyte min, sbyte sec, short milisec)
        {
            AddTime(min, sec, milisec);

            this.hour += hour;
        }

        public void SubstractTime(short milisec)
        {
            if ((this.milisec -= milisec) < 0)
            {
                this.milisec += 1000;
                SubstractTime(1, 0);

                if (this.sec < 0)
                    this.sec = 0;
            }
        }

        public void SubstractTime(sbyte sec, short milisec)
        {
            SubstractTime(milisec);

            if ((this.sec -= sec) < 0)
            {
                this.sec += 60;
                SubstractTime(1, 0, 0);

                if (this.min < 0)
                    this.min = 0;
            }
        }

        public void SubstractTime(sbyte min, sbyte sec, short milisec)
        {
            SubstractTime(sec, milisec);

            if ((this.min -= min) < 0)
            {
                this.min += 60;
                SubstractTime(1, 0, 0, 0);

                if (this.hour < 0)
                    this.hour = 0;
            }
        }

        public void SubstractTime(sbyte hour, sbyte min, sbyte sec, short milisec)
        {
            SubstractTime(min, sec, milisec);

            if ((this.hour -= hour) < 0)
                this.hour = 0;
        }
    }
}