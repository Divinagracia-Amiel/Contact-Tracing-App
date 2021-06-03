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
        string firstName;
        string lastName;
        string eMail;
        string mobileNumber;
        string addressvar;

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
            StreamWriter TraceFile;

            date = DateTime.Now.ToLongDateString();
            firstName = F_name.Text;
            lastName = L_name.Text;
            eMail = email.Text;
            mobileNumber = mobNum.Text;
            addressvar = address.Text;
            
        }

        private void import_Click(object sender, EventArgs e)
        {
            importDataForm importForm = new importDataForm();
            this.Hide();
            importForm.Show();
        }
    }
}
