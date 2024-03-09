namespace PBL_3
{
    partial class MainForm
    {
        private const string V = "MainForm";

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.overdueListPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.overdueDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.checkOverdueBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel14 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.studentListPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.studentDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.addStudentBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.borrowedBookPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.totalBorrowedBookLb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.overdueBookPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button10 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.totalOverdueBookLb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.totalStudentPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button11 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox4 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.totalStudentLb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.totalBookPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.totalBookLb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.datetimeLb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.welcomeLb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.next = new Guna.UI2.WinForms.Guna2Button();
            this.previous = new Guna.UI2.WinForms.Guna2Button();
            this.menuPanel.SuspendLayout();
            this.overdueListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overdueDGV)).BeginInit();
            this.studentListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDGV)).BeginInit();
            this.borrowedBookPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.overdueBookPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
            this.totalStudentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).BeginInit();
            this.totalBookPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BorderRadius = 25;
            this.menuPanel.Controls.Add(this.overdueListPanel);
            this.menuPanel.Controls.Add(this.studentListPanel);
            this.menuPanel.Controls.Add(this.borrowedBookPanel);
            this.menuPanel.Controls.Add(this.overdueBookPanel);
            this.menuPanel.Controls.Add(this.totalStudentPanel);
            this.menuPanel.Controls.Add(this.guna2Button5);
            this.menuPanel.Controls.Add(this.totalBookPanel);
            this.menuPanel.Controls.Add(this.datetimeLb);
            this.menuPanel.Controls.Add(this.guna2HtmlLabel3);
            this.menuPanel.Controls.Add(this.welcomeLb);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1635, 780);
            this.menuPanel.TabIndex = 3;
            // 
            // overdueListPanel
            // 
            this.overdueListPanel.BackColor = System.Drawing.Color.Transparent;
            this.overdueListPanel.BorderRadius = 25;
            this.overdueListPanel.Controls.Add(this.overdueDGV);
            this.overdueListPanel.Controls.Add(this.checkOverdueBtn);
            this.overdueListPanel.Controls.Add(this.guna2HtmlLabel14);
            this.overdueListPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.overdueListPanel.Location = new System.Drawing.Point(808, 250);
            this.overdueListPanel.Margin = new System.Windows.Forms.Padding(4);
            this.overdueListPanel.Name = "overdueListPanel";
            this.overdueListPanel.Size = new System.Drawing.Size(736, 450);
            this.overdueListPanel.TabIndex = 27;
            // 
            // overdueDGV
            // 
            this.overdueDGV.AllowUserToResizeColumns = false;
            this.overdueDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle26.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.overdueDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.overdueDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.overdueDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle27.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.overdueDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.overdueDGV.ColumnHeadersHeight = 40;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.overdueDGV.DefaultCellStyle = dataGridViewCellStyle28;
            this.overdueDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.overdueDGV.Location = new System.Drawing.Point(29, 81);
            this.overdueDGV.Name = "overdueDGV";
            this.overdueDGV.ReadOnly = true;
            this.overdueDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.overdueDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.overdueDGV.RowHeadersVisible = false;
            this.overdueDGV.RowHeadersWidth = 51;
            this.overdueDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.overdueDGV.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.overdueDGV.RowTemplate.Height = 30;
            this.overdueDGV.Size = new System.Drawing.Size(676, 349);
            this.overdueDGV.TabIndex = 24;
            this.overdueDGV.TabStop = false;
            this.overdueDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Transparent;
            this.overdueDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.overdueDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.overdueDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.overdueDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.overdueDGV.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.overdueDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.overdueDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.overdueDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.overdueDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overdueDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.overdueDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.overdueDGV.ThemeStyle.HeaderStyle.Height = 40;
            this.overdueDGV.ThemeStyle.ReadOnly = true;
            this.overdueDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.overdueDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.overdueDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overdueDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.overdueDGV.ThemeStyle.RowsStyle.Height = 30;
            this.overdueDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.overdueDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // checkOverdueBtn
            // 
            this.checkOverdueBtn.BorderRadius = 10;
            this.checkOverdueBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.checkOverdueBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.checkOverdueBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.checkOverdueBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.checkOverdueBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.checkOverdueBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOverdueBtn.ForeColor = System.Drawing.Color.Black;
            this.checkOverdueBtn.Location = new System.Drawing.Point(575, 10);
            this.checkOverdueBtn.Margin = new System.Windows.Forms.Padding(4);
            this.checkOverdueBtn.Name = "checkOverdueBtn";
            this.checkOverdueBtn.Size = new System.Drawing.Size(133, 46);
            this.checkOverdueBtn.TabIndex = 18;
            this.checkOverdueBtn.Text = "Check it";
            this.checkOverdueBtn.Click += new System.EventHandler(this.checkOverdueBtn_Click);
            // 
            // guna2HtmlLabel14
            // 
            this.guna2HtmlLabel14.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel14.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2HtmlLabel14.Location = new System.Drawing.Point(29, 4);
            this.guna2HtmlLabel14.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel14.Name = "guna2HtmlLabel14";
            this.guna2HtmlLabel14.Size = new System.Drawing.Size(159, 39);
            this.guna2HtmlLabel14.TabIndex = 16;
            this.guna2HtmlLabel14.Text = "Overdue List";
            // 
            // studentListPanel
            // 
            this.studentListPanel.AutoScroll = true;
            this.studentListPanel.BackColor = System.Drawing.Color.Transparent;
            this.studentListPanel.BorderRadius = 25;
            this.studentListPanel.Controls.Add(this.next);
            this.studentListPanel.Controls.Add(this.previous);
            this.studentListPanel.Controls.Add(this.studentDGV);
            this.studentListPanel.Controls.Add(this.addStudentBtn);
            this.studentListPanel.Controls.Add(this.guna2HtmlLabel13);
            this.studentListPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.studentListPanel.Location = new System.Drawing.Point(18, 250);
            this.studentListPanel.Margin = new System.Windows.Forms.Padding(4);
            this.studentListPanel.Name = "studentListPanel";
            this.studentListPanel.Size = new System.Drawing.Size(736, 450);
            this.studentListPanel.TabIndex = 26;
            // 
            // studentDGV
            // 
            this.studentDGV.AllowUserToResizeColumns = false;
            this.studentDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle21.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.studentDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.studentDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.studentDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle22.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.studentDGV.ColumnHeadersHeight = 40;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentDGV.DefaultCellStyle = dataGridViewCellStyle23;
            this.studentDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.studentDGV.Location = new System.Drawing.Point(33, 81);
            this.studentDGV.Name = "studentDGV";
            this.studentDGV.ReadOnly = true;
            this.studentDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.studentDGV.RowHeadersVisible = false;
            this.studentDGV.RowHeadersWidth = 51;
            this.studentDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentDGV.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.studentDGV.RowTemplate.Height = 30;
            this.studentDGV.Size = new System.Drawing.Size(676, 312);
            this.studentDGV.TabIndex = 23;
            this.studentDGV.TabStop = false;
            this.studentDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Transparent;
            this.studentDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.studentDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.studentDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.studentDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.studentDGV.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.studentDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.studentDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.studentDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.studentDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.studentDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.studentDGV.ThemeStyle.HeaderStyle.Height = 40;
            this.studentDGV.ThemeStyle.ReadOnly = true;
            this.studentDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.studentDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.studentDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.studentDGV.ThemeStyle.RowsStyle.Height = 30;
            this.studentDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.studentDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.BorderRadius = 10;
            this.addStudentBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addStudentBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addStudentBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addStudentBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addStudentBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.addStudentBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentBtn.ForeColor = System.Drawing.Color.Black;
            this.addStudentBtn.Location = new System.Drawing.Point(575, 10);
            this.addStudentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(133, 46);
            this.addStudentBtn.TabIndex = 17;
            this.addStudentBtn.Text = "Add student";
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(29, 10);
            this.guna2HtmlLabel13.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(149, 39);
            this.guna2HtmlLabel13.TabIndex = 16;
            this.guna2HtmlLabel13.Text = "Student List";
            // 
            // borrowedBookPanel
            // 
            this.borrowedBookPanel.BackColor = System.Drawing.Color.Transparent;
            this.borrowedBookPanel.BorderRadius = 20;
            this.borrowedBookPanel.Controls.Add(this.guna2Button9);
            this.borrowedBookPanel.Controls.Add(this.guna2CirclePictureBox2);
            this.borrowedBookPanel.Controls.Add(this.guna2HtmlLabel7);
            this.borrowedBookPanel.Controls.Add(this.totalBorrowedBookLb);
            this.borrowedBookPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.borrowedBookPanel.Location = new System.Drawing.Point(808, 90);
            this.borrowedBookPanel.Margin = new System.Windows.Forms.Padding(4);
            this.borrowedBookPanel.Name = "borrowedBookPanel";
            this.borrowedBookPanel.Size = new System.Drawing.Size(341, 123);
            this.borrowedBookPanel.TabIndex = 23;
            // 
            // guna2Button9
            // 
            this.guna2Button9.BorderRadius = 20;
            this.guna2Button9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            this.guna2Button9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button9.ForeColor = System.Drawing.Color.White;
            this.guna2Button9.Image = global::PBL_3.Properties.Resources.borrowed__1_;
            this.guna2Button9.ImageOffset = new System.Drawing.Point(0, -2);
            this.guna2Button9.Location = new System.Drawing.Point(257, 20);
            this.guna2Button9.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button9.Name = "guna2Button9";
            this.guna2Button9.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            this.guna2Button9.Size = new System.Drawing.Size(57, 53);
            this.guna2Button9.TabIndex = 11;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(192, 21);
            this.guna2CirclePictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(0, 0);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 2;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(33, 85);
            this.guna2HtmlLabel7.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(124, 21);
            this.guna2HtmlLabel7.TabIndex = 1;
            this.guna2HtmlLabel7.Text = "Borrowed Book";
            // 
            // totalBorrowedBookLb
            // 
            this.totalBorrowedBookLb.BackColor = System.Drawing.Color.Transparent;
            this.totalBorrowedBookLb.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBorrowedBookLb.ForeColor = System.Drawing.Color.White;
            this.totalBorrowedBookLb.Location = new System.Drawing.Point(29, 15);
            this.totalBorrowedBookLb.Margin = new System.Windows.Forms.Padding(4);
            this.totalBorrowedBookLb.Name = "totalBorrowedBookLb";
            this.totalBorrowedBookLb.Size = new System.Drawing.Size(75, 53);
            this.totalBorrowedBookLb.TabIndex = 0;
            this.totalBorrowedBookLb.Text = "101";
            // 
            // overdueBookPanel
            // 
            this.overdueBookPanel.BackColor = System.Drawing.Color.Transparent;
            this.overdueBookPanel.BorderRadius = 20;
            this.overdueBookPanel.Controls.Add(this.guna2Button10);
            this.overdueBookPanel.Controls.Add(this.guna2CirclePictureBox3);
            this.overdueBookPanel.Controls.Add(this.guna2HtmlLabel9);
            this.overdueBookPanel.Controls.Add(this.totalOverdueBookLb);
            this.overdueBookPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.overdueBookPanel.Location = new System.Drawing.Point(413, 90);
            this.overdueBookPanel.Margin = new System.Windows.Forms.Padding(4);
            this.overdueBookPanel.Name = "overdueBookPanel";
            this.overdueBookPanel.Size = new System.Drawing.Size(341, 123);
            this.overdueBookPanel.TabIndex = 24;
            // 
            // guna2Button10
            // 
            this.guna2Button10.BorderRadius = 20;
            this.guna2Button10.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button10.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button10.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            this.guna2Button10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button10.ForeColor = System.Drawing.Color.White;
            this.guna2Button10.Image = global::PBL_3.Properties.Resources.hourglass;
            this.guna2Button10.Location = new System.Drawing.Point(257, 20);
            this.guna2Button10.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button10.Name = "guna2Button10";
            this.guna2Button10.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            this.guna2Button10.Size = new System.Drawing.Size(57, 53);
            this.guna2Button10.TabIndex = 11;
            // 
            // guna2CirclePictureBox3
            // 
            this.guna2CirclePictureBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            this.guna2CirclePictureBox3.ImageRotate = 0F;
            this.guna2CirclePictureBox3.Location = new System.Drawing.Point(192, 21);
            this.guna2CirclePictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            this.guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox3.Size = new System.Drawing.Size(0, 0);
            this.guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox3.TabIndex = 2;
            this.guna2CirclePictureBox3.TabStop = false;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(33, 85);
            this.guna2HtmlLabel9.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(113, 21);
            this.guna2HtmlLabel9.TabIndex = 1;
            this.guna2HtmlLabel9.Text = "Overdue Book";
            // 
            // totalOverdueBookLb
            // 
            this.totalOverdueBookLb.BackColor = System.Drawing.Color.Transparent;
            this.totalOverdueBookLb.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOverdueBookLb.ForeColor = System.Drawing.Color.White;
            this.totalOverdueBookLb.Location = new System.Drawing.Point(29, 15);
            this.totalOverdueBookLb.Margin = new System.Windows.Forms.Padding(4);
            this.totalOverdueBookLb.Name = "totalOverdueBookLb";
            this.totalOverdueBookLb.Size = new System.Drawing.Size(75, 53);
            this.totalOverdueBookLb.TabIndex = 0;
            this.totalOverdueBookLb.Text = "101";
            // 
            // totalStudentPanel
            // 
            this.totalStudentPanel.BackColor = System.Drawing.Color.Transparent;
            this.totalStudentPanel.BorderRadius = 20;
            this.totalStudentPanel.Controls.Add(this.guna2Button11);
            this.totalStudentPanel.Controls.Add(this.guna2CirclePictureBox4);
            this.totalStudentPanel.Controls.Add(this.guna2HtmlLabel11);
            this.totalStudentPanel.Controls.Add(this.totalStudentLb);
            this.totalStudentPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.totalStudentPanel.Location = new System.Drawing.Point(1202, 90);
            this.totalStudentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.totalStudentPanel.Name = "totalStudentPanel";
            this.totalStudentPanel.Size = new System.Drawing.Size(341, 123);
            this.totalStudentPanel.TabIndex = 25;
            // 
            // guna2Button11
            // 
            this.guna2Button11.BorderRadius = 20;
            this.guna2Button11.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button11.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button11.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button11.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            this.guna2Button11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button11.ForeColor = System.Drawing.Color.White;
            this.guna2Button11.Image = global::PBL_3.Properties.Resources.person;
            this.guna2Button11.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button11.Location = new System.Drawing.Point(257, 20);
            this.guna2Button11.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button11.Name = "guna2Button11";
            this.guna2Button11.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            this.guna2Button11.Size = new System.Drawing.Size(57, 53);
            this.guna2Button11.TabIndex = 11;
            // 
            // guna2CirclePictureBox4
            // 
            this.guna2CirclePictureBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            this.guna2CirclePictureBox4.ImageRotate = 0F;
            this.guna2CirclePictureBox4.Location = new System.Drawing.Point(192, 21);
            this.guna2CirclePictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CirclePictureBox4.Name = "guna2CirclePictureBox4";
            this.guna2CirclePictureBox4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox4.Size = new System.Drawing.Size(0, 0);
            this.guna2CirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox4.TabIndex = 2;
            this.guna2CirclePictureBox4.TabStop = false;
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(33, 85);
            this.guna2HtmlLabel11.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(105, 21);
            this.guna2HtmlLabel11.TabIndex = 1;
            this.guna2HtmlLabel11.Text = "Total Student";
            // 
            // totalStudentLb
            // 
            this.totalStudentLb.BackColor = System.Drawing.Color.Transparent;
            this.totalStudentLb.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStudentLb.ForeColor = System.Drawing.Color.White;
            this.totalStudentLb.Location = new System.Drawing.Point(29, 15);
            this.totalStudentLb.Margin = new System.Windows.Forms.Padding(4);
            this.totalStudentLb.Name = "totalStudentLb";
            this.totalStudentLb.Size = new System.Drawing.Size(75, 53);
            this.totalStudentLb.TabIndex = 0;
            this.totalStudentLb.Text = "101";
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
            this.guna2Button5.Location = new System.Drawing.Point(65, 545);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(57, 53);
            this.guna2Button5.TabIndex = 22;
            // 
            // totalBookPanel
            // 
            this.totalBookPanel.BackColor = System.Drawing.Color.Transparent;
            this.totalBookPanel.BorderRadius = 20;
            this.totalBookPanel.Controls.Add(this.guna2Button8);
            this.totalBookPanel.Controls.Add(this.guna2CirclePictureBox1);
            this.totalBookPanel.Controls.Add(this.guna2HtmlLabel6);
            this.totalBookPanel.Controls.Add(this.totalBookLb);
            this.totalBookPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.totalBookPanel.ForeColor = System.Drawing.Color.White;
            this.totalBookPanel.Location = new System.Drawing.Point(18, 90);
            this.totalBookPanel.Margin = new System.Windows.Forms.Padding(4);
            this.totalBookPanel.Name = "totalBookPanel";
            this.totalBookPanel.Size = new System.Drawing.Size(339, 123);
            this.totalBookPanel.TabIndex = 21;
            // 
            // guna2Button8
            // 
            this.guna2Button8.BorderRadius = 20;
            this.guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            this.guna2Button8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button8.ForeColor = System.Drawing.Color.White;
            this.guna2Button8.Image = global::PBL_3.Properties.Resources.Screenshot_2023_04_10_at_14_12_58;
            this.guna2Button8.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2Button8.Location = new System.Drawing.Point(257, 20);
            this.guna2Button8.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            this.guna2Button8.Size = new System.Drawing.Size(57, 53);
            this.guna2Button8.TabIndex = 11;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(192, 21);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(0, 0);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 2;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(33, 85);
            this.guna2HtmlLabel6.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(86, 21);
            this.guna2HtmlLabel6.TabIndex = 1;
            this.guna2HtmlLabel6.Text = "Total Book";
            // 
            // totalBookLb
            // 
            this.totalBookLb.BackColor = System.Drawing.Color.Transparent;
            this.totalBookLb.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBookLb.ForeColor = System.Drawing.Color.White;
            this.totalBookLb.Location = new System.Drawing.Point(29, 15);
            this.totalBookLb.Margin = new System.Windows.Forms.Padding(4);
            this.totalBookLb.Name = "totalBookLb";
            this.totalBookLb.Size = new System.Drawing.Size(75, 53);
            this.totalBookLb.TabIndex = 0;
            this.totalBookLb.Text = "101";
            // 
            // datetimeLb
            // 
            this.datetimeLb.BackColor = System.Drawing.Color.Transparent;
            this.datetimeLb.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeLb.ForeColor = System.Drawing.Color.Transparent;
            this.datetimeLb.Location = new System.Drawing.Point(18, 44);
            this.datetimeLb.Margin = new System.Windows.Forms.Padding(4);
            this.datetimeLb.Name = "datetimeLb";
            this.datetimeLb.Size = new System.Drawing.Size(273, 25);
            this.datetimeLb.TabIndex = 20;
            this.datetimeLb.Text = "Jan 12, 2023 | Thursday, 11:00AM";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(18, 13);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(61, 31);
            this.guna2HtmlLabel3.TabIndex = 19;
            this.guna2HtmlLabel3.Text = "Hello,";
            // 
            // welcomeLb
            // 
            this.welcomeLb.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLb.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            this.welcomeLb.Location = new System.Drawing.Point(88, 13);
            this.welcomeLb.Margin = new System.Windows.Forms.Padding(4);
            this.welcomeLb.Name = "welcomeLb";
            this.welcomeLb.Size = new System.Drawing.Size(88, 31);
            this.welcomeLb.TabIndex = 18;
            this.welcomeLb.Text = "Gia Huy!";
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
            this.next.Location = new System.Drawing.Point(357, 404);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(90, 26);
            this.next.TabIndex = 30;
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
            this.previous.Location = new System.Drawing.Point(252, 404);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(87, 26);
            this.previous.TabIndex = 29;
            this.previous.Text = "previous";
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1635, 780);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.overdueListPanel.ResumeLayout(false);
            this.overdueListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overdueDGV)).EndInit();
            this.studentListPanel.ResumeLayout(false);
            this.studentListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDGV)).EndInit();
            this.borrowedBookPanel.ResumeLayout(false);
            this.borrowedBookPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.overdueBookPanel.ResumeLayout(false);
            this.overdueBookPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
            this.totalStudentPanel.ResumeLayout(false);
            this.totalStudentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).EndInit();
            this.totalBookPanel.ResumeLayout(false);
            this.totalBookPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel menuPanel;
        private Guna.UI2.WinForms.Guna2Panel overdueListPanel;
        private Guna.UI2.WinForms.Guna2Button checkOverdueBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel14;
        private Guna.UI2.WinForms.Guna2Panel studentListPanel;
        private Guna.UI2.WinForms.Guna2Button addStudentBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2Panel borrowedBookPanel;
        private Guna.UI2.WinForms.Guna2Button guna2Button9;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel totalBorrowedBookLb;
        private Guna.UI2.WinForms.Guna2Panel overdueBookPanel;
        private Guna.UI2.WinForms.Guna2Button guna2Button10;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel totalOverdueBookLb;
        private Guna.UI2.WinForms.Guna2Panel totalStudentPanel;
        private Guna.UI2.WinForms.Guna2Button guna2Button11;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2HtmlLabel totalStudentLb;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Panel totalBookPanel;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel totalBookLb;
        private Guna.UI2.WinForms.Guna2HtmlLabel datetimeLb;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel welcomeLb;
        private Guna.UI2.WinForms.Guna2DataGridView studentDGV;
        private Guna.UI2.WinForms.Guna2DataGridView overdueDGV;
        private Guna.UI2.WinForms.Guna2Button next;
        private Guna.UI2.WinForms.Guna2Button previous;
    }
}