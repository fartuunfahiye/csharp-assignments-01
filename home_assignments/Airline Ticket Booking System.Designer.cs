namespace home_assignments
{
    partial class Airline_Ticket_Booking_System
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
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.txtPassengerAge = new System.Windows.Forms.TextBox();
            this.txtBaggage = new System.Windows.Forms.TextBox();
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTickets
            // 
            this.txtTickets.Location = new System.Drawing.Point(79, 170);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(197, 20);
            this.txtTickets.TabIndex = 37;
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Items.AddRange(new object[] {
            "First Class",
            "Normal Class",
            "Business Class"});
            this.cmbClass.Location = new System.Drawing.Point(80, 227);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(300, 21);
            this.cmbClass.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(203, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 24);
            this.label7.TabIndex = 35;
            this.label7.Text = "Airline Ticket Booking System";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(305, 314);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 34;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(195, 314);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(84, 314);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 32;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // chkInsurance
            // 
            this.chkInsurance.AutoSize = true;
            this.chkInsurance.Location = new System.Drawing.Point(104, 290);
            this.chkInsurance.Name = "chkInsurance";
            this.chkInsurance.Size = new System.Drawing.Size(206, 17);
            this.chkInsurance.TabIndex = 31;
            this.chkInsurance.Text = "Add Travel Insurance ($25 per Ticket)";
            this.chkInsurance.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Additional Options";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Ticket Class";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(334, 141);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(105, 13);
            this.lbl5.TabIndex = 28;
            this.lbl5.Text = "Backage Weight(kg)";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(77, 141);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(96, 13);
            this.lbl4.TabIndex = 27;
            this.lbl4.Text = "Number Of Tickets";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Passenger Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Passenger Name";
            // 
            // txtPassengerAge
            // 
            this.txtPassengerAge.Location = new System.Drawing.Point(337, 105);
            this.txtPassengerAge.Name = "txtPassengerAge";
            this.txtPassengerAge.Size = new System.Drawing.Size(196, 20);
            this.txtPassengerAge.TabIndex = 24;
            // 
            // txtBaggage
            // 
            this.txtBaggage.Location = new System.Drawing.Point(337, 170);
            this.txtBaggage.Name = "txtBaggage";
            this.txtBaggage.Size = new System.Drawing.Size(196, 20);
            this.txtBaggage.TabIndex = 23;
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Location = new System.Drawing.Point(80, 105);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(196, 20);
            this.txtPassengerName.TabIndex = 22;
            this.txtPassengerName.TextChanged += new System.EventHandler(this.txtGuestName_TextChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(90, 353);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 38;
            // 
            // Airline_Ticket_Booking_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtTickets);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.label7);
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
            this.Controls.Add(this.txtPassengerAge);
            this.Controls.Add(this.txtBaggage);
            this.Controls.Add(this.txtPassengerName);
            this.Name = "Airline_Ticket_Booking_System";
            this.Text = "Airline_Ticket_Booking_System";
            this.Load += new System.EventHandler(this.Airline_Ticket_Booking_System_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.TextBox txtPassengerAge;
        private System.Windows.Forms.TextBox txtBaggage;
        private System.Windows.Forms.TextBox txtPassengerName;
        private System.Windows.Forms.Label lblResult;
    }
}