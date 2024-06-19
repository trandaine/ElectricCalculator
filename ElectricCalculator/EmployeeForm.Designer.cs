namespace ElectricCalculator
{
    partial class EmployeeForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnEmployeeSubmit = new Button();
            txbEmployeeID = new TextBox();
            txbEmployeeName = new TextBox();
            dtpDateOfBirth = new DateTimePicker();
            rboMaleGender = new RadioButton();
            rdoFemaleGender = new RadioButton();
            cmbEmployeeRegistered = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            cmbEmployeeEducation = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 29);
            label1.Name = "label1";
            label1.Size = new Size(152, 23);
            label1.TabIndex = 0;
            label1.Text = "Employee Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 71);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "Employee ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 104);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 1;
            label3.Text = "Employee Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 164);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 1;
            label4.Text = "Date of Birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 137);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 1;
            label5.Text = "Gender";
            // 
            // btnEmployeeSubmit
            // 
            btnEmployeeSubmit.Location = new Point(156, 243);
            btnEmployeeSubmit.Name = "btnEmployeeSubmit";
            btnEmployeeSubmit.Size = new Size(75, 23);
            btnEmployeeSubmit.TabIndex = 2;
            btnEmployeeSubmit.Text = "Submit";
            btnEmployeeSubmit.UseVisualStyleBackColor = true;
            // 
            // txbEmployeeID
            // 
            txbEmployeeID.Location = new Point(156, 68);
            txbEmployeeID.Name = "txbEmployeeID";
            txbEmployeeID.Size = new Size(200, 23);
            txbEmployeeID.TabIndex = 3;
            // 
            // txbEmployeeName
            // 
            txbEmployeeName.Location = new Point(156, 101);
            txbEmployeeName.Name = "txbEmployeeName";
            txbEmployeeName.Size = new Size(200, 23);
            txbEmployeeName.TabIndex = 3;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(156, 158);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(200, 23);
            dtpDateOfBirth.TabIndex = 4;
            // 
            // rboMaleGender
            // 
            rboMaleGender.AutoSize = true;
            rboMaleGender.Location = new Point(156, 132);
            rboMaleGender.Name = "rboMaleGender";
            rboMaleGender.Size = new Size(51, 19);
            rboMaleGender.TabIndex = 5;
            rboMaleGender.TabStop = true;
            rboMaleGender.Text = "Male";
            rboMaleGender.UseVisualStyleBackColor = true;
            // 
            // rdoFemaleGender
            // 
            rdoFemaleGender.AutoSize = true;
            rdoFemaleGender.Location = new Point(233, 132);
            rdoFemaleGender.Name = "rdoFemaleGender";
            rdoFemaleGender.Size = new Size(43, 19);
            rdoFemaleGender.TabIndex = 5;
            rdoFemaleGender.TabStop = true;
            rdoFemaleGender.Text = "Girl";
            rdoFemaleGender.UseVisualStyleBackColor = true;
            // 
            // cmbEmployeeRegistered
            // 
            cmbEmployeeRegistered.FormattingEnabled = true;
            cmbEmployeeRegistered.Location = new Point(485, 96);
            cmbEmployeeRegistered.Name = "cmbEmployeeRegistered";
            cmbEmployeeRegistered.Size = new Size(180, 23);
            cmbEmployeeRegistered.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(520, 76);
            label6.Name = "label6";
            label6.Size = new Size(117, 15);
            label6.TabIndex = 1;
            label6.Text = "Registered Employee";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 200);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 1;
            label7.Text = "Education";
            // 
            // cmbEmployeeEducation
            // 
            cmbEmployeeEducation.FormattingEnabled = true;
            cmbEmployeeEducation.Location = new Point(156, 197);
            cmbEmployeeEducation.Name = "cmbEmployeeEducation";
            cmbEmployeeEducation.Size = new Size(200, 23);
            cmbEmployeeEducation.TabIndex = 6;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(700, 355);
            Controls.Add(cmbEmployeeEducation);
            Controls.Add(cmbEmployeeRegistered);
            Controls.Add(rdoFemaleGender);
            Controls.Add(rboMaleGender);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(txbEmployeeName);
            Controls.Add(txbEmployeeID);
            Controls.Add(btnEmployeeSubmit);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmployeeForm";
            Text = "Employee Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnEmployeeSubmit;
        private TextBox txbEmployeeID;
        private TextBox txbEmployeeName;
        private DateTimePicker dtpDateOfBirth;
        private RadioButton rboMaleGender;
        private RadioButton rdoFemaleGender;
        private ComboBox cmbEmployeeRegistered;
        private Label label6;
        private Label label7;
        private ComboBox cmbEmployeeEducation;
    }
}