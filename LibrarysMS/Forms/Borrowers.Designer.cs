namespace LibrarysMS.Forms
{
    partial class Borrower
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borrower));
            this.rjDropdownMenu1 = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.BName = new RJCodeAdvance.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BAddress = new RJCodeAdvance.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BPhone = new RJCodeAdvance.RJControls.RJTextBox();
            this.loginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.update = new Guna.UI2.WinForms.Guna2Button();
            this.detele = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.BQty = new RJCodeAdvance.RJControls.RJTextBox();
            this.books = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.book_language = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.book_editions = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowersID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnsDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookIDs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Langauge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublicationYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rjDropdownMenu1
            // 
            this.rjDropdownMenu1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.rjDropdownMenu1.IsMainMenu = false;
            this.rjDropdownMenu1.MenuItemHeight = 25;
            this.rjDropdownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Name = "rjDropdownMenu1";
            this.rjDropdownMenu1.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Name";
            // 
            // BName
            // 
            this.BName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BName.BackColor = System.Drawing.SystemColors.Window;
            this.BName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BName.BorderRadius = 0;
            this.BName.BorderSize = 1;
            this.BName.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BName.Location = new System.Drawing.Point(3, 28);
            this.BName.Multiline = false;
            this.BName.Name = "BName";
            this.BName.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.BName.PasswordChar = false;
            this.BName.PlaceholderColor = System.Drawing.SystemColors.ControlText;
            this.BName.PlaceholderText = "";
            this.BName.Size = new System.Drawing.Size(285, 33);
            this.BName.TabIndex = 36;
            this.BName.Texts = "";
            this.BName.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "Address";
            // 
            // BAddress
            // 
            this.BAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BAddress.BackColor = System.Drawing.SystemColors.Window;
            this.BAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BAddress.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BAddress.BorderRadius = 0;
            this.BAddress.BorderSize = 1;
            this.BAddress.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BAddress.Location = new System.Drawing.Point(3, 92);
            this.BAddress.Multiline = false;
            this.BAddress.Name = "BAddress";
            this.BAddress.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.BAddress.PasswordChar = false;
            this.BAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.BAddress.PlaceholderText = "";
            this.BAddress.Size = new System.Drawing.Size(285, 33);
            this.BAddress.TabIndex = 37;
            this.BAddress.Texts = "";
            this.BAddress.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Book";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "Phone";
            // 
            // BPhone
            // 
            this.BPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BPhone.BackColor = System.Drawing.SystemColors.Window;
            this.BPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BPhone.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BPhone.BorderRadius = 0;
            this.BPhone.BorderSize = 1;
            this.BPhone.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BPhone.Location = new System.Drawing.Point(3, 156);
            this.BPhone.Multiline = false;
            this.BPhone.Name = "BPhone";
            this.BPhone.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.BPhone.PasswordChar = false;
            this.BPhone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.BPhone.PlaceholderText = "";
            this.BPhone.Size = new System.Drawing.Size(285, 33);
            this.BPhone.TabIndex = 39;
            this.BPhone.Texts = "";
            this.BPhone.UnderlinedStyle = false;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginBtn.Font = new System.Drawing.Font("Rabar_043", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(2, 494);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(286, 34);
            this.loginBtn.TabIndex = 41;
            this.loginBtn.Text = "Save";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.update.FillColor = System.Drawing.Color.Goldenrod;
            this.update.Font = new System.Drawing.Font("Rabar_043", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(2, 532);
            this.update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(286, 34);
            this.update.TabIndex = 42;
            this.update.Text = "Update";
            this.update.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // detele
            // 
            this.detele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.detele.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.detele.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.detele.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.detele.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.detele.FillColor = System.Drawing.Color.Silver;
            this.detele.Font = new System.Drawing.Font("Rabar_043", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detele.ForeColor = System.Drawing.Color.White;
            this.detele.Location = new System.Drawing.Point(2, 570);
            this.detele.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.detele.Name = "detele";
            this.detele.Size = new System.Drawing.Size(286, 34);
            this.detele.TabIndex = 43;
            this.detele.Text = "Delete";
            this.detele.Click += new System.EventHandler(this.detele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.BorrowersID,
            this.BorrowerName,
            this.Address,
            this.Phone,
            this.Book,
            this.Author,
            this.GenreID,
            this.Genre,
            this.BorrowDate,
            this.ReturnsDate,
            this.Quantity,
            this.BookIDs,
            this.Edition,
            this.Langauge,
            this.PublicationYear});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 3);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.Location = new System.Drawing.Point(2, 43);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 751);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.BName);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.BAddress);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.BPhone);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.BQty);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.books);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.returnDate);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.book_language);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.book_editions);
            this.flowLayoutPanel1.Controls.Add(this.loginBtn);
            this.flowLayoutPanel1.Controls.Add(this.update);
            this.flowLayoutPanel1.Controls.Add(this.detele);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(291, 796);
            this.flowLayoutPanel1.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Qunatity";
            // 
            // BQty
            // 
            this.BQty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BQty.BackColor = System.Drawing.SystemColors.Window;
            this.BQty.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BQty.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BQty.BorderRadius = 0;
            this.BQty.BorderSize = 1;
            this.BQty.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BQty.Location = new System.Drawing.Point(3, 220);
            this.BQty.Multiline = false;
            this.BQty.Name = "BQty";
            this.BQty.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.BQty.PasswordChar = false;
            this.BQty.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.BQty.PlaceholderText = "";
            this.BQty.Size = new System.Drawing.Size(285, 33);
            this.BQty.TabIndex = 48;
            this.BQty.Texts = "";
            this.BQty.UnderlinedStyle = false;
            // 
            // books
            // 
            this.books.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.books.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.books.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.books.FormattingEnabled = true;
            this.books.Location = new System.Drawing.Point(2, 283);
            this.books.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.books.Name = "books";
            this.books.Size = new System.Drawing.Size(287, 31);
            this.books.TabIndex = 40;
            this.books.SelectedIndexChanged += new System.EventHandler(this.books_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 316);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 50;
            this.label6.Text = "Return Date";
            // 
            // returnDate
            // 
            this.returnDate.CustomFormat = "";
            this.returnDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.returnDate.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.returnDate.Location = new System.Drawing.Point(2, 343);
            this.returnDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.returnDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.returnDate.MinDate = new System.DateTime(2023, 6, 4, 0, 0, 0, 0);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(287, 27);
            this.returnDate.TabIndex = 51;
            this.returnDate.Value = new System.DateTime(2023, 6, 4, 0, 0, 0, 0);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(291, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.275519F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.72448F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1018, 796);
            this.tableLayoutPanel1.TabIndex = 48;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::LibrarysMS.Properties.Resources.refresh;
            this.pictureBox2.Location = new System.Drawing.Point(956, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LibrarysMS.Properties.Resources.loupe1;
            this.pictureBox1.Location = new System.Drawing.Point(877, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.MaxLength = 50;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(869, 35);
            this.textBox1.TabIndex = 47;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 372);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 25);
            this.label8.TabIndex = 59;
            this.label8.Text = "Book Language";
            // 
            // book_language
            // 
            this.book_language.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.book_language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.book_language.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_language.FormattingEnabled = true;
            this.book_language.Location = new System.Drawing.Point(2, 399);
            this.book_language.Margin = new System.Windows.Forms.Padding(2);
            this.book_language.Name = "book_language";
            this.book_language.Size = new System.Drawing.Size(287, 31);
            this.book_language.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AllowDrop = true;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 432);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 25);
            this.label9.TabIndex = 61;
            this.label9.Text = "Book Editions";
            // 
            // book_editions
            // 
            this.book_editions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.book_editions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.book_editions.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_editions.FormattingEnabled = true;
            this.book_editions.Location = new System.Drawing.Point(2, 459);
            this.book_editions.Margin = new System.Windows.Forms.Padding(2);
            this.book_editions.Name = "book_editions";
            this.book_editions.Size = new System.Drawing.Size(287, 31);
            this.book_editions.TabIndex = 60;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "NO.";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 64;
            // 
            // BorrowersID
            // 
            this.BorrowersID.HeaderText = "BorrowersIDs";
            this.BorrowersID.MinimumWidth = 8;
            this.BorrowersID.Name = "BorrowersID";
            this.BorrowersID.Visible = false;
            this.BorrowersID.Width = 150;
            // 
            // BorrowerName
            // 
            this.BorrowerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BorrowerName.HeaderText = "Names";
            this.BorrowerName.MinimumWidth = 8;
            this.BorrowerName.Name = "BorrowerName";
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 8;
            this.Address.Name = "Address";
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 8;
            this.Phone.Name = "Phone";
            // 
            // Book
            // 
            this.Book.HeaderText = "Book";
            this.Book.MinimumWidth = 8;
            this.Book.Name = "Book";
            this.Book.Width = 150;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            // 
            // GenreID
            // 
            this.GenreID.HeaderText = "GenreID";
            this.GenreID.Name = "GenreID";
            this.GenreID.Visible = false;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            // 
            // BorrowDate
            // 
            this.BorrowDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BorrowDate.HeaderText = "Borrow Date";
            this.BorrowDate.MinimumWidth = 8;
            this.BorrowDate.Name = "BorrowDate";
            // 
            // ReturnsDate
            // 
            this.ReturnsDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReturnsDate.HeaderText = "Return Date";
            this.ReturnsDate.MinimumWidth = 8;
            this.ReturnsDate.Name = "ReturnsDate";
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 105;
            // 
            // BookIDs
            // 
            this.BookIDs.HeaderText = "BookID";
            this.BookIDs.MinimumWidth = 8;
            this.BookIDs.Name = "BookIDs";
            this.BookIDs.Visible = false;
            this.BookIDs.Width = 150;
            // 
            // Edition
            // 
            this.Edition.HeaderText = "Editions";
            this.Edition.Name = "Edition";
            // 
            // Langauge
            // 
            this.Langauge.HeaderText = "Langauge";
            this.Langauge.Name = "Langauge";
            // 
            // PublicationYear
            // 
            this.PublicationYear.HeaderText = "Publication Year";
            this.PublicationYear.Name = "PublicationYear";
            // 
            // Borrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 796);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(1284, 683);
            this.Name = "Borrower";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Borrowers";
            this.Load += new System.EventHandler(this.Borrower_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RJCodeAdvance.RJControls.RJDropdownMenu rjDropdownMenu1;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJTextBox BName;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJTextBox BAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private RJCodeAdvance.RJControls.RJTextBox BPhone;
        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private Guna.UI2.WinForms.Guna2Button update;
        private Guna.UI2.WinForms.Guna2Button detele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private RJCodeAdvance.RJControls.RJTextBox BQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker returnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.ComboBox books;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox book_language;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox book_editions;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowersID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnsDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookIDs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Langauge;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublicationYear;
    }
}