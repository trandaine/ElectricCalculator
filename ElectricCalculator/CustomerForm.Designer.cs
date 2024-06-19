namespace ElectricCalculator
{
    partial class CustomerForm
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
            cmbEmployeeOccupation = new ComboBox();
            cmbCustomerRegistered = new ComboBox();
            rdoFemaleGenderCustomer = new RadioButton();
            rboMaleGenderCustomer = new RadioButton();
            dtpCustomerDateOfBirth = new DateTimePicker();
            txbCustomerName = new TextBox();
            txbCustomerID = new TextBox();
            btnCustomerSubmit = new Button();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblCustomerIDErrMsg = new Label();
            lblCustomerNameErrMsg = new Label();
            lblCustomerOccupationErrMsg = new Label();
            rdoNullGenderCustomer = new RadioButton();
            SuspendLayout();
            // 
            // cmbEmployeeOccupation
            // 
            cmbEmployeeOccupation.FormattingEnabled = true;
            cmbEmployeeOccupation.Location = new Point(166, 334);
            cmbEmployeeOccupation.Name = "cmbEmployeeOccupation";
            cmbEmployeeOccupation.Size = new Size(200, 25);
            cmbEmployeeOccupation.TabIndex = 20;
            // 
            // cmbCustomerRegistered
            // 
            cmbCustomerRegistered.FormattingEnabled = true;
            cmbCustomerRegistered.Location = new Point(514, 114);
            cmbCustomerRegistered.Name = "cmbCustomerRegistered";
            cmbCustomerRegistered.Size = new Size(180, 25);
            cmbCustomerRegistered.TabIndex = 21;
            // 
            // rdoFemaleGenderCustomer
            // 
            rdoFemaleGenderCustomer.AutoSize = true;
            rdoFemaleGenderCustomer.Location = new Point(243, 212);
            rdoFemaleGenderCustomer.Name = "rdoFemaleGenderCustomer";
            rdoFemaleGenderCustomer.Size = new Size(46, 21);
            rdoFemaleGenderCustomer.TabIndex = 18;
            rdoFemaleGenderCustomer.TabStop = true;
            rdoFemaleGenderCustomer.Text = "Girl";
            rdoFemaleGenderCustomer.UseVisualStyleBackColor = true;
            // 
            // rboMaleGenderCustomer
            // 
            rboMaleGenderCustomer.AutoSize = true;
            rboMaleGenderCustomer.Location = new Point(166, 212);
            rboMaleGenderCustomer.Name = "rboMaleGenderCustomer";
            rboMaleGenderCustomer.Size = new Size(55, 21);
            rboMaleGenderCustomer.TabIndex = 19;
            rboMaleGenderCustomer.TabStop = true;
            rboMaleGenderCustomer.Text = "Male";
            rboMaleGenderCustomer.UseVisualStyleBackColor = true;
            // 
            // dtpCustomerDateOfBirth
            // 
            dtpCustomerDateOfBirth.Location = new Point(166, 265);
            dtpCustomerDateOfBirth.Name = "dtpCustomerDateOfBirth";
            dtpCustomerDateOfBirth.Size = new Size(200, 25);
            dtpCustomerDateOfBirth.TabIndex = 17;
            // 
            // txbCustomerName
            // 
            txbCustomerName.Location = new Point(166, 145);
            txbCustomerName.Name = "txbCustomerName";
            txbCustomerName.Size = new Size(200, 25);
            txbCustomerName.TabIndex = 15;
            txbCustomerName.TextChanged += txbCustomerName_TextChanged;
            // 
            // txbCustomerID
            // 
            txbCustomerID.Location = new Point(166, 83);
            txbCustomerID.Name = "txbCustomerID";
            txbCustomerID.Size = new Size(200, 25);
            txbCustomerID.TabIndex = 16;
            txbCustomerID.TextChanged += txbCustomerID_TextChanged;
            // 
            // btnCustomerSubmit
            // 
            btnCustomerSubmit.Location = new Point(166, 405);
            btnCustomerSubmit.Name = "btnCustomerSubmit";
            btnCustomerSubmit.Size = new Size(75, 26);
            btnCustomerSubmit.TabIndex = 14;
            btnCustomerSubmit.Text = "Submit";
            btnCustomerSubmit.UseVisualStyleBackColor = true;
            btnCustomerSubmit.Click += btnCustomerSubmit_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(565, 92);
            label6.Name = "label6";
            label6.Size = new Size(87, 17);
            label6.TabIndex = 8;
            label6.Text = "Customer List";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 218);
            label5.Name = "label5";
            label5.Size = new Size(51, 17);
            label5.TabIndex = 9;
            label5.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 338);
            label7.Name = "label7";
            label7.Size = new Size(74, 17);
            label7.TabIndex = 10;
            label7.Text = "Occupation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 272);
            label4.Name = "label4";
            label4.Size = new Size(81, 17);
            label4.TabIndex = 11;
            label4.Text = "Date of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 148);
            label3.Name = "label3";
            label3.Size = new Size(103, 17);
            label3.TabIndex = 12;
            label3.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 86);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 13;
            label2.Text = "Customer ID";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(287, 31);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 7;
            label1.Text = "Customer Register";
            // 
            // lblCustomerIDErrMsg
            // 
            lblCustomerIDErrMsg.AutoSize = true;
            lblCustomerIDErrMsg.Location = new Point(166, 118);
            lblCustomerIDErrMsg.Name = "lblCustomerIDErrMsg";
            lblCustomerIDErrMsg.Size = new Size(0, 17);
            lblCustomerIDErrMsg.TabIndex = 9;
            // 
            // lblCustomerNameErrMsg
            // 
            lblCustomerNameErrMsg.AutoSize = true;
            lblCustomerNameErrMsg.Location = new Point(166, 182);
            lblCustomerNameErrMsg.Name = "lblCustomerNameErrMsg";
            lblCustomerNameErrMsg.Size = new Size(0, 17);
            lblCustomerNameErrMsg.TabIndex = 12;
            // 
            // lblCustomerOccupationErrMsg
            // 
            lblCustomerOccupationErrMsg.AutoSize = true;
            lblCustomerOccupationErrMsg.Location = new Point(166, 373);
            lblCustomerOccupationErrMsg.Name = "lblCustomerOccupationErrMsg";
            lblCustomerOccupationErrMsg.Size = new Size(0, 17);
            lblCustomerOccupationErrMsg.TabIndex = 11;
            // 
            // rdoNullGenderCustomer
            // 
            rdoNullGenderCustomer.AutoSize = true;
            rdoNullGenderCustomer.Location = new Point(310, 212);
            rdoNullGenderCustomer.Name = "rdoNullGenderCustomer";
            rdoNullGenderCustomer.Size = new Size(138, 21);
            rdoNullGenderCustomer.TabIndex = 18;
            rdoNullGenderCustomer.TabStop = true;
            rdoNullGenderCustomer.Text = "Rather not disclose";
            rdoNullGenderCustomer.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 478);
            Controls.Add(cmbEmployeeOccupation);
            Controls.Add(cmbCustomerRegistered);
            Controls.Add(rdoNullGenderCustomer);
            Controls.Add(rdoFemaleGenderCustomer);
            Controls.Add(rboMaleGenderCustomer);
            Controls.Add(dtpCustomerDateOfBirth);
            Controls.Add(txbCustomerName);
            Controls.Add(txbCustomerID);
            Controls.Add(btnCustomerSubmit);
            Controls.Add(label6);
            Controls.Add(lblCustomerIDErrMsg);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(lblCustomerOccupationErrMsg);
            Controls.Add(label4);
            Controls.Add(lblCustomerNameErrMsg);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CustomerForm";
            Text = "CustomerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbEmployeeOccupation;
        private ComboBox cmbCustomerRegistered;
        private RadioButton rdoFemaleGenderCustomer;
        private RadioButton rboMaleGenderCustomer;
        private DateTimePicker dtpCustomerDateOfBirth;
        private TextBox txbCustomerName;
        private TextBox txbCustomerID;
        private Button btnCustomerSubmit;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblCustomerIDErrMsg;
        private Label lblCustomerNameErrMsg;
        private Label lblCustomerOccupationErrMsg;
        private RadioButton rdoNullGenderCustomer;
    }
}