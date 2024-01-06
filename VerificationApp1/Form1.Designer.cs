namespace VerificationApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Name_txt = new TextBox();
            Age_txt = new TextBox();
            Pnum_txt = new TextBox();
            Grp18_box = new GroupBox();
            Voter_txt = new TextBox();
            Pan_txt = new TextBox();
            label5 = new Label();
            label4 = new Label();
            Sbmt_btn = new Button();
            label6 = new Label();
            Chkbox = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            Alert_lbl = new Label();
            Grp18_box.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(98, 79);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(98, 133);
            label2.Name = "label2";
            label2.Size = new Size(42, 23);
            label2.TabIndex = 1;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(98, 185);
            label3.Name = "label3";
            label3.Size = new Size(76, 46);
            label3.TabIndex = 2;
            label3.Text = "Phone \r\nNumber\r\n";
            // 
            // Name_txt
            // 
            Name_txt.Location = new Point(233, 79);
            Name_txt.Name = "Name_txt";
            Name_txt.Size = new Size(272, 27);
            Name_txt.TabIndex = 3;
            // 
            // Age_txt
            // 
            Age_txt.Location = new Point(233, 133);
            Age_txt.Name = "Age_txt";
            Age_txt.Size = new Size(272, 27);
            Age_txt.TabIndex = 4;
            // 
            // Pnum_txt
            // 
            Pnum_txt.Location = new Point(233, 185);
            Pnum_txt.Name = "Pnum_txt";
            Pnum_txt.Size = new Size(272, 27);
            Pnum_txt.TabIndex = 5;
            // 
            // Grp18_box
            // 
            Grp18_box.Controls.Add(Voter_txt);
            Grp18_box.Controls.Add(Pan_txt);
            Grp18_box.Controls.Add(label5);
            Grp18_box.Controls.Add(label4);
            Grp18_box.Location = new Point(25, 382);
            Grp18_box.Name = "Grp18_box";
            Grp18_box.Size = new Size(538, 159);
            Grp18_box.TabIndex = 6;
            Grp18_box.TabStop = false;
            // 
            // Voter_txt
            // 
            Voter_txt.Location = new Point(208, 92);
            Voter_txt.Name = "Voter_txt";
            Voter_txt.Size = new Size(272, 27);
            Voter_txt.TabIndex = 8;
            // 
            // Pan_txt
            // 
            Pan_txt.Location = new Point(208, 23);
            Pan_txt.Name = "Pan_txt";
            Pan_txt.Size = new Size(272, 27);
            Pan_txt.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(73, 92);
            label5.Name = "label5";
            label5.Size = new Size(76, 46);
            label5.TabIndex = 4;
            label5.Text = "Voter \r\nNumber\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(73, 23);
            label4.Name = "label4";
            label4.Size = new Size(76, 46);
            label4.TabIndex = 3;
            label4.Text = "Pan \r\nNumber\r\n";
            // 
            // Sbmt_btn
            // 
            Sbmt_btn.BackColor = Color.DarkGray;
            Sbmt_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Sbmt_btn.ForeColor = SystemColors.Control;
            Sbmt_btn.Location = new Point(233, 583);
            Sbmt_btn.Name = "Sbmt_btn";
            Sbmt_btn.Size = new Size(94, 29);
            Sbmt_btn.TabIndex = 7;
            Sbmt_btn.Text = "Submit\r\n";
            Sbmt_btn.UseVisualStyleBackColor = false;
            Sbmt_btn.Click += Sbmt_btn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label6.Location = new Point(154, 18);
            label6.Name = "label6";
            label6.Size = new Size(249, 31);
            label6.TabIndex = 8;
            label6.Text = "Time Pass Verification\r\n";
            // 
            // Chkbox
            // 
            Chkbox.AutoSize = true;
            Chkbox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Chkbox.Location = new Point(36, 352);
            Chkbox.Name = "Chkbox";
            Chkbox.Size = new Size(119, 24);
            Chkbox.TabIndex = 9;
            Chkbox.Text = "Are you 18+";
            Chkbox.UseVisualStyleBackColor = true;
            Chkbox.CheckedChanged += Chkbox_CheckedChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(306, 257);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(199, 30);
            dateTimePicker1.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(98, 263);
            label7.Name = "label7";
            label7.Size = new Size(70, 46);
            label7.TabIndex = 11;
            label7.Text = "Date of\r\nBirth\r\n";
            // 
            // Alert_lbl
            // 
            Alert_lbl.AutoSize = true;
            Alert_lbl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Alert_lbl.Location = new Point(322, 544);
            Alert_lbl.Name = "Alert_lbl";
            Alert_lbl.Size = new Size(221, 20);
            Alert_lbl.TabIndex = 12;
            Alert_lbl.Text = "Please fill up the form properly\r\n";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Chartreuse;
            ClientSize = new Size(589, 624);
            Controls.Add(Alert_lbl);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(Chkbox);
            Controls.Add(label6);
            Controls.Add(Sbmt_btn);
            Controls.Add(Grp18_box);
            Controls.Add(Pnum_txt);
            Controls.Add(Age_txt);
            Controls.Add(Name_txt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
         
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Form1_Load;
            Grp18_box.ResumeLayout(false);
            Grp18_box.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Name_txt;
        private TextBox Age_txt;
        private TextBox Pnum_txt;
        private GroupBox Grp18_box;
        private Label label5;
        private Label label4;
        private TextBox Voter_txt;
        private TextBox Pan_txt;
        private Button Sbmt_btn;
        private Label label6;
        private CheckBox Chkbox;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Label Alert_lbl;
    }
}