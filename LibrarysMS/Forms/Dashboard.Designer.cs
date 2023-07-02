
namespace LibraryMS
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.staff = new System.Windows.Forms.Button();
            this.borrowers = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.date = new System.Windows.Forms.Label();
            this.loggedInAs = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.Button();
            this.books = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.02709F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.31527F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.31527F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.31527F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.0271F));
            this.tableLayoutPanel1.Controls.Add(this.staff, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.borrowers, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.genre, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.books, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(1784, 1031);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.11563F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.11563F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.61689F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.61689F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.80299F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.860349F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2296, 1234);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // staff
            // 
            this.staff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.staff.FlatAppearance.BorderSize = 0;
            this.staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staff.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff.Image = ((System.Drawing.Image)(resources.GetObject("staff.Image")));
            this.staff.Location = new System.Drawing.Point(623, 615);
            this.staff.Name = "staff";
            this.staff.Size = new System.Drawing.Size(345, 186);
            this.staff.TabIndex = 4;
            this.staff.Text = "Staff";
            this.staff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.staff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.staff.UseVisualStyleBackColor = false;
            this.staff.Click += new System.EventHandler(this.staff_Click);
            // 
            // borrowers
            // 
            this.borrowers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borrowers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.borrowers.FlatAppearance.BorderSize = 0;
            this.borrowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowers.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowers.Image = ((System.Drawing.Image)(resources.GetObject("borrowers.Image")));
            this.borrowers.Location = new System.Drawing.Point(1325, 423);
            this.borrowers.Name = "borrowers";
            this.borrowers.Size = new System.Drawing.Size(345, 186);
            this.borrowers.TabIndex = 2;
            this.borrowers.Text = "Borrowers";
            this.borrowers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.borrowers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.borrowers.UseVisualStyleBackColor = false;
            this.borrowers.Click += new System.EventHandler(this.borrowers_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.loggedInAs);
            this.panel1.Location = new System.Drawing.Point(3, 1163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2290, 68);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibrarysMS.Properties.Resources.exit;
            this.pictureBox2.Location = new System.Drawing.Point(16, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LibrarysMS.Properties.Resources.Frame6;
            this.pictureBox1.Location = new System.Drawing.Point(1963, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold);
            this.date.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.date.Location = new System.Drawing.Point(2015, 17);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(246, 36);
            this.date.TabIndex = 3;
            this.date.Text = "Admin : Fawzi Gharib";
            // 
            // loggedInAs
            // 
            this.loggedInAs.AutoSize = true;
            this.loggedInAs.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold);
            this.loggedInAs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loggedInAs.Location = new System.Drawing.Point(84, 17);
            this.loggedInAs.Name = "loggedInAs";
            this.loggedInAs.Size = new System.Drawing.Size(246, 36);
            this.loggedInAs.TabIndex = 0;
            this.loggedInAs.Text = "Admin : Fawzi Gharib";
            // 
            // genre
            // 
            this.genre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.genre.FlatAppearance.BorderSize = 0;
            this.genre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre.Image = ((System.Drawing.Image)(resources.GetObject("genre.Image")));
            this.genre.Location = new System.Drawing.Point(974, 615);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(345, 186);
            this.genre.TabIndex = 3;
            this.genre.Text = "Genre";
            this.genre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.genre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.genre.UseVisualStyleBackColor = false;
            this.genre.Click += new System.EventHandler(this.genre_Click);
            // 
            // books
            // 
            this.books.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.books.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.tableLayoutPanel1.SetColumnSpan(this.books, 2);
            this.books.FlatAppearance.BorderSize = 0;
            this.books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.books.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.books.Image = ((System.Drawing.Image)(resources.GetObject("books.Image")));
            this.books.Location = new System.Drawing.Point(623, 423);
            this.books.Name = "books";
            this.books.Size = new System.Drawing.Size(696, 186);
            this.books.TabIndex = 0;
            this.books.Text = "Books";
            this.books.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.books.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.books.UseVisualStyleBackColor = false;
            this.books.Click += new System.EventHandler(this.button1_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(2296, 1234);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1776, 1085);
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button books;
        private System.Windows.Forms.Button borrowers;
        private System.Windows.Forms.Button genre;
        private System.Windows.Forms.Button staff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loggedInAs;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

