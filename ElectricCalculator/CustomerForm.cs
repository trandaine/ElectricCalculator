using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElectricCalculator;

namespace ElectricCalculator
{
    public partial class CustomerForm : Form
    {
        // Regular expression for name validation
        private const string NAME_REGEX = @"^[A-Za-z\s]+$";
        // Regular expression for ID validation
        private const string ID_REGEX = @"^[A-Za-z0-9]+$";
        // regular expression for number validation
        private const string NUMBER_REGEX = @"^[0-9]+$";
        private const string connectionString = "Server=192.168.0.178, 1433;Database=ElectricCalculator;User ID=sa;Password=Dai@2018; TrustServerCertificate=True; Trusted_Connection=False; MultipleActiveResultSets=true;";
        public CustomerForm()
        {
            InitializeComponent();
        }

        #region Form elements

        // Customer ID textbox
        private void txbCustomerID_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txbCustomerID.Text.Length; i++)
            {
                checkCustomerID("Invalid ID. Must type an Interger", lblCustomerIDErrMsg, txbCustomerID);
            }
        }


        // Customer Name textbox
        private void txbCustomerName_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txbCustomerName.Text.Length; i++)
            {
                checkAlphabeticalValue("Invalid Name", lblCustomerNameErrMsg, txbCustomerName);
            }
        }


        // Submit button
        private void btnCustomerSubmit_Click(object sender, EventArgs e)
        {
            insert_CustomerToDb2(sender, e);
        }
        #endregion



        #region Validate functions
        /// <summary>
        /// Function to validate the name input of the customer
        /// </summary>
        /// <param name="msgError">The error message you want to input</param>
        /// <param name="nameLabel">The label where you want to put the error message in</param>
        /// <param name="txbName">The textbox where the input string you want to check</param>
        private void checkAlphabeticalValue(string msgError, Label nameLabel, TextBox txbName)
        {
            Regex nameRegex = new Regex(NAME_REGEX);
            nameLabel.Text = string.Empty;
            if (!nameRegex.IsMatch(txbName.Text))
            {
                nameLabel.Text = msgError;
                nameLabel.ForeColor = Color.Red;
            }
        }


        /// <summary>
        /// Function to validate the ID input of the customer
        /// </summary>
        /// <param name="msgError">The error message you want to input</param>
        /// <param name="idLabel">The label where you want to put the error message in</param>
        /// <param name="txbID">The textbox where the input string you want to check</param>
        private void checkCustomerID(string msgError, Label idLabel, TextBox txbID)
        {
            Regex idRegex = new Regex(NUMBER_REGEX);
            idLabel.Text = string.Empty;
            if (!idRegex.IsMatch(txbID.Text))
            {
                idLabel.Text = msgError;
                idLabel.ForeColor = Color.Red;
            }
        }

        #endregion

        



        //Function to connect to database and insert data
        
        private void insert_CustomerToDb2(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (int.TryParse(txbCustomerID.Text, out int customerID))
                {
                    var customerName = txbCustomerName.Text?.Trim();
                    var dateOfBirth = dtpCustomerDateOfBirth.Value.ToShortDateString();
                    string queryString = "INSERT INTO Customers (ID, FullName, DateOfBirth) VALUES (" + customerID + ", '" + customerName + "', convert(datetime, '" + dateOfBirth + "', 103));";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        command.Dispose();
                        //MessageBox.Show("Successfully created!");
                        // Hide the current form
                        this.Hide();

                        // Create an instance of the second form
                        var newElectricCalculatorForm = new Form1();

                        // Show the second form
                        newElectricCalculatorForm.Show();
                        newElectricCalculatorForm.Focus();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                //else
                //{
                //    MessageBox.Show("Invalid customer ID. Please enter a valid integer value.");
                //}
            }
        }


       
    }
}
