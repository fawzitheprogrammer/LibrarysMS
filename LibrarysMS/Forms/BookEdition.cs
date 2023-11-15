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
    public partial class BookEdition : Form
    {


        int genreID;

        public BookEdition()
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
            listBox.Items.Add(EditionIDs);
            listBox.Items.Add(EditionTitle);
            CRUD.crud.loadData("GetEditions", dataGridView1, listBox);


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

                    { "@Edition", titleTXTs.Texts  }

                };
                CRUD.crud.DataInsertUpdateDelete("InsertEdition", ht, "Data inserted");

            }

            loadData();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (mainClass.checkControls(flowLayoutPanel1).Count > 0)
            {
                mainClass.showMessage("Please fill out all fields.", false);
            }
            else
            {

                Hashtable ht = new Hashtable
                {
                           { "@EditionsID", genreID  },
                           { "@Editions", titleTXTs.Texts  }

                };
                CRUD.crud.DataInsertUpdateDelete("UpdateEditions", ht, "Data Updated");

            }
            loginBtn.Enabled = true;
            update.Enabled = false;
            delete.Enabled = false;
            loadData();
            mainClass.EmptyTextBoxs(flowLayoutPanel1);

        }


        private void delete_Click(object sender, EventArgs e)
        {

            Hashtable ht = new Hashtable();
            ht.Add("@EditionsID", genreID);


            crud.DataInsertUpdateDelete("DeleteEditions", ht, "Data deleted");
            loadData();
            loginBtn.Enabled = true;
            update.Enabled = false;
            delete.Enabled = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {

                loginBtn.Enabled = false;
                update.Enabled = true;
                delete.Enabled = true;
                genreID = Convert.ToInt32(row.Cells["EditionIDs"].Value);
                titleTXTs.Texts = row.Cells["EditionTitle"].Value.ToString();

            }
        }

    }
}
