namespace PBL_3
{
    partial class BorrowAndReturnForm
    {
        private const string V = "BorrowAndReturnForm";

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowAndReturnForm));
            this.mainPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.alldate = new Guna.UI2.WinForms.Guna2Button();
            this.listSearchCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.timePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.book_renewal = new Guna.UI2.WinForms.Guna2Button();
            this.borrowPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.saveAndContinueBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.saveBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bookError = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bookTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.studentError = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.studentTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.borrowBtn = new Guna.UI2.WinForms.Guna2Button();
            this.listPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.borrowDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.returnBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.next = new Guna.UI2.WinForms.Guna2Button();
            this.previous = new Guna.UI2.WinForms.Guna2Button();
            this.mainPanel.SuspendLayout();
            this.borrowPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.listPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrowDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.BorderRadius = 30;
            this.mainPanel.Controls.Add(this.alldate);
            this.mainPanel.Controls.Add(this.listSearchCb);
            this.mainPanel.Controls.Add(this.timePicker);
            this.mainPanel.Controls.Add(this.book_renewal);
            this.mainPanel.Controls.Add(this.borrowPanel);
            this.mainPanel.Controls.Add(this.searchTxt);
            this.mainPanel.Controls.Add(this.borrowBtn);
            this.mainPanel.Controls.Add(this.listPanel);
            this.mainPanel.Controls.Add(this.guna2Button5);
            this.mainPanel.Controls.Add(this.guna2HtmlLabel2);
            this.mainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.mainPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.mainPanel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.mainPanel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1712, 710);
            this.mainPanel.TabIndex = 0;
            // 
            // alldate
            // 
            this.alldate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.alldate.BorderColor = System.Drawing.Color.Transparent;
            this.alldate.BorderRadius = 15;
            this.alldate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.alldate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.alldate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.alldate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.alldate.FillColor = System.Drawing.Color.Gainsboro;
            this.alldate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.alldate.ForeColor = System.Drawing.Color.DimGray;
            this.alldate.Location = new System.Drawing.Point(701, 14);
            this.alldate.Name = "alldate";
            this.alldate.PressedColor = System.Drawing.Color.Gray;
            this.alldate.Size = new System.Drawing.Size(58, 35);
            this.alldate.TabIndex = 24;
            this.alldate.Text = "ALL";
            this.alldate.Visible = false;
            this.alldate.Click += new System.EventHandler(this.alldate_Click);
            // 
            // listSearchCb
            // 
            this.listSearchCb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.listSearchCb.BorderRadius = 10;
            this.listSearchCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listSearchCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listSearchCb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listSearchCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.listSearchCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.listSearchCb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listSearchCb.ForeColor = System.Drawing.Color.Gray;
            this.listSearchCb.ItemHeight = 30;
            this.listSearchCb.Location = new System.Drawing.Point(837, 13);
            this.listSearchCb.Name = "listSearchCb";
            this.listSearchCb.Size = new System.Drawing.Size(178, 36);
            this.listSearchCb.TabIndex = 27;
            this.listSearchCb.SelectedIndexChanged += new System.EventHandler(this.listSearchCb_SelectedIndexChanged);
            this.listSearchCb.Click += new System.EventHandler(this.listSearchCb_Click);
            // 
            // timePicker
            // 
            this.timePicker.Checked = true;
            this.timePicker.FillColor = System.Drawing.Color.White;
            this.timePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.timePicker.Location = new System.Drawing.Point(426, 14);
            this.timePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(250, 36);
            this.timePicker.TabIndex = 23;
            this.timePicker.Value = new System.DateTime(2023, 5, 13, 16, 53, 47, 36);
            this.timePicker.Visible = false;
            this.timePicker.ValueChanged += new System.EventHandler(this.timePicker_ValueChanged);
            // 
            // book_renewal
            // 
            this.book_renewal.BorderRadius = 10;
            this.book_renewal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.book_renewal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.book_renewal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.book_renewal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.book_renewal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.book_renewal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_renewal.ForeColor = System.Drawing.Color.White;
            this.book_renewal.Location = new System.Drawing.Point(172, 50);
            this.book_renewal.Margin = new System.Windows.Forms.Padding(4);
            this.book_renewal.Name = "book_renewal";
            this.book_renewal.Size = new System.Drawing.Size(133, 46);
            this.book_renewal.TabIndex = 25;
            this.book_renewal.Text = "Renewal Book";
            this.book_renewal.Click += new System.EventHandler(this.book_renewal_Click);
            // 
            // borrowPanel
            // 
            this.borrowPanel.BackColor = System.Drawing.Color.Transparent;
            this.borrowPanel.BorderColor = System.Drawing.Color.White;
            this.borrowPanel.BorderRadius = 25;
            this.borrowPanel.Controls.Add(this.guna2Panel1);
            this.borrowPanel.Controls.Add(this.saveAndContinueBtn);
            this.borrowPanel.Controls.Add(this.saveBtn);
            this.borrowPanel.Controls.Add(this.bookError);
            this.borrowPanel.Controls.Add(this.bookTxt);
            this.borrowPanel.Controls.Add(this.studentError);
            this.borrowPanel.Controls.Add(this.studentTxt);
            this.borrowPanel.FillColor = System.Drawing.Color.White;
            this.borrowPanel.Location = new System.Drawing.Point(1235, 6);
            this.borrowPanel.Margin = new System.Windows.Forms.Padding(4);
            this.borrowPanel.Name = "borrowPanel";
            this.borrowPanel.Size = new System.Drawing.Size(314, 698);
            this.borrowPanel.TabIndex = 24;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 25;
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(314, 186);
            this.guna2Panel1.TabIndex = 3;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe Script", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(72)))), ((int)(((byte)(153)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(8, 55);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(296, 73);
            this.guna2HtmlLabel1.TabIndex = 18;
            this.guna2HtmlLabel1.Text = " Borrow Book";
            // 
            // saveAndContinueBtn
            // 
            this.saveAndContinueBtn.BorderRadius = 20;
            this.saveAndContinueBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveAndContinueBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveAndContinueBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveAndContinueBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveAndContinueBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveAndContinueBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.saveAndContinueBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.saveAndContinueBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAndContinueBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(72)))), ((int)(((byte)(153)))));
            this.saveAndContinueBtn.Location = new System.Drawing.Point(160, 645);
            this.saveAndContinueBtn.Name = "saveAndContinueBtn";
            this.saveAndContinueBtn.Size = new System.Drawing.Size(115, 45);
            this.saveAndContinueBtn.TabIndex = 2;
            this.saveAndContinueBtn.Text = "Save And Continue";
            this.saveAndContinueBtn.Click += new System.EventHandler(this.saveAndContinueBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BorderRadius = 20;
            this.saveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.saveBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.saveBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(72)))), ((int)(((byte)(153)))));
            this.saveBtn.Location = new System.Drawing.Point(39, 645);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(115, 45);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // bookError
            // 
            this.bookError.BackColor = System.Drawing.Color.Transparent;
            this.bookError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookError.ForeColor = System.Drawing.Color.Red;
            this.bookError.Location = new System.Drawing.Point(173, 591);
            this.bookError.Name = "bookError";
            this.bookError.Size = new System.Drawing.Size(123, 15);
            this.bookError.TabIndex = 1;
            this.bookError.Text = "Please fill this information!";
            this.bookError.Visible = false;
            // 
            // bookTxt
            // 
            this.bookTxt.BorderColor = System.Drawing.Color.White;
            this.bookTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookTxt.DefaultText = "";
            this.bookTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bookTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bookTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.bookTxt.ForeColor = System.Drawing.Color.Black;
            this.bookTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookTxt.Location = new System.Drawing.Point(3, 536);
            this.bookTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bookTxt.Name = "bookTxt";
            this.bookTxt.PasswordChar = '\0';
            this.bookTxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.bookTxt.PlaceholderText = "Book\'s Id";
            this.bookTxt.SelectedText = "";
            this.bookTxt.Size = new System.Drawing.Size(308, 48);
            this.bookTxt.TabIndex = 0;
            this.bookTxt.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // studentError
            // 
            this.studentError.BackColor = System.Drawing.Color.Transparent;
            this.studentError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentError.ForeColor = System.Drawing.Color.Red;
            this.studentError.Location = new System.Drawing.Point(173, 512);
            this.studentError.Name = "studentError";
            this.studentError.Size = new System.Drawing.Size(123, 15);
            this.studentError.TabIndex = 1;
            this.studentError.Text = "Please fill this information!";
            this.studentError.Visible = false;
            // 
            // studentTxt
            // 
            this.studentTxt.BorderColor = System.Drawing.Color.White;
            this.studentTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studentTxt.DefaultText = "";
            this.studentTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.studentTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.studentTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.studentTxt.ForeColor = System.Drawing.Color.Black;
            this.studentTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentTxt.Location = new System.Drawing.Point(3, 457);
            this.studentTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.studentTxt.Name = "studentTxt";
            this.studentTxt.PasswordChar = '\0';
            this.studentTxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.studentTxt.PlaceholderText = "Student\'s Id";
            this.studentTxt.SelectedText = "";
            this.studentTxt.Size = new System.Drawing.Size(308, 48);
            this.studentTxt.TabIndex = 0;
            this.studentTxt.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // searchTxt
            // 
            this.searchTxt.BackColor = System.Drawing.Color.Transparent;
            this.searchTxt.BorderRadius = 15;
            this.searchTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTxt.DefaultText = "";
            this.searchTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTxt.Enabled = false;
            this.searchTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.searchTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTxt.Location = new System.Drawing.Point(414, 10);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.PasswordChar = '\0';
            this.searchTxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchTxt.PlaceholderText = "Search...";
            this.searchTxt.SelectedText = "";
            this.searchTxt.Size = new System.Drawing.Size(616, 45);
            this.searchTxt.TabIndex = 26;
            this.searchTxt.TabStop = false;
            this.searchTxt.TextOffset = new System.Drawing.Point(5, 0);
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            this.searchTxt.Click += new System.EventHandler(this.searchTxt_Click);
            // 
            // borrowBtn
            // 
            this.borrowBtn.BorderRadius = 10;
            this.borrowBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.borrowBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.borrowBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.borrowBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.borrowBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.borrowBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowBtn.ForeColor = System.Drawing.Color.White;
            this.borrowBtn.Location = new System.Drawing.Point(23, 50);
            this.borrowBtn.Margin = new System.Windows.Forms.Padding(4);
            this.borrowBtn.Name = "borrowBtn";
            this.borrowBtn.Size = new System.Drawing.Size(133, 46);
            this.borrowBtn.TabIndex = 17;
            this.borrowBtn.Text = "Borrow Book";
            this.borrowBtn.Click += new System.EventHandler(this.borrrowBtn_Click);
            // 
            // listPanel
            // 
            this.listPanel.BorderRadius = 25;
            this.listPanel.Controls.Add(this.next);
            this.listPanel.Controls.Add(this.previous);
            this.listPanel.Controls.Add(this.borrowDGV);
            this.listPanel.Controls.Add(this.deleteBtn);
            this.listPanel.Controls.Add(this.returnBtn);
            this.listPanel.Controls.Add(this.guna2HtmlLabel13);
            this.listPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.listPanel.Location = new System.Drawing.Point(23, 110);
            this.listPanel.Margin = new System.Windows.Forms.Padding(4);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(1510, 595);
            this.listPanel.TabIndex = 15;
            // 
            // borrowDGV
            // 
            this.borrowDGV.AllowUserToResizeColumns = false;
            this.borrowDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.borrowDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.borrowDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.borrowDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.borrowDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.borrowDGV.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.borrowDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.borrowDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.borrowDGV.Location = new System.Drawing.Point(36, 92);
            this.borrowDGV.Name = "borrowDGV";
            this.borrowDGV.ReadOnly = true;
            this.borrowDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.borrowDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.borrowDGV.RowHeadersVisible = false;
            this.borrowDGV.RowHeadersWidth = 51;
            this.borrowDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.borrowDGV.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.borrowDGV.RowTemplate.Height = 30;
            this.borrowDGV.Size = new System.Drawing.Size(1445, 453);
            this.borrowDGV.TabIndex = 22;
            this.borrowDGV.TabStop = false;
            this.borrowDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Transparent;
            this.borrowDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.borrowDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.borrowDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.borrowDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.borrowDGV.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.borrowDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.borrowDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.borrowDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.borrowDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.borrowDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.borrowDGV.ThemeStyle.HeaderStyle.Height = 40;
            this.borrowDGV.ThemeStyle.ReadOnly = true;
            this.borrowDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.borrowDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.borrowDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.borrowDGV.ThemeStyle.RowsStyle.Height = 30;
            this.borrowDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.borrowDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BorderRadius = 10;
            this.deleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.deleteBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.Location = new System.Drawing.Point(1200, 10);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(133, 46);
            this.deleteBtn.TabIndex = 20;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.BorderRadius = 10;
            this.returnBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.returnBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.returnBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.returnBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.returnBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.returnBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.ForeColor = System.Drawing.Color.Black;
            this.returnBtn.Location = new System.Drawing.Point(1359, 10);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(4);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(133, 46);
            this.returnBtn.TabIndex = 20;
            this.returnBtn.Text = "Return";
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(29, 10);
            this.guna2HtmlLabel13.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(145, 39);
            this.guna2HtmlLabel13.TabIndex = 16;
            this.guna2HtmlLabel13.Text = "Borrow List";
            // 
            // guna2Button5
            // 
            this.guna2Button5.BorderRadius = 10;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.ImageOffset = new System.Drawing.Point(0, -2);
            this.guna2Button5.ImageSize = new System.Drawing.Size(23, 20);
            this.guna2Button5.Location = new System.Drawing.Point(70, 555);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(57, 53);
            this.guna2Button5.TabIndex = 7;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(23, 10);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(286, 39);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Borrow & Return Book";
            // 
            // next
            // 
            this.next.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.next.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.next.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.next.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.next.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.next.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.next.ForeColor = System.Drawing.Color.White;
            this.next.Image = ((System.Drawing.Image)(resources.GetObject("next.Image")));
            this.next.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.next.Location = new System.Drawing.Point(755, 551);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(89, 26);
            this.next.TabIndex = 28;
            this.next.Text = "next";
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // previous
            // 
            this.previous.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.previous.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.previous.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.previous.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.previous.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.previous.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.previous.ForeColor = System.Drawing.Color.White;
            this.previous.Image = ((System.Drawing.Image)(resources.GetObject("previous.Image")));
            this.previous.Location = new System.Drawing.Point(650, 551);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(86, 26);
            this.previous.TabIndex = 27;
            this.previous.Text = "previous";
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // BorrowAndReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1560, 737);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(215, 187);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BorrowAndReturnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MainForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.borrowPanel.ResumeLayout(false);
            this.borrowPanel.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.listPanel.ResumeLayout(false);
            this.listPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrowDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel mainPanel;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Panel listPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2Button borrowBtn;
        private Guna.UI2.WinForms.Guna2Button returnBtn;
        private Guna.UI2.WinForms.Guna2DataGridView borrowDGV;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
        private Guna.UI2.WinForms.Guna2Panel borrowPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton saveAndContinueBtn;
        private Guna.UI2.WinForms.Guna2GradientButton saveBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel bookError;
        private Guna.UI2.WinForms.Guna2TextBox bookTxt;
        private Guna.UI2.WinForms.Guna2HtmlLabel studentError;
        private Guna.UI2.WinForms.Guna2TextBox studentTxt;
        private Guna.UI2.WinForms.Guna2Button book_renewal;
        private Guna.UI2.WinForms.Guna2ComboBox listSearchCb;
        private Guna.UI2.WinForms.Guna2TextBox searchTxt;
        public Guna.UI2.WinForms.Guna2Button alldate;
        public Guna.UI2.WinForms.Guna2DateTimePicker timePicker;
        private Guna.UI2.WinForms.Guna2Button next;
        private Guna.UI2.WinForms.Guna2Button previous;
    }
}