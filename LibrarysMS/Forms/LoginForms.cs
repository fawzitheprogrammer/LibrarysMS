using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainClass;
using Authentication;
using ClinicDB.Forms;

namespace LibraryMS.Forms
{
    public partial class LoginForm : Form
    {
        private bool isDragging;
        private int mouseX;
        private int mouseY;

        public LoginForm()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
    
        }


        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = e.X - mouseX;
                int deltaY = e.Y - mouseY;
                Location = new System.Drawing.Point(Location.X + deltaX, Location.Y + deltaY);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            // C:\Users\SOFTWARE\Documents
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\lib_ms";
            if (!File.Exists(path))
            {
                MainClass.mainClass.showMessage("You are not connected to the server, please connect to the server and try again", false);
            }
            else
            {
                Console.WriteLine(login.Position + "" + login.Username);
                if (MainClass.mainClass.checkControls(loginPanel).Count > 0)
                {
                    MainClass.mainClass.showMessage("Please fill out all fields to continue", false);
                }
                else
                {

                    Hashtable ht = new Hashtable();

                    ht.Add("@username", userText.Text);
                    ht.Add("@pass", passText.Text);
                    ht.Add("@role", role.SelectedItem.ToString());


                    if (login.getLoginDetails("LoginAuth", ht))
                    {
                        if (login.Position != "Admin")
                        {
                            this.Hide();
                            dashboard mf = new dashboard();
                          /*  mf.staffBtn.Hide();
                            mf.roles.Hide();*/
                            mf.Show();

                        }
                        else
                        {
                            this.Hide();
                            dashboard mf = new dashboard();
                            mf.Show();

                        }
                    }

                }

            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // C:\Users\SOFTWARE\Documents
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\lib_ms";
            if (!File.Exists(path))
            {
                ConnectionForrm connection = new ConnectionForrm();
                connection.ShowDialog();
            }
            else
            {

                MainClass.mainClass.showMessage("Connnected", true);

            }
        }
    }
}
