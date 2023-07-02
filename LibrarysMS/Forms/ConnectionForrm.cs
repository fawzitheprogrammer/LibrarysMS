using LibraryMS.Forms;
using Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicDB.Forms
{
    public partial class ConnectionForrm : Form
    {
        public ConnectionForrm()
        {
            InitializeComponent();
        }

        private void username__TextChanged(object sender, EventArgs e)
        {

        }

        private void ConnectionForrm_Load(object sender, EventArgs e)
        {
            /*string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\cms_connect";
            if (!File.Exists(path))
            {

            }
            else
            {
                LoginForm lf = new LoginForm();
                lf.ShowDialog();
               
            }*/

        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            // C:\Users\SOFTWARE\Documents
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "lib_ms";
            if (!File.Exists(path))
            {
                Settings.settings.createFile("\\lib_ms", sourceText.Texts, dbText.Texts);
                LoginForm lf = new LoginForm();
                this.Hide();
                lf.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Connection file already exists at the specified path", "File Exists",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
