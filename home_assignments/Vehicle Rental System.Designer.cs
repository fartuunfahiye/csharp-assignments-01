namespace home_assignments
{
    partial class Vehicle_Rental_System
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
            this.txtRentalDays = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.cmbVehicleType = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.chkInsurance = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerAge = new System.Windows.Forms.TextBox();
            this.txtExperience = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRentalDays
            // 
            this.txtRentalDays.Location = new System.Drawing.Point(81, 160);
            this.txtRentalDays.Name = "txtRentalDays";
            this.txtRentalDays.Size = new System.Drawing.Size(197, 20);
            this.txtRentalDays.TabIndex = 38;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(86, 365);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 37;
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.FormattingEnabled = true;
            this.cmbVehicleType.Items.AddRange(new object[] {
            "Economy",
            "SUV",
            "Luxury"});
            this.cmbVehicleType.Location = new System.Drawing.Point(82, 217);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(300, 21);
            this.cmbVehicleType.TabIndex = 36;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(205, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(219, 24);
            this.lblTitle.TabIndex = 35;
            this.lblTitle.Text = "Vehicle Rental System";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(307, 304);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 34;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(197, 304);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(86, 304);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 32;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // chkInsurance
            // 
            this.chkInsurance.AutoSize = true;
            this.chkInsurance.Location = new System.Drawing.Point(106, 280);
            this.chkInsurance.Name = "chkInsurance";
            this.chkInsurance.Size = new System.Drawing.Size(160, 17);
            this.chkInsurance.TabIndex = 31;
            this.chkInsurance.Text = "Add Insurance ($15 per day)";
            this.chkInsurance.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Insurance Option";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Vehicle Type";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(336, 131);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(138, 13);
            this.lbl5.TabIndex = 28;
            this.lbl5.Text = "Years of Driving Experience";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(79, 131);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(117, 13);
            this.lbl4.TabIndex = 27;
            this.lbl4.Text = "Number of Rental Days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Customer Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Customer Name";
            // 
            // txtCustomerAge
            // 
            this.txtCustomerAge.Location = new System.Drawing.Point(339, 95);
            this.txtCustomerAge.Name = "txtCustomerAge";
            this.txtCustomerAge.Size = new System.Drawing.Size(196, 20);
            this.txtCustomerAge.TabIndex = 24;
            // 
            // txtExperience
            // 
            this.txtExperience.Location = new System.Drawing.Point(339, 160);
            this.txtExperience.Name = "txtExperience";
            this.txtExperience.Size = new System.Drawing.Size(196, 20);
            this.txtExperience.TabIndex = 23;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(82, 95);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(196, 20);
            this.txtCustomerName.TabIndex = 22;
            // 
            // Vehicle_Rental_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRentalDays);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.cmbVehicleType);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chkInsurance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerAge);
            this.Controls.Add(this.txtExperience);
            this.Controls.Add(this.txtCustomerName);
            this.Name = "Vehicle_Rental_System";
            this.Text = "Vehicle_Rental_System";
            this.Load += new System.EventHandler(this.Vehicle_Rental_System_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRentalDays;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox cmbVehicleType;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.CheckBox chkInsurance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerAge;
        private System.Windows.Forms.TextBox txtExperience;
        private System.Windows.Forms.TextBox txtCustomerName;
    }
}