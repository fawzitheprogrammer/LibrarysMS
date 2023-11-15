using CRUD;
using MainClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibrarysMS.Forms
{
    public partial class Borrower : Form
    {
        int BorrowerID;
        int BookID;
        int bookQty;
        public Borrower()
        {
            InitializeComponent();
            dataGridView1.RowPostPaint += dataGridView1_RowPostPaint;
            dataGridView1.CellClick += dataGridView1_CellClick;
            loadData();

            // Disabling update and delete button
            update.Enabled = false;
            detele.Enabled = false;

        }



        public void loadData()
        {
            ListBox listBox = new ListBox();
            listBox.Items.Add(BorrowersID);
            listBox.Items.Add(BorrowerName);
            listBox.Items.Add(Address);
            listBox.Items.Add(Phone);
            listBox.Items.Add(Book);
            listBox.Items.Add(Author);
            listBox.Items.Add(GenreID);
            listBox.Items.Add(Genre);
            listBox.Items.Add(BorrowDate);
            listBox.Items.Add(ReturnsDate);
            listBox.Items.Add(Quantity);
            listBox.Items.Add(BookIDs);
            listBox.Items.Add(Langauge);
            listBox.Items.Add(Edition);


            CRUD.crud.loadData("GetBorrowers", dataGridView1, listBox);
            CRUD.crud.loadRole("GetLanguage", book_language, "LanguageID", "Language");
            CRUD.crud.loadRole("GetEditions", book_editions, "EditionID", "Edition");


        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            // Get the index column index
            int indexColumnIndex = 0; // Replace with the actual column index

            // Set the value for each cell in the index column
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Cells[indexColumnIndex].Value = (row.Index + 1).ToString();
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            if (mainClass.checkControls(flowLayoutPanel1).Count > 0)
            {
                mainClass.showMessage("Please fill out all fields.", false);
            }
            else
            {

                Hashtable ht = new Hashtable
                {
                    { "@Name", BName.Texts },
                    { "@Address", BAddress.Texts },
                    { "@Phone", BPhone.Texts},
                    { "@BorrowedBookID", Convert.ToInt32(books.SelectedValue.ToString())  },
                    { "@BorrowedBookQty", BQty.Texts  },
                    { "@BorrowDate", DateTime.Now  },
                    { "@ReturnDate", returnDate.Value  },
                    { "@BookLanguage", Convert.ToInt32(book_language.SelectedValue.ToString()) },
                    { "@BookEditions", Convert.ToInt32(book_editions.SelectedValue.ToString()) },
                    
                };
                CRUD.crud.DataInsertUpdateDelete("InsertBorrower", ht, "Data inserted");

            }



            loadData();
            mainClass.EmptyTextBoxs(flowLayoutPanel1);

        }

        private void Borrower_Load(object sender, EventArgs e)
        {

            try
            {
                CRUD.crud.loadRole("GetBooks", books, "BookID", "Title");

            }

            catch (Exception ex)
            {
                mainClass.showMessage(ex.ToString(), false);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (mainClass.checkControls(flowLayoutPanel1).Count > 0)
            {
                mainClass.showMessage("Please fill out all fields.", false);
            }
            else
            {

                Hashtable ht = new Hashtable
                {
                     { "@BorrowerID", BorrowerID },
                   { "@Name", BName.Texts },
                    { "@Address", BAddress.Texts },
                    { "@Phone", BPhone.Texts},
                    { "@BorrowedBookID", Convert.ToInt32(books.SelectedValue.ToString())  },
                    { "@BorrowedBookQty", BQty.Texts  },
                    { "@BorrowDate", DateTime.Now  },
                    { "ReturnDate", returnDate.Value  }
                };
                CRUD.crud.DataInsertUpdateDelete("UpdateBorrower", ht, "Data Updated");

            }

            loadData();
            mainClass.EmptyTextBoxs(flowLayoutPanel1);
            loginBtn.Enabled = true;
            update.Enabled = false;
            detele.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {

                //Enabliing delete & update button & disabling button save
                update.Enabled = true;
                detele.Enabled = true;

                //
                loginBtn.Enabled = false;


                BookID = Convert.ToInt32(row.Cells["BookIDs"].Value);
                BorrowerID = Convert.ToInt32(row.Cells["BorrowersID"].Value);

                BName.Texts = row.Cells["BorrowerName"].Value.ToString();
                BAddress.Texts = row.Cells["Address"].Value.ToString();
                BPhone.Texts = row.Cells["Phone"].Value.ToString() ;
                
                returnDate.Value = DateTime.Parse(row.Cells["ReturnsDate"].Value.ToString());
                BQty.Texts = row.Cells["Quantity"].Value.ToString();

                Console.WriteLine(row.Cells["Book"].Value);


            }
        }

        private void detele_Click(object sender, EventArgs e)
        {

            Hashtable ht = new Hashtable
            {
                { "@BorrowerID", BorrowerID },
                { "@BookID", BookID },
                { "@Quantity", BQty.Texts }
            };


            crud.DataInsertUpdateDelete("DeleteBorrower", ht, "Data deleted");
            loadData();
        }

        private void books_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            search();
        }

        public void search()
        {
            ListBox listBox = new ListBox();
            listBox.Items.Add(BorrowersID);
            listBox.Items.Add(BorrowerName);
            listBox.Items.Add(Address);
            listBox.Items.Add(Phone);
            listBox.Items.Add(Book);
            listBox.Items.Add(BorrowDate);
            listBox.Items.Add(ReturnsDate);
            listBox.Items.Add(Quantity);
            listBox.Items.Add(BookIDs);


            crud.searchData("SearchBorrrower", dataGridView1, listBox, textBox1.Text);
            //loadData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
