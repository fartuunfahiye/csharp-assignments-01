namespace home_assignments
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.txtGuests = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkBreakfast = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(182, -48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(230, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOTEL BOOKING SYSTEM";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(42, 88);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(196, 20);
            this.txtGuestName.TabIndex = 1;
            this.txtGuestName.TextChanged += new System.EventHandler(this.txtGuestName_TextChanged);
            // 
            // txtGuests
            // 
            this.txtGuests.Location = new System.Drawing.Point(299, 153);
            this.txtGuests.Name = "txtGuests";
            this.txtGuests.Size = new System.Drawing.Size(196, 20);
            this.txtGuests.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(299, 88);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(196, 20);
            this.txtAge.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Guest name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Guest Age";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(39, 124);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(89, 13);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "Number of Nights";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(296, 124);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(92, 13);
            this.lbl5.TabIndex = 8;
            this.lbl5.Text = "Number of Guests";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Room Type";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Additional Options";
            // 
            // chkBreakfast
            // 
            this.chkBreakfast.AutoSize = true;
            this.chkBreakfast.Location = new System.Drawing.Point(66, 273);
            this.chkBreakfast.Name = "chkBreakfast";
            this.chkBreakfast.Size = new System.Drawing.Size(193, 17);
            this.chkBreakfast.TabIndex = 14;
            this.chkBreakfast.Text = "BreakFast (10 per guest per Nights)";
            this.chkBreakfast.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(46, 297);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(157, 297);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(267, 297);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(165, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Hotel Booking System";
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] {
            "Standard",
            "Normal",
            "High"});
            this.cmbRoomType.Location = new System.Drawing.Point(42, 210);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(300, 21);
            this.cmbRoomType.TabIndex = 19;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(46, 358);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 20;
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(41, 153);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(197, 20);
            this.txtNights.TabIndex = 21;
            this.txtNights.TextChanged += new System.EventHandler(this.txtNights_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNights);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chkBreakfast);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtGuests);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.TextBox txtGuests;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkBreakfast;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtNights;
    }
}

