using System.Drawing.Text;
using System.Text.RegularExpressions;

namespace ElectricCalculator
{
    public partial class Form1 : Form
    {
        string namePattern = @"[A-Za-z/s]$";      // Regular expression for name
        string idPattern = @"[A-Za-z0-9]$";             // Regular expression for ID
        string numberPattern = @"[0-9]$";       // Regular expression for number
        private readonly float Pricelevel1_From0to50 = 1806F;
        private readonly float Pricelevel2_From51to100 = 1866F; 
        private readonly float Pricelevel3_From101to200 = 2167F;
        private readonly float Pricelevel4_From201to300 = 2729F;
        private readonly float Pricelevel5_From301to400 = 3050F;
        private readonly float Pricelevel6_From401 = 3151F;

        public Form1()
        {
            InitializeComponent();
            lsvResult.Columns.Add("Customer ID", 100);
            lsvResult.Columns.Add("Customer Name", 100);
            lsvResult.Columns.Add("Last Index", 100);
            lsvResult.Columns.Add("Current Index", 100);
            lsvResult.Columns.Add("Total Cost", 100);
        }
        private float calculateElectricPrice_v2(float consumptionIndex)
        {
            float price = 0;
            int[]arrayindex = new int[6] {0,51,101, 201, 301, 401 };
            float[]arrayPrice = new float[6] { 1806, 1866, 2167, 2729, 3050, 3151 };
            for(int i = arrayindex.Length -1; i>=0; i--)
            {
                
                float subIndex = consumptionIndex - arrayindex[i];
                if(subIndex > 0)
                {
                    price += subIndex * arrayPrice[i];      // calculate the price
                    //consumptionIndex -= subIndex;       // reduce the consumption index
                }
                else
                {
                    subIndex = arrayindex[i] - 1;
                }
            }
            return price;
        }

        private double CalculateElectricPrice_v3(int indexElectricity)
        {
            double price = 0;
            const int arrayLength = 6;
            int[] arrayIndex = new int[arrayLength] { 0, 51, 101, 201, 301, 401 };
            int[] arrayPrice = new int[arrayLength] { 1806, 1866, 2167, 2729, 3050, 3151 };
            for (int i = arrayLength - 1; i >= 0; i--   )
            {
                int subIndex = indexElectricity - arrayIndex[i];

                if (subIndex<0)
                {
                    continue;
                }
                price += subIndex * arrayPrice[i];
                indexElectricity = arrayIndex[i];
            }
            return price;
        }
        private float calculateElectricPrice(float index)
        {
            float total = 0;
            if (index <= 50)
            {
                total = index * Pricelevel1_From0to50;
            }
            else if (index >= 51 && index <= 100)           // 51 - 100
            {
                total = (50 * Pricelevel1_From0to50) 
                    + (index - 50) 
                    * Pricelevel2_From51to100;
            }
            else if (index >= 101 && index <= 200)          // 101 - 200
            {
                total = (50 * Pricelevel1_From0to50) 
                    + (50 * Pricelevel2_From51to100) 
                    + (index - 100) 
                    * Pricelevel3_From101to200;
            }
            else if (index >= 201 && index <= 300)          // 201 - 300
            {
                total = (50 * Pricelevel1_From0to50) 
                    + (50 * Pricelevel2_From51to100) 
                    + (100 * Pricelevel3_From101to200)
                    + (index - 200) 
                    * Pricelevel4_From201to300;
            }
            else if (index >= 301 && index <= 400)
            {
                total = (50 * Pricelevel1_From0to50) 
                    + (50 * Pricelevel2_From51to100) 
                    + (100 * Pricelevel3_From101to200) 
                    + (100 * Pricelevel4_From201to300) 
                    + (index - 300) 
                    * Pricelevel5_From301to400;
            }
            else if (index >= 401)
            {
                total = (50 * Pricelevel1_From0to50) 
                    + (50 * Pricelevel2_From51to100) 
                    + (100 * Pricelevel3_From101to200) 
                    + (100 * Pricelevel4_From201to300) 
                    + (100 * Pricelevel5_From301to400) 
                    + (index - 400) 
                    * Pricelevel6_From401;
            }
            return total;
        }
        
        private void tbCustomerID_TextChanged(object sender, EventArgs e)
        {
            Regex idRegex = new Regex(idPattern);
            lblIDErrSms.Text = string.Empty;
            //try {
            //    var input = tbCustomerID.Text;
            //    if(string.IsNullOrEmpty(input)) lblIDErrSms.Text = "Nho71 nha6p5 nha chan noi";
            //    if (!idRegex.IsMatch(input))
            //    {
            //        lblIDErrSms.Text = "Invalid ID";
            //        lblIDErrSms.ForeColor = Color.Red;
            //    }

            //} 
            //catch (Exception ex)
            //{ }
            if (!idRegex.IsMatch(tbCustomerID.Text))
            {
                lblIDErrSms.Text = "Invalid ID";
                lblIDErrSms.ForeColor = Color.Red;
            }
        }

        private void tbCustomerName_TextChanged(object sender, EventArgs e)
        {
            Regex nameRegex = new Regex(namePattern);
            lblNameErrSMS.Text = string.Empty;
            if (!nameRegex.IsMatch(tbCustomerName.Text))
            {
                lblNameErrSMS.Text = "Invalid Name";
                lblNameErrSMS.ForeColor = Color.Red;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check the input of the currentindex and lastindex is greater than 0, if not show the error message and quit the function
            if (int.Parse(txtBoxCurrentIndex.Text) <= 0)
            {
                lblStatusSMS.Text = "Invalid Index (Your current index must not lower than 0)";
                lblStatusSMS.ForeColor = Color.Red;
                return;
            }
            else
            {
                float total = this.calculateElectricPrice_v2(float.Parse(txtBoxCurrentIndex.Text) - float.Parse(txtboxLastIndex.Text));
                lblStatusSMS.Text = "Success";
                lblStatusSMS.ForeColor = Color.Green;
                ListViewItem items = new ListViewItem(new string[]
                {
                this.tbCustomerID.Text,
                this.tbCustomerName.Text,
                this.txtboxLastIndex.Text,
                this.txtBoxCurrentIndex.Text,
                $"{total: #,###}VND",
                });
                this.lsvResult.Items.Add(items);
                this.lsvResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                this.lsvResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Regex lstLastIndexRegex = new Regex(numberPattern);
            lblLastIndexErrSMS.Text = string.Empty;
            if (!lstLastIndexRegex.IsMatch(txtboxLastIndex.Text))
            {
                lblLastIndexErrSMS.Text = "Invalid Number";
                lblLastIndexErrSMS.ForeColor = Color.Red;
            }
        }

        private void txtBoxCurrentIndex_TextChanged(object sender, EventArgs e)
        {
            Regex lstCurrentIndexRegex = new Regex(numberPattern);
            lblCurrentIndexErrSms.Text = string.Empty;
            if (!lstCurrentIndexRegex.IsMatch(txtBoxCurrentIndex.Text))
            {
                lblCurrentIndexErrSms.Text = "Invalid Number";
                lblCurrentIndexErrSms.ForeColor = Color.Red;
            }
            else
            {
                lblFinalCost.Text = $"{int.Parse(txtBoxCurrentIndex.Text) - int.Parse(txtboxLastIndex.Text)}";
            }
        }

        private bool ResetElectricFormError()
        {
            lblIDErrSms.Text = string.Empty;
            lblNameErrSMS.Text = string.Empty;
            lblLastIndexErrSMS.Text = string.Empty;
            lblCurrentIndexErrSms.Text = string.Empty;
            lblStatusSMS.Text = string.Empty;
            return true;
        }

        private void btnReset_Click()
        {
            tbCustomerID.Text = string.Empty;
            tbCustomerName.Text = string.Empty;
            txtboxLastIndex.Text = string.Empty;
            txtBoxCurrentIndex.Text = string.Empty;
            lblFinalCost.Text = string.Empty;
            ResetElectricFormError();
        }

        private void GenerateErrMessage()
        {

        }
    }   
}
