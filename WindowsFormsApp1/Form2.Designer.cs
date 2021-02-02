namespace WindowsFormsApp1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.alarmset1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.alarmset1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 421);
            this.panel2.TabIndex = 10;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Control_Clicks);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(13)))), ((int)(((byte)(30)))));
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.ForeColor = System.Drawing.Color.LightCoral;
            this.panel3.Location = new System.Drawing.Point(178, 339);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 41);
            this.panel3.TabIndex = 9;
            this.panel3.Visible = false;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button5.Location = new System.Drawing.Point(212, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Set URL";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(14, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Enter a URL to be opened";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(13)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(103, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 132);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Control_Clicks);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(63, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 120);
            this.label1.TabIndex = 1;
            this.label1.Text = "00:00:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Control_Clicks);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(13)))), ((int)(((byte)(30)))));
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.ForeColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Location = new System.Drawing.Point(203, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 159);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time";
            this.groupBox1.Visible = false;
            this.groupBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.groupBox1_MouseClick);
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(8, 109);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Website Alarm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(8, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Custom Sound";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(137, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.LightCoral;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.LightCoral;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(246, 32);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(13)))), ((int)(((byte)(30)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.LightCoral;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(285, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // alarmset1
            // 
            this.alarmset1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alarmset1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(13)))), ((int)(((byte)(30)))));
            this.alarmset1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alarmset1.ForeColor = System.Drawing.Color.LightCoral;
            this.alarmset1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.alarmset1.Location = new System.Drawing.Point(178, 170);
            this.alarmset1.Name = "alarmset1";
            this.alarmset1.Size = new System.Drawing.Size(296, 79);
            this.alarmset1.TabIndex = 0;
            this.alarmset1.Text = "Alarm Set";
            this.alarmset1.UseVisualStyleBackColor = false;
            this.alarmset1.Click += new System.EventHandler(this.alarmset1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(647, 421);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
       
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button alarmset1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
       
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
    }
}