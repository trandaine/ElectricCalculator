
namespace ElectricCalculator
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbCustomerID = new TextBox();
            tbCustomerName = new TextBox();
            btnSubmit = new Button();
            label5 = new Label();
            label6 = new Label();
            lsvResult = new ListView();
            txtboxLastIndex = new TextBox();
            txtBoxCurrentIndex = new TextBox();
            lblFinalCost = new Label();
            label7 = new Label();
            lblStatusSMS = new Label();
            lblIDErrSms = new Label();
            lblNameErrSMS = new Label();
            lblLastIndexErrSMS = new Label();
            lblCurrentIndexErrSms = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 63);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 0;
            label2.Text = "CustomerID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 130);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 0;
            label3.Text = "Cusomter Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(584, 168);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 0;
            label4.Text = "Consumption Index:";
            label4.Click += label4_Click;
            // 
            // tbCustomerID
            // 
            tbCustomerID.Location = new Point(157, 60);
            tbCustomerID.Name = "tbCustomerID";
            tbCustomerID.Size = new Size(208, 26);
            tbCustomerID.TabIndex = 1;
            tbCustomerID.TextChanged += tbCustomerID_TextChanged;
            // 
            // tbCustomerName
            // 
            tbCustomerName.Location = new Point(157, 127);
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Size = new Size(208, 26);
            tbCustomerName.TabIndex = 1;
            tbCustomerName.TextChanged += tbCustomerName_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(591, 227);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(90, 28);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(584, 63);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 0;
            label5.Text = "Last Index";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(584, 113);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 0;
            label6.Text = "Current Index";
            label6.Click += label4_Click;
            // 
            // lsvResult
            // 
            lsvResult.Location = new Point(24, 281);
            lsvResult.Name = "lsvResult";
            lsvResult.Size = new Size(687, 320);
            lsvResult.TabIndex = 3;
            lsvResult.UseCompatibleStateImageBehavior = false;
            lsvResult.View = View.Details;
            // 
            // txtboxLastIndex
            // 
            txtboxLastIndex.Location = new Point(730, 60);
            txtboxLastIndex.Name = "txtboxLastIndex";
            txtboxLastIndex.Size = new Size(208, 26);
            txtboxLastIndex.TabIndex = 1;
            txtboxLastIndex.TextChanged += textBox1_TextChanged;
            // 
            // txtBoxCurrentIndex
            // 
            txtBoxCurrentIndex.Location = new Point(730, 110);
            txtBoxCurrentIndex.Name = "txtBoxCurrentIndex";
            txtBoxCurrentIndex.Size = new Size(208, 26);
            txtBoxCurrentIndex.TabIndex = 1;
            txtBoxCurrentIndex.TextChanged += txtBoxCurrentIndex_TextChanged;
            // 
            // lblFinalCost
            // 
            lblFinalCost.AutoSize = true;
            lblFinalCost.Location = new Point(724, 168);
            lblFinalCost.Name = "lblFinalCost";
            lblFinalCost.Size = new Size(143, 20);
            lblFinalCost.TabIndex = 4;
            lblFinalCost.Text = "(Result appear here)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 232);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 5;
            label7.Text = "Status:";
            // 
            // lblStatusSMS
            // 
            lblStatusSMS.AutoSize = true;
            lblStatusSMS.Location = new Point(88, 232);
            lblStatusSMS.Name = "lblStatusSMS";
            lblStatusSMS.Size = new Size(0, 20);
            lblStatusSMS.TabIndex = 5;
            // 
            // lblIDErrSms
            // 
            lblIDErrSms.AutoSize = true;
            lblIDErrSms.Location = new Point(157, 97);
            lblIDErrSms.Name = "lblIDErrSms";
            lblIDErrSms.Size = new Size(0, 20);
            lblIDErrSms.TabIndex = 0;
            lblIDErrSms.Click += label4_Click;
            // 
            // lblNameErrSMS
            // 
            lblNameErrSMS.AutoSize = true;
            lblNameErrSMS.Location = new Point(157, 168);
            lblNameErrSMS.Name = "lblNameErrSMS";
            lblNameErrSMS.Size = new Size(0, 20);
            lblNameErrSMS.TabIndex = 0;
            lblNameErrSMS.Click += label4_Click;
            // 
            // lblLastIndexErrSMS
            // 
            lblLastIndexErrSMS.AutoSize = true;
            lblLastIndexErrSMS.Location = new Point(963, 63);
            lblLastIndexErrSMS.Name = "lblLastIndexErrSMS";
            lblLastIndexErrSMS.Size = new Size(0, 20);
            lblLastIndexErrSMS.TabIndex = 0;
            lblLastIndexErrSMS.Click += label4_Click;
            // 
            // lblCurrentIndexErrSms
            // 
            lblCurrentIndexErrSms.AutoSize = true;
            lblCurrentIndexErrSms.Location = new Point(963, 113);
            lblCurrentIndexErrSms.Name = "lblCurrentIndexErrSms";
            lblCurrentIndexErrSms.Size = new Size(0, 20);
            lblCurrentIndexErrSms.TabIndex = 0;
            lblCurrentIndexErrSms.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 645);
            Controls.Add(lblStatusSMS);
            Controls.Add(label7);
            Controls.Add(lblFinalCost);
            Controls.Add(lsvResult);
            Controls.Add(btnSubmit);
            Controls.Add(tbCustomerName);
            Controls.Add(txtBoxCurrentIndex);
            Controls.Add(txtboxLastIndex);
            Controls.Add(tbCustomerID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblNameErrSMS);
            Controls.Add(lblCurrentIndexErrSms);
            Controls.Add(lblLastIndexErrSMS);
            Controls.Add(lblIDErrSms);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Electric Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbCustomerID;
        private TextBox tbCustomerName;
        private Button btnSubmit;
        private Label label5;
        private Label label6;
        private ListView lsvResult;
        private TextBox txtboxLastIndex;
        private TextBox txtBoxCurrentIndex;
        private Label lblFinalCost;
        private Label label7;
        private Label lblStatusSMS;
        private Label lblIDErrSms;
        private Label lblNameErrSMS;
        private Label lblLastIndexErrSMS;
        private Label lblCurrentIndexErrSms;
    }
}
