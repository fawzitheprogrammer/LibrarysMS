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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibrarysMS.Forms
{
    public partial class StaffForm : Form
    {

        int staffID;
        public StaffForm()
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
            listBox.Items.Add(StaffIDS);
            listBox.Items.Add(Names);
            listBox.Items.Add(Position);
            listBox.Items.Add(Phone);
            listBox.Items.Add(Username);
            listBox.Items.Add(Password);
            CRUD.crud.loadData("GetStaff", dataGridView1, listBox);


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

        private void StaffForm_Load(object sender, EventArgs e)
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
                staffID = Convert.ToInt32(row.Cells["StaffIDS"].Value);
                nameTXTs.Texts = row.Cells["Names"].Value.ToString();
                phoneTXT.Texts = row.Cells["Phone"].Value.ToString();
                userPosition.SelectedItem = row.Cells["Position"].Value.ToString();
                usernameTXT.Texts = row.Cells["Username"].Value.ToString();
                passTXT.Texts = row.Cells["Password"].Value.ToString();

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
                    { "@Name", nameTXTs.Texts },
                    { "@Position", userPosition.SelectedItem.ToString() },
                    { "@Phone", phoneTXT.Texts },
                    { "@Username", usernameTXT.Texts },
                    { "@Password", passTXT.Texts }
                };
                CRUD.crud.DataInsertUpdateDelete("InsertStaff", ht, "Data inserted");

            }

            loadData();
            mainClass.EmptyTextBoxs(flowLayoutPanel1);

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

                    { "@StaffID", staffID },
                    { "@Name", nameTXTs.Texts },
                    { "@Position", userPosition.SelectedItem.ToString() },
                    { "@Phone", phoneTXT.Texts },
                    { "@Username", usernameTXT.Texts },
                    { "@Password", passTXT.Texts }
                };
                CRUD.crud.DataInsertUpdateDelete("UpdateStaff", ht, "Data Updated");

            }

            loadData();
            loginBtn.Enabled = true;
            update.Enabled = false;
            delete.Enabled = false;
            mainClass.EmptyTextBoxs(flowLayoutPanel1);

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add("@StaffID", staffID);


            crud.DataInsertUpdateDelete("DeleteStaff", ht, "Data deleted");
            loadData();
            loginBtn.Enabled = true;
            update.Enabled = false;
            delete.Enabled = false;
            mainClass.EmptyTextBoxs(flowLayoutPanel1);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            search();
        }

        public void search()
        {

            ListBox listBox = new ListBox();
            listBox.Items.Add(StaffIDS);
            listBox.Items.Add(Names);
            listBox.Items.Add(Position);
            listBox.Items.Add(Phone);
            listBox.Items.Add(Username);
            listBox.Items.Add(Password);



            crud.searchData("SearchStaff", dataGridView1, listBox, textBox1.Text);
            //loadData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
