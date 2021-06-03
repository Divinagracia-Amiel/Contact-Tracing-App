using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class Form1 : Form
    {
        string date;
        string time;
        string firstName;
        string lastName;
        string eMail;
        string addressvar;
        int agevar;
        long mobileNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void F_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void L_nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }


    private void submitBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(age.Text, out agevar) == false)
            {
                MessageBox.Show("Age should be an Integer or a whole number");
                return;
            }
            if (long.TryParse(mobNum.Text, out mobileNumber) == false)
            {
                MessageBox.Show("Mobile number should be a series of integers");
                return;
            }
 
            StreamWriter TraceFile;

            date = DateTime.Now.ToLongDateString();
            time = DateTime.Now.ToLongTimeString();
            firstName = F_name.Text;
            lastName = L_name.Text;
            agevar = int.Parse(age.Text);
            eMail = email.Text;
            mobileNumber = long.Parse(mobNum.Text);
            addressvar = address.Text;

            TraceFile = File.AppendText(date + ".txt");
            TraceFile.WriteLine("//** " + time + "**//");
            TraceFile.WriteLine("First Name: " + firstName);
            TraceFile.WriteLine("Last Name: " + lastName);
            TraceFile.WriteLine("Age: " + agevar);
            TraceFile.WriteLine("E-mail Address: " + eMail);
            TraceFile.WriteLine("Mobile Number: " + mobileNumber);
            TraceFile.WriteLine("Address: " + addressvar);
            TraceFile.WriteLine();
            TraceFile.Close();

            MessageBox.Show("Form Submission Successful");
            F_name.Text = String.Empty;
            L_name.Text = String.Empty;
            age.Text = String.Empty;
            mobNum.Text = String.Empty;
            address.Text = String.Empty;
            email.Text = String.Empty;
        }

        private void import_Click(object sender, EventArgs e)
        {
            importDataForm importForm = new importDataForm();
            this.Hide();
            importForm.ShowDialog();
            this.Close();
        }
    }
}
