namespace PersonalInformation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpBday = new System.Windows.Forms.DateTimePicker();
            this.gender = new System.Windows.Forms.GroupBox();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbHobby6 = new System.Windows.Forms.CheckBox();
            this.cbHobby1 = new System.Windows.Forms.CheckBox();
            this.cbHobby5 = new System.Windows.Forms.CheckBox();
            this.cbHobby2 = new System.Windows.Forms.CheckBox();
            this.cbHobby4 = new System.Windows.Forms.CheckBox();
            this.cbHobby3 = new System.Windows.Forms.CheckBox();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.gender.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Birthday";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(748, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 75);
            this.button2.TabIndex = 2;
            this.button2.Text = "Display";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(246, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // dtpBday
            // 
            this.dtpBday.Location = new System.Drawing.Point(246, 60);
            this.dtpBday.Name = "dtpBday";
            this.dtpBday.Size = new System.Drawing.Size(200, 20);
            this.dtpBday.TabIndex = 4;
            this.dtpBday.ValueChanged += new System.EventHandler(this.dtpBday_ValueChanged);
            // 
            // gender
            // 
            this.gender.Controls.Add(this.rbtnFemale);
            this.gender.Controls.Add(this.rbtnMale);
            this.gender.Location = new System.Drawing.Point(184, 135);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(101, 78);
            this.gender.TabIndex = 5;
            this.gender.TabStop = false;
            this.gender.Text = "Gender";
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(17, 51);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(59, 17);
            this.rbtnFemale.TabIndex = 6;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(17, 28);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(48, 17);
            this.rbtnMale.TabIndex = 6;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbHobby6);
            this.groupBox2.Controls.Add(this.cbHobby1);
            this.groupBox2.Controls.Add(this.cbHobby5);
            this.groupBox2.Controls.Add(this.cbHobby2);
            this.groupBox2.Controls.Add(this.cbHobby4);
            this.groupBox2.Controls.Add(this.cbHobby3);
            this.groupBox2.Location = new System.Drawing.Point(184, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 92);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hobbies";
            // 
            // cbHobby6
            // 
            this.cbHobby6.AutoSize = true;
            this.cbHobby6.Location = new System.Drawing.Point(206, 63);
            this.cbHobby6.Name = "cbHobby6";
            this.cbHobby6.Size = new System.Drawing.Size(93, 17);
            this.cbHobby6.TabIndex = 7;
            this.cbHobby6.Text = "Day Dreaming";
            this.cbHobby6.UseVisualStyleBackColor = true;
            // 
            // cbHobby1
            // 
            this.cbHobby1.AutoSize = true;
            this.cbHobby1.Location = new System.Drawing.Point(21, 19);
            this.cbHobby1.Name = "cbHobby1";
            this.cbHobby1.Size = new System.Drawing.Size(179, 17);
            this.cbHobby1.TabIndex = 7;
            this.cbHobby1.Text = "Listening to Music and Podcasts";
            this.cbHobby1.UseVisualStyleBackColor = true;
            // 
            // cbHobby5
            // 
            this.cbHobby5.AutoSize = true;
            this.cbHobby5.Location = new System.Drawing.Point(206, 40);
            this.cbHobby5.Name = "cbHobby5";
            this.cbHobby5.Size = new System.Drawing.Size(93, 17);
            this.cbHobby5.TabIndex = 7;
            this.cbHobby5.Text = "Playing Sports";
            this.cbHobby5.UseVisualStyleBackColor = true;
            // 
            // cbHobby2
            // 
            this.cbHobby2.AutoSize = true;
            this.cbHobby2.Location = new System.Drawing.Point(21, 42);
            this.cbHobby2.Name = "cbHobby2";
            this.cbHobby2.Size = new System.Drawing.Size(86, 17);
            this.cbHobby2.TabIndex = 7;
            this.cbHobby2.Text = "Working Out";
            this.cbHobby2.UseVisualStyleBackColor = true;
            // 
            // cbHobby4
            // 
            this.cbHobby4.AutoSize = true;
            this.cbHobby4.Location = new System.Drawing.Point(206, 19);
            this.cbHobby4.Name = "cbHobby4";
            this.cbHobby4.Size = new System.Drawing.Size(176, 17);
            this.cbHobby4.TabIndex = 7;
            this.cbHobby4.Text = "Watching Anime and/or Movies";
            this.cbHobby4.UseVisualStyleBackColor = true;
            // 
            // cbHobby3
            // 
            this.cbHobby3.AutoSize = true;
            this.cbHobby3.Location = new System.Drawing.Point(21, 65);
            this.cbHobby3.Name = "cbHobby3";
            this.cbHobby3.Size = new System.Drawing.Size(66, 17);
            this.cbHobby3.TabIndex = 7;
            this.cbHobby3.Text = "Reading";
            this.cbHobby3.UseVisualStyleBackColor = true;
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(692, 28);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(186, 247);
            this.pBox.TabIndex = 6;
            this.pBox.TabStop = false;
            this.pBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 625);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.dtpBday);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gender.ResumeLayout(false);
            this.gender.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpBday;
        private System.Windows.Forms.GroupBox gender;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbHobby6;
        private System.Windows.Forms.CheckBox cbHobby1;
        private System.Windows.Forms.CheckBox cbHobby5;
        private System.Windows.Forms.CheckBox cbHobby2;
        private System.Windows.Forms.CheckBox cbHobby4;
        private System.Windows.Forms.CheckBox cbHobby3;
        private System.Windows.Forms.PictureBox pBox;
    }
}

