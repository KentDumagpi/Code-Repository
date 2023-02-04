namespace NumberSequence_Dumagpi
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
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.chkList = new System.Windows.Forms.CheckBox();
            this.chkCbo = new System.Windows.Forms.CheckBox();
            this.lstNum = new System.Windows.Forms.ListBox();
            this.cboNum = new System.Windows.Forms.ComboBox();
            this.rbtnEven = new System.Windows.Forms.RadioButton();
            this.rbtnOdd = new System.Windows.Forms.RadioButton();
            this.rbtnDiv = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(100, 26);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(46, 24);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Start";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(100, 61);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(45, 24);
            this.lblEnd.TabIndex = 0;
            this.lblEnd.Text = "End";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(188, 26);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(129, 20);
            this.txtStart.TabIndex = 1;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(188, 66);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(129, 20);
            this.txtEnd.TabIndex = 2;
            this.txtEnd.TextChanged += new System.EventHandler(this.txtEnd_TextChanged);
            // 
            // chkList
            // 
            this.chkList.AutoSize = true;
            this.chkList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkList.Location = new System.Drawing.Point(346, 26);
            this.chkList.Name = "chkList";
            this.chkList.Size = new System.Drawing.Size(94, 28);
            this.chkList.TabIndex = 3;
            this.chkList.Text = "List Box";
            this.chkList.UseVisualStyleBackColor = true;
            this.chkList.CheckedChanged += new System.EventHandler(this.chkList_CheckedChanged);
            // 
            // chkCbo
            // 
            this.chkCbo.AutoSize = true;
            this.chkCbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCbo.Location = new System.Drawing.Point(346, 66);
            this.chkCbo.Name = "chkCbo";
            this.chkCbo.Size = new System.Drawing.Size(129, 28);
            this.chkCbo.TabIndex = 3;
            this.chkCbo.Text = "Combo Box";
            this.chkCbo.UseVisualStyleBackColor = true;
            this.chkCbo.CheckedChanged += new System.EventHandler(this.chkCbo_CheckedChanged);
            // 
            // lstNum
            // 
            this.lstNum.FormattingEnabled = true;
            this.lstNum.Location = new System.Drawing.Point(104, 125);
            this.lstNum.Name = "lstNum";
            this.lstNum.Size = new System.Drawing.Size(147, 225);
            this.lstNum.TabIndex = 4;
            this.lstNum.Visible = false;
            // 
            // cboNum
            // 
            this.cboNum.FormattingEnabled = true;
            this.cboNum.Location = new System.Drawing.Point(271, 125);
            this.cboNum.Name = "cboNum";
            this.cboNum.Size = new System.Drawing.Size(121, 21);
            this.cboNum.TabIndex = 5;
            this.cboNum.Visible = false;
            this.cboNum.SelectedIndexChanged += new System.EventHandler(this.cboNum_SelectedIndexChanged);
            // 
            // rbtnEven
            // 
            this.rbtnEven.AutoSize = true;
            this.rbtnEven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEven.Location = new System.Drawing.Point(477, 125);
            this.rbtnEven.Name = "rbtnEven";
            this.rbtnEven.Size = new System.Drawing.Size(72, 28);
            this.rbtnEven.TabIndex = 6;
            this.rbtnEven.TabStop = true;
            this.rbtnEven.Text = "Even";
            this.rbtnEven.UseVisualStyleBackColor = true;
            this.rbtnEven.CheckedChanged += new System.EventHandler(this.rbtnEven_CheckedChanged);
            // 
            // rbtnOdd
            // 
            this.rbtnOdd.AutoSize = true;
            this.rbtnOdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOdd.Location = new System.Drawing.Point(477, 159);
            this.rbtnOdd.Name = "rbtnOdd";
            this.rbtnOdd.Size = new System.Drawing.Size(65, 28);
            this.rbtnOdd.TabIndex = 6;
            this.rbtnOdd.TabStop = true;
            this.rbtnOdd.Text = "Odd";
            this.rbtnOdd.UseVisualStyleBackColor = true;
            this.rbtnOdd.CheckedChanged += new System.EventHandler(this.rbtnOdd_CheckedChanged);
            // 
            // rbtnDiv
            // 
            this.rbtnDiv.AutoSize = true;
            this.rbtnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDiv.Location = new System.Drawing.Point(477, 193);
            this.rbtnDiv.Name = "rbtnDiv";
            this.rbtnDiv.Size = new System.Drawing.Size(137, 28);
            this.rbtnDiv.TabIndex = 6;
            this.rbtnDiv.TabStop = true;
            this.rbtnDiv.Text = "Divisible by 5";
            this.rbtnDiv.UseVisualStyleBackColor = true;
            this.rbtnDiv.CheckedChanged += new System.EventHandler(this.rbtnDiv_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 632);
            this.Controls.Add(this.rbtnDiv);
            this.Controls.Add(this.rbtnOdd);
            this.Controls.Add(this.rbtnEven);
            this.Controls.Add(this.cboNum);
            this.Controls.Add(this.lstNum);
            this.Controls.Add(this.chkCbo);
            this.Controls.Add(this.chkList);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.CheckBox chkList;
        private System.Windows.Forms.CheckBox chkCbo;
        private System.Windows.Forms.ListBox lstNum;
        private System.Windows.Forms.ComboBox cboNum;
        private System.Windows.Forms.RadioButton rbtnEven;
        private System.Windows.Forms.RadioButton rbtnOdd;
        private System.Windows.Forms.RadioButton rbtnDiv;
    }
}

