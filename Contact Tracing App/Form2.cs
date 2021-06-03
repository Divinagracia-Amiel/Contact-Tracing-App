using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class importDataForm : Form
    {
        public importDataForm()
        {
            InitializeComponent();
        }

        private void importDataForm_Load(object sender, EventArgs e)
        {

        }

        private void imp_submitBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void export_Click(object sender, EventArgs e)
        {
            Form1 contactTracing = new Form1();
            this.Hide();
            contactTracing.ShowDialog();
            this.Close();
        }
    }
}
