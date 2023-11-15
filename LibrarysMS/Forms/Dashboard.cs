
using Authentication;
using LibraryMS.Forms;
using LibrarysMS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMS
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            date.Text = DateTime.Now.ToString();
            loggedInAs.Text = login.Position + " : " + login.User;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.ShowDialog();
        }
        //------------------------------------ 
        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //- ---------------------------------
        private void borrowers_Click(object sender, EventArgs e)
        {
            Borrower borrower = new Borrower();
            borrower.ShowDialog();
        }

        private void genre_Click(object sender, EventArgs e)
        {
            Genre genre = new Genre();
            genre.ShowDialog();
        }

        private void staff_Click(object sender, EventArgs e)
        {
            StaffForm staffForm = new StaffForm();  
            staffForm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BookEdition bookEdition = new BookEdition();
            bookEdition.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookLanguage bookLanguage = new BookLanguage();
            bookLanguage.ShowDialog();
        }
    }
}
