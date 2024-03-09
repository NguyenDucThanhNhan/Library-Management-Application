namespace PBL_3
{
    partial class StudentManagementForm
    {
        private const string V = "StudentForm";

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentManagementForm));
            this.mainPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.listSearchCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.searchTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.addPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.duplicatemssv = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.studentCodeError = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.studentCodeTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelLb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.saveBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.emailTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailError = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.classError = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.classTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.phoneTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.phoneError = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nameError = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.catalogPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.listDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.next = new Guna.UI2.WinForms.Guna2Button();
            this.previous = new Guna.UI2.WinForms.Guna2Button();
            this.mainPanel.SuspendLayout();
            this.addPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.catalogPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.BorderRadius = 30;
            this.mainPanel.Controls.Add(this.listSearchCb);
            this.mainPanel.Controls.Add(this.searchTxt);
            this.mainPanel.Controls.Add(this.addPanel);
            this.mainPanel.Controls.Add(this.addBtn);
            this.mainPanel.Controls.Add(this.catalogPanel);
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
            this.listSearchCb.Location = new System.Drawing.Point(842, 13);
            this.listSearchCb.Name = "listSearchCb";
            this.listSearchCb.Size = new System.Drawing.Size(178, 36);
            this.listSearchCb.TabIndex = 22;
            this.listSearchCb.SelectedIndexChanged += new System.EventHandler(this.listSearchCb_SelectedIndexChanged);
            this.listSearchCb.Click += new System.EventHandler(this.listSearchCb_Click_1);
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
            this.searchTxt.TabIndex = 21;
            this.searchTxt.TabStop = false;
            this.searchTxt.TextOffset = new System.Drawing.Point(5, 0);
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            this.searchTxt.Click += new System.EventHandler(this.searchTxt_Click);
            // 
            // addPanel
            // 
            this.addPanel.BackColor = System.Drawing.Color.Transparent;
            this.addPanel.BorderColor = System.Drawing.Color.White;
            this.addPanel.BorderRadius = 25;
            this.addPanel.Controls.Add(this.duplicatemssv);
            this.addPanel.Controls.Add(this.studentCodeError);
            this.addPanel.Controls.Add(this.studentCodeTxt);
            this.addPanel.Controls.Add(this.guna2Panel1);
            this.addPanel.Controls.Add(this.saveBtn);
            this.addPanel.Controls.Add(this.emailTxt);
            this.addPanel.Controls.Add(this.emailError);
            this.addPanel.Controls.Add(this.classError);
            this.addPanel.Controls.Add(this.classTxt);
            this.addPanel.Controls.Add(this.phoneTxt);
            this.addPanel.Controls.Add(this.phoneError);
            this.addPanel.Controls.Add(this.nameError);
            this.addPanel.Controls.Add(this.nameTxt);
            this.addPanel.FillColor = System.Drawing.Color.White;
            this.addPanel.Location = new System.Drawing.Point(1245, 6);
            this.addPanel.Margin = new System.Windows.Forms.Padding(4);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(314, 698);
            this.addPanel.TabIndex = 18;
            // 
            // duplicatemssv
            // 
            this.duplicatemssv.BackColor = System.Drawing.Color.Transparent;
            this.duplicatemssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duplicatemssv.ForeColor = System.Drawing.Color.Red;
            this.duplicatemssv.Location = new System.Drawing.Point(173, 288);
            this.duplicatemssv.Name = "duplicatemssv";
            this.duplicatemssv.Size = new System.Drawing.Size(3, 2);
            this.duplicatemssv.TabIndex = 8;
            this.duplicatemssv.Text = null;
            // 
            // studentCodeError
            // 
            this.studentCodeError.BackColor = System.Drawing.Color.Transparent;
            this.studentCodeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentCodeError.ForeColor = System.Drawing.Color.Red;
            this.studentCodeError.Location = new System.Drawing.Point(173, 288);
            this.studentCodeError.Name = "studentCodeError";
            this.studentCodeError.Size = new System.Drawing.Size(72, 15);
            this.studentCodeError.TabIndex = 7;
            this.studentCodeError.Text = "Fill information!";
            this.studentCodeError.Visible = false;
            // 
            // studentCodeTxt
            // 
            this.studentCodeTxt.BorderColor = System.Drawing.Color.White;
            this.studentCodeTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studentCodeTxt.DefaultText = "";
            this.studentCodeTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.studentCodeTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.studentCodeTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentCodeTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentCodeTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentCodeTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.studentCodeTxt.ForeColor = System.Drawing.Color.Black;
            this.studentCodeTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentCodeTxt.Location = new System.Drawing.Point(3, 233);
            this.studentCodeTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.studentCodeTxt.Name = "studentCodeTxt";
            this.studentCodeTxt.PasswordChar = '\0';
            this.studentCodeTxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.studentCodeTxt.PlaceholderText = "Student Code";
            this.studentCodeTxt.SelectedText = "";
            this.studentCodeTxt.Size = new System.Drawing.Size(308, 48);
            this.studentCodeTxt.TabIndex = 6;
            this.studentCodeTxt.TextOffset = new System.Drawing.Point(10, 0);
            this.studentCodeTxt.Click += new System.EventHandler(this.studentCodeTxt_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 25;
            this.guna2Panel1.Controls.Add(this.panelLb);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(314, 186);
            this.guna2Panel1.TabIndex = 3;
            // 
            // panelLb
            // 
            this.panelLb.BackColor = System.Drawing.Color.Transparent;
            this.panelLb.Font = new System.Drawing.Font("Segoe Script", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(72)))), ((int)(((byte)(153)))));
            this.panelLb.Location = new System.Drawing.Point(33, 55);
            this.panelLb.Margin = new System.Windows.Forms.Padding(4);
            this.panelLb.Name = "panelLb";
            this.panelLb.Size = new System.Drawing.Size(240, 59);
            this.panelLb.TabIndex = 18;
            this.panelLb.Text = "Add Student";
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
            this.saveBtn.Size = new System.Drawing.Size(240, 45);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // emailTxt
            // 
            this.emailTxt.BorderColor = System.Drawing.Color.White;
            this.emailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTxt.DefaultText = "";
            this.emailTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.emailTxt.ForeColor = System.Drawing.Color.Black;
            this.emailTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTxt.Location = new System.Drawing.Point(3, 555);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PasswordChar = '\0';
            this.emailTxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.emailTxt.PlaceholderText = "Email";
            this.emailTxt.SelectedText = "";
            this.emailTxt.Size = new System.Drawing.Size(308, 48);
            this.emailTxt.TabIndex = 0;
            this.emailTxt.TextOffset = new System.Drawing.Point(10, 0);
            this.emailTxt.Click += new System.EventHandler(this.emailTxt_Click);
            // 
            // emailError
            // 
            this.emailError.BackColor = System.Drawing.Color.Transparent;
            this.emailError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailError.ForeColor = System.Drawing.Color.Red;
            this.emailError.Location = new System.Drawing.Point(173, 610);
            this.emailError.Name = "emailError";
            this.emailError.Size = new System.Drawing.Size(72, 15);
            this.emailError.TabIndex = 1;
            this.emailError.Text = "Fill information!";
            this.emailError.Visible = false;
            // 
            // classError
            // 
            this.classError.BackColor = System.Drawing.Color.Transparent;
            this.classError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classError.ForeColor = System.Drawing.Color.Red;
            this.classError.Location = new System.Drawing.Point(173, 456);
            this.classError.Name = "classError";
            this.classError.Size = new System.Drawing.Size(72, 15);
            this.classError.TabIndex = 1;
            this.classError.Text = "Fill information!";
            this.classError.Visible = false;
            // 
            // classTxt
            // 
            this.classTxt.BorderColor = System.Drawing.Color.White;
            this.classTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.classTxt.DefaultText = "";
            this.classTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.classTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.classTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.classTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.classTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.classTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.classTxt.ForeColor = System.Drawing.Color.Black;
            this.classTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.classTxt.Location = new System.Drawing.Point(3, 401);
            this.classTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.classTxt.Name = "classTxt";
            this.classTxt.PasswordChar = '\0';
            this.classTxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.classTxt.PlaceholderText = "Class";
            this.classTxt.SelectedText = "";
            this.classTxt.Size = new System.Drawing.Size(308, 48);
            this.classTxt.TabIndex = 0;
            this.classTxt.TextOffset = new System.Drawing.Point(10, 0);
            this.classTxt.Click += new System.EventHandler(this.classTxt_Click);
            // 
            // phoneTxt
            // 
            this.phoneTxt.BorderColor = System.Drawing.Color.White;
            this.phoneTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTxt.DefaultText = "";
            this.phoneTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.phoneTxt.ForeColor = System.Drawing.Color.Black;
            this.phoneTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTxt.Location = new System.Drawing.Point(3, 478);
            this.phoneTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.PasswordChar = '\0';
            this.phoneTxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.phoneTxt.PlaceholderText = "Phone Number";
            this.phoneTxt.SelectedText = "";
            this.phoneTxt.Size = new System.Drawing.Size(308, 48);
            this.phoneTxt.TabIndex = 0;
            this.phoneTxt.TextOffset = new System.Drawing.Point(10, 0);
            this.phoneTxt.Click += new System.EventHandler(this.phoneTxt_Click);
            // 
            // phoneError
            // 
            this.phoneError.BackColor = System.Drawing.Color.Transparent;
            this.phoneError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneError.ForeColor = System.Drawing.Color.Red;
            this.phoneError.Location = new System.Drawing.Point(173, 533);
            this.phoneError.Name = "phoneError";
            this.phoneError.Size = new System.Drawing.Size(72, 15);
            this.phoneError.TabIndex = 1;
            this.phoneError.Text = "Fill information!";
            this.phoneError.Visible = false;
            // 
            // nameError
            // 
            this.nameError.BackColor = System.Drawing.Color.Transparent;
            this.nameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameError.ForeColor = System.Drawing.Color.Red;
            this.nameError.Location = new System.Drawing.Point(173, 379);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(72, 15);
            this.nameError.TabIndex = 1;
            this.nameError.Text = "Fill information!";
            this.nameError.Visible = false;
            // 
            // nameTxt
            // 
            this.nameTxt.BorderColor = System.Drawing.Color.White;
            this.nameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTxt.DefaultText = "";
            this.nameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.nameTxt.ForeColor = System.Drawing.Color.Black;
            this.nameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTxt.Location = new System.Drawing.Point(3, 324);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.PasswordChar = '\0';
            this.nameTxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.nameTxt.PlaceholderText = "Name";
            this.nameTxt.SelectedText = "";
            this.nameTxt.Size = new System.Drawing.Size(308, 48);
            this.nameTxt.TabIndex = 0;
            this.nameTxt.TextOffset = new System.Drawing.Point(10, 0);
            this.nameTxt.Click += new System.EventHandler(this.nameTxt_Click);
            // 
            // addBtn
            // 
            this.addBtn.BorderRadius = 10;
            this.addBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.addBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(23, 50);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(133, 46);
            this.addBtn.TabIndex = 17;
            this.addBtn.Text = "Add New";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // catalogPanel
            // 
            this.catalogPanel.BorderRadius = 25;
            this.catalogPanel.Controls.Add(this.next);
            this.catalogPanel.Controls.Add(this.previous);
            this.catalogPanel.Controls.Add(this.listDGV);
            this.catalogPanel.Controls.Add(this.updateBtn);
            this.catalogPanel.Controls.Add(this.deleteBtn);
            this.catalogPanel.Controls.Add(this.guna2HtmlLabel13);
            this.catalogPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.catalogPanel.Location = new System.Drawing.Point(23, 110);
            this.catalogPanel.Margin = new System.Windows.Forms.Padding(4);
            this.catalogPanel.Name = "catalogPanel";
            this.catalogPanel.Size = new System.Drawing.Size(1510, 595);
            this.catalogPanel.TabIndex = 15;
            // 
            // listDGV
            // 
            this.listDGV.AllowUserToResizeColumns = false;
            this.listDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.listDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listDGV.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.listDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listDGV.Location = new System.Drawing.Point(36, 92);
            this.listDGV.Name = "listDGV";
            this.listDGV.ReadOnly = true;
            this.listDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.listDGV.RowHeadersVisible = false;
            this.listDGV.RowHeadersWidth = 51;
            this.listDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listDGV.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.listDGV.RowTemplate.Height = 30;
            this.listDGV.Size = new System.Drawing.Size(1445, 461);
            this.listDGV.TabIndex = 25;
            this.listDGV.TabStop = false;
            this.listDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Transparent;
            this.listDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.listDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.listDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.listDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.listDGV.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.listDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.listDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.listDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.listDGV.ThemeStyle.HeaderStyle.Height = 40;
            this.listDGV.ThemeStyle.ReadOnly = true;
            this.listDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.listDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.listDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.listDGV.ThemeStyle.RowsStyle.Height = 30;
            this.listDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // updateBtn
            // 
            this.updateBtn.BorderRadius = 10;
            this.updateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.updateBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.Black;
            this.updateBtn.Location = new System.Drawing.Point(1166, 10);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(133, 46);
            this.updateBtn.TabIndex = 19;
            this.updateBtn.Text = "Update";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
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
            this.deleteBtn.Location = new System.Drawing.Point(1323, 10);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(133, 46);
            this.deleteBtn.TabIndex = 20;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
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
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(273, 39);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Student Management";
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
            this.next.Location = new System.Drawing.Point(713, 560);
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
            this.previous.Location = new System.Drawing.Point(608, 560);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(86, 26);
            this.previous.TabIndex = 27;
            this.previous.Text = "previous";
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // StudentManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1562, 713);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(215, 187);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.catalogPanel.ResumeLayout(false);
            this.catalogPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel mainPanel;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Panel catalogPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private Guna.UI2.WinForms.Guna2Panel addPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel panelLb;
        private Guna.UI2.WinForms.Guna2GradientButton saveBtn;
        private Guna.UI2.WinForms.Guna2TextBox emailTxt;
        private Guna.UI2.WinForms.Guna2HtmlLabel emailError;
        private Guna.UI2.WinForms.Guna2HtmlLabel classError;
        private Guna.UI2.WinForms.Guna2TextBox classTxt;
        private Guna.UI2.WinForms.Guna2TextBox phoneTxt;
        private Guna.UI2.WinForms.Guna2HtmlLabel phoneError;
        private Guna.UI2.WinForms.Guna2HtmlLabel nameError;
        private Guna.UI2.WinForms.Guna2TextBox nameTxt;
        private Guna.UI2.WinForms.Guna2Button updateBtn;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
        private Guna.UI2.WinForms.Guna2DataGridView listDGV;
        private Guna.UI2.WinForms.Guna2ComboBox listSearchCb;
        private Guna.UI2.WinForms.Guna2TextBox searchTxt;
        private Guna.UI2.WinForms.Guna2HtmlLabel duplicatemssv;
        private Guna.UI2.WinForms.Guna2HtmlLabel studentCodeError;
        private Guna.UI2.WinForms.Guna2TextBox studentCodeTxt;
        private Guna.UI2.WinForms.Guna2Button next;
        private Guna.UI2.WinForms.Guna2Button previous;
    }
}