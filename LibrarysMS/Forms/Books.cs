using CRUD;
using MainClass;
using RJCodeAdvance.RJControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarysMS.Forms
{
    public partial class Books : Form
    {

        int bookID;
        public Books()
        {
            InitializeComponent();
            dataGridView1.RowPostPaint += dataGridView1_RowPostPaint;

            loadData();

            update.Enabled = false;
            delete.Enabled = false;

        }

        public void loadData()
        {
            ListBox listBox = new ListBox();
            listBox.Items.Add(BookIDs);
            listBox.Items.Add(Title);
            listBox.Items.Add(Author);
            listBox.Items.Add(Genre);
            listBox.Items.Add(Quantity);
            

            CRUD.crud.loadData("GetBooks", dataGridView1, listBox);


        }

        private void Books_Load(object sender, EventArgs e)
        {
            titleTXTs.Focus();

            try
            {
                CRUD.crud.loadRole("GetGenres", comboBox1, "GenreID", "Name");
            }
            catch (Exception ex)
            {
                mainClass.showMessage(ex.ToString(), false);
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
                    { "@Title", titleTXTs.Texts },
                    { "@Author", authorTXT.Texts },
                    { "@GenreID", Convert.ToInt32(comboBox1.SelectedValue.ToString()) },
                    { "@Quantity", qtyTXT.Texts }
                };
                CRUD.crud.DataInsertUpdateDelete("InsertBook", ht, "Data inserted");

            }

            loadData();
            EmptyTextBoxs(flowLayoutPanel1);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                loginBtn.Enabled = false;   
                update.Enabled = true;
                delete.Enabled = true;
                bookID = Convert.ToInt32(row.Cells["BookIDs"].Value);
                
                titleTXTs.Texts = row.Cells["Title"].Value.ToString();
                authorTXT.Texts = row.Cells["Author"].Value.ToString();
                comboBox1.SelectedItem = row.Cells["Genre"].Value.ToString();
                qtyTXT.Texts = row.Cells["Quantity"].Value.ToString();

            }
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
                    {"@BookID",bookID },
                    { "@Title", titleTXTs.Texts },
                    { "@Author", authorTXT.Texts },
                    { "@GenreID", Convert.ToInt32(comboBox1.SelectedValue.ToString()) },
                    { "@Quantity", qtyTXT.Texts }
                };
                CRUD.crud.DataInsertUpdateDelete("UpdateBook", ht, "Data Updated");

            }

            loadData();
            mainClass.EmptyTextBoxs(flowLayoutPanel1);
            loginBtn.Enabled = true;
            update.Enabled = false;
            delete.Enabled = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add("@BookID", bookID);


            crud.DataInsertUpdateDelete("DeleteBook", ht, "Data deleted");
            loadData();
            loginBtn.Enabled = true;
            update.Enabled = false;
            delete.Enabled = false;

        }

        public void EmptyTextBoxs(Panel p)
        {
            foreach (RJTextBox tb in p.Controls)
            {
                tb.Texts = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            search();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        public void search()
        {
            ListBox listBox = new ListBox();
            listBox.Items.Add(BookIDs);
            listBox.Items.Add(Title);
            listBox.Items.Add(Author);
            listBox.Items.Add(Genre);
            listBox.Items.Add(Quantity);



            crud.searchData("SearchBooks", dataGridView1, listBox, textBox1.Text);
            //loadData();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }


  
}
