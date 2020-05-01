namespace SubTimes2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.tbxSeconds = new System.Windows.Forms.TextBox();
            this.tbxMinutes = new System.Windows.Forms.TextBox();
            this.tbxHours = new System.Windows.Forms.TextBox();
            this.tbxMiliseconds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblOK = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(15, 65);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(124, 23);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Choose file";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPath.Location = new System.Drawing.Point(12, 32);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(127, 13);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "Choose path of the srt file";
            // 
            // tbxSeconds
            // 
            this.tbxSeconds.Location = new System.Drawing.Point(139, 121);
            this.tbxSeconds.Name = "tbxSeconds";
            this.tbxSeconds.Size = new System.Drawing.Size(40, 20);
            this.tbxSeconds.TabIndex = 2;
            this.tbxSeconds.Tag = "Seconds";
            this.tbxSeconds.Text = "00";
            // 
            // tbxMinutes
            // 
            this.tbxMinutes.Location = new System.Drawing.Point(77, 121);
            this.tbxMinutes.Name = "tbxMinutes";
            this.tbxMinutes.Size = new System.Drawing.Size(40, 20);
            this.tbxMinutes.TabIndex = 3;
            this.tbxMinutes.Tag = "Minutes";
            this.tbxMinutes.Text = "00";
            // 
            // tbxHours
            // 
            this.tbxHours.Location = new System.Drawing.Point(15, 121);
            this.tbxHours.Name = "tbxHours";
            this.tbxHours.Size = new System.Drawing.Size(40, 20);
            this.tbxHours.TabIndex = 4;
            this.tbxHours.Tag = "Hours";
            this.tbxHours.Text = "00";
            // 
            // tbxMiliseconds
            // 
            this.tbxMiliseconds.Location = new System.Drawing.Point(201, 121);
            this.tbxMiliseconds.Name = "tbxMiliseconds";
            this.tbxMiliseconds.Size = new System.Drawing.Size(40, 20);
            this.tbxMiliseconds.TabIndex = 5;
            this.tbxMiliseconds.Tag = "Miliseconds";
            this.tbxMiliseconds.Text = "000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = ",";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb2);
            this.groupBox1.Controls.Add(this.rdb1);
            this.groupBox1.Location = new System.Drawing.Point(15, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 77);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Checked = true;
            this.rdb1.Location = new System.Drawing.Point(7, 20);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(73, 17);
            this.rdb1.TabIndex = 0;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "Backward";
            this.rdb1.UseVisualStyleBackColor = true;
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(7, 44);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(69, 17);
            this.rdb2.TabIndex = 1;
            this.rdb2.Text = "Fordward";
            this.rdb2.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(15, 272);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 11;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOK
            // 
            this.lblOK.AutoSize = true;
            this.lblOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOK.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblOK.Location = new System.Drawing.Point(104, 277);
            this.lblOK.Name = "lblOK";
            this.lblOK.Size = new System.Drawing.Size(28, 13);
            this.lblOK.TabIndex = 12;
            this.lblOK.Text = "OK!";
            this.lblOK.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 325);
            this.Controls.Add(this.lblOK);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxMiliseconds);
            this.Controls.Add(this.tbxHours);
            this.Controls.Add(this.tbxMinutes);
            this.Controls.Add(this.tbxSeconds);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox tbxSeconds;
        private System.Windows.Forms.TextBox tbxMinutes;
        private System.Windows.Forms.TextBox tbxHours;
        private System.Windows.Forms.TextBox tbxMiliseconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblOK;
    }
}

