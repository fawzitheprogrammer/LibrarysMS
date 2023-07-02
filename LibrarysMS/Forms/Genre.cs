using CRUD;
using MainClass;
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
using System.Xml.Linq;
using static Guna.UI2.Native.WinApi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibrarysMS.Forms
{
    public partial class Genre : Form
    {


        int genreID;

        public Genre()
        {
            InitializeComponent();
            dataGridView1.RowPostPaint += dataGridView1_RowPostPaint;
            loadData();
            // Disabling update and delete button
            update.Enabled = false;
            delete.Enabled = false;
        }

        public void loadData()
        {
            ListBox listBox = new ListBox();
            listBox.Items.Add(BookIDs);
            listBox.Items.Add(GenresTitle);
            CRUD.crud.loadData("GetGenres", dataGridView1, listBox);


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
                   
                    { "@Name", titleTXTs.Texts  }

                };
                CRUD.crud.DataInsertUpdateDelete("InsertGenre", ht, "Data inserted");

            }

            loadData();
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
                           { "@GenreID", genreID  },
                           { "@Name", titleTXTs.Texts  }

                };
                CRUD.crud.DataInsertUpdateDelete("UpdateGenre", ht, "Data Updated");

            }
            loginBtn.Enabled = true;
            update.Enabled = false;
            delete.Enabled = false;
            loadData();
            mainClass.EmptyTextBoxs(flowLayoutPanel1);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {

                loginBtn.Enabled = false;
                update.Enabled = true;
                delete.Enabled = true;
                genreID = Convert.ToInt32(row.Cells["BookIDs"].Value);
                titleTXTs.Texts = row.Cells["GenresTitle"].Value.ToString();

            }
        }

        private void delete_Click(object sender, EventArgs e)
        {

            Hashtable ht = new Hashtable();
            ht.Add("@GenreID", genreID);


            crud.DataInsertUpdateDelete("DeleteGenre", ht, "Data deleted");
            loadData();
            loginBtn.Enabled = true;
            update.Enabled = false;
            delete.Enabled = false;

        }
    }
}
