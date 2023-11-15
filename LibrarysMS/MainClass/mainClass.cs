using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Drawing;
using RJCodeAdvance.RJControls;
using Guna.UI2.WinForms;

namespace MainClass
{
    public class mainClass
    {
     /*   public static void sno(DataGridView gv,string snoGV)
        {
            int count = 0; //1001, 1002 ,1003
            foreach(DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[snoGV].Value = count;
            }
        }*/

        private static string path;


        private static string connectionString()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\lib_ms";
            if (File.Exists(path))
            {
                return File.ReadAllText(path);

            }
            else
            {
                return "";
            }
        }

        public static SqlConnection con = new SqlConnection(connectionString());

        public static void showMessage(string text, bool? isSuccess)
        {
            if (text == "")
            {
                return;
            }
            else
            {
                if (isSuccess == true)
                {
                    MessageBox.Show(text, "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(text, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static ArrayList resetEnable(Panel p)
        {
            ArrayList arr = new ArrayList();

            foreach (Control c in p.Controls)
            {
                if (c is RJTextBox)
                {
                    RJTextBox tb = (RJTextBox)c;
                    tb.Texts = "";
                    tb.Enabled = true;
                    tb.BackColor = Color.White;
                }
            }

            return arr;
        }

        public static void EmptyTextBoxs(Panel p)
        {
            foreach (Control c in p.Controls)
            {

                if (c is RJTextBox)
                {
                    RJTextBox tb = (RJTextBox)c;

                    tb.Texts = "";

                }
            }
        }

        public static ArrayList checkControls(Panel p)
        {
            ArrayList arr = new ArrayList();

            foreach(Control c in p.Controls)
            {
                if(c is RJTextBox)
                {
                    RJTextBox tb = (RJTextBox)c;
                    if(tb.AllowDrop == true)
                    {

                    }
                    else
                    {
                        if (tb.Texts == ""){
                            arr.Add(tb);
                        }
                        else
                        {
                            if (arr.Contains(tb))
                            {
                                arr.Remove(tb);
                            }
                        }
                        tb.BorderColor = tb.Texts == "" ? tb.BorderColor = Color.Firebrick : tb.BorderColor = Color.Blue;
                        tb.ForeColor = tb.Texts == "" ? tb.ForeColor = Color.Black : tb.ForeColor = Color.Black;
                    }
                }
                if (c is ComboBox)
                {
                    ComboBox tb = (ComboBox)c;
                    if (tb.AllowDrop == true)
                    {

                    }
                    else
                    {
                        if (tb.SelectedIndex<0)
                        {
                            arr.Add(tb);
                        }
                        else
                        {
                            if (arr.Contains(tb))
                            {
                                arr.Remove(tb);
                            }
                        }
                        tb.BackColor = tb.Text == "" ? tb.BackColor = Color.Firebrick : tb.BackColor = Color.White;
                        tb.ForeColor = tb.Text == "" ? tb.ForeColor = Color.White : tb.ForeColor = Color.Black;
                    }
                }
            }

            return arr;
        }

    }
}
