using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
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

        string txt_file;
        string open_file;

        private void importDataForm_Load(object sender, EventArgs e)
        {

        }

        private void imp_submitBtn_Click(object sender, EventArgs e)
        {
            import_method.ShowDialog();
            txt_file = import_method.FileName;
            open_file = File.ReadAllText(txt_file);
            imp_data.Text = open_file;
        }

        private void export_Click(object sender, EventArgs e)
        {
            Form1 contactTracing = new Form1();
            this.Hide();
            contactTracing.ShowDialog();
            this.Close();
        }

        private void import_method_FileOk(object sender, CancelEventArgs e)
        {
            
        }
    }
}
