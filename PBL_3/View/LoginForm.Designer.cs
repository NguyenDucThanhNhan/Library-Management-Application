namespace PBL_3
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.loginBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.passwordTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.usernameLb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.passwordLb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.forgotPasswordBtn = new Guna.UI2.WinForms.Guna2Button();
            this.showpass = new Guna.UI2.WinForms.Guna2Button();
            this.hidepass = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.White;
            this.guna2ControlBox2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1176, 5);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 17;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.BorderRadius = 15;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginBtn.FillColor = System.Drawing.Color.Turquoise;
            this.loginBtn.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(862, 669);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(315, 45);
            this.loginBtn.TabIndex = 23;
            this.loginBtn.Text = "Login";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordTb
            // 
            this.passwordTb.BackColor = System.Drawing.Color.Transparent;
            this.passwordTb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.passwordTb.BorderRadius = 12;
            this.passwordTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTb.DefaultText = "";
            this.passwordTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTb.ForeColor = System.Drawing.Color.Black;
            this.passwordTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTb.Location = new System.Drawing.Point(858, 560);
            this.passwordTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '*';
            this.passwordTb.PlaceholderForeColor = System.Drawing.Color.PowderBlue;
            this.passwordTb.PlaceholderText = "Password";
            this.passwordTb.SelectedText = "";
            this.passwordTb.Size = new System.Drawing.Size(319, 48);
            this.passwordTb.TabIndex = 19;
            this.passwordTb.TabStop = false;
            this.passwordTb.TextChanged += new System.EventHandler(this.passwordTb_TextChanged);
            // 
            // usernameTb
            // 
            this.usernameTb.BackColor = System.Drawing.Color.Transparent;
            this.usernameTb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.usernameTb.BorderRadius = 12;
            this.usernameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTb.DefaultText = "";
            this.usernameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTb.ForeColor = System.Drawing.Color.Black;
            this.usernameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTb.Location = new System.Drawing.Point(858, 485);
            this.usernameTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.PasswordChar = '\0';
            this.usernameTb.PlaceholderForeColor = System.Drawing.Color.PowderBlue;
            this.usernameTb.PlaceholderText = "Username";
            this.usernameTb.SelectedText = "";
            this.usernameTb.Size = new System.Drawing.Size(319, 48);
            this.usernameTb.TabIndex = 20;
            this.usernameTb.TabStop = false;
            this.usernameTb.TextChanged += new System.EventHandler(this.usernameTb_TextChanged);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BackColor = System.Drawing.Color.White;
            this.guna2ControlBox3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1227, 5);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 17;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(963, 410);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(89, 40);
            this.guna2HtmlLabel3.TabIndex = 22;
            this.guna2HtmlLabel3.Text = "LOGIN";
            // 
            // usernameLb
            // 
            this.usernameLb.BackColor = System.Drawing.Color.Transparent;
            this.usernameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLb.ForeColor = System.Drawing.Color.Transparent;
            this.usernameLb.Location = new System.Drawing.Point(1045, 538);
            this.usernameLb.Margin = new System.Windows.Forms.Padding(1);
            this.usernameLb.Name = "usernameLb";
            this.usernameLb.Size = new System.Drawing.Size(132, 17);
            this.usernameLb.TabIndex = 26;
            this.usernameLb.TabStop = false;
            this.usernameLb.Text = "Username doesn\'t exist";
            // 
            // passwordLb
            // 
            this.passwordLb.BackColor = System.Drawing.Color.Transparent;
            this.passwordLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLb.ForeColor = System.Drawing.Color.Transparent;
            this.passwordLb.Location = new System.Drawing.Point(1071, 615);
            this.passwordLb.Name = "passwordLb";
            this.passwordLb.Size = new System.Drawing.Size(106, 17);
            this.passwordLb.TabIndex = 26;
            this.passwordLb.Text = "Incorrect password";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::PBL_3.Properties.Resources.logo;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(874, 30);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(296, 296);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 25;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::PBL_3.Properties.Resources.painting;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(754, 783);
            this.guna2PictureBox1.TabIndex = 15;
            this.guna2PictureBox1.TabStop = false;
            // 
            // forgotPasswordBtn
            // 
            this.forgotPasswordBtn.BackColor = System.Drawing.Color.Transparent;
            this.forgotPasswordBtn.BorderColor = System.Drawing.Color.Transparent;
            this.forgotPasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotPasswordBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.forgotPasswordBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.forgotPasswordBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.forgotPasswordBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.forgotPasswordBtn.FillColor = System.Drawing.Color.Transparent;
            this.forgotPasswordBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordBtn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.forgotPasswordBtn.Location = new System.Drawing.Point(1045, 632);
            this.forgotPasswordBtn.Name = "forgotPasswordBtn";
            this.forgotPasswordBtn.PressedColor = System.Drawing.Color.Transparent;
            this.forgotPasswordBtn.Size = new System.Drawing.Size(132, 31);
            this.forgotPasswordBtn.TabIndex = 27;
            this.forgotPasswordBtn.Text = "Forgot Password";
            this.forgotPasswordBtn.Click += new System.EventHandler(this.forgotPasswordBtn_Click);
            // 
            // showpass
            // 
            this.showpass.BackColor = System.Drawing.Color.Transparent;
            this.showpass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.showpass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.showpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.showpass.FillColor = System.Drawing.Color.Transparent;
            this.showpass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.showpass.ForeColor = System.Drawing.Color.White;
            this.showpass.Image = global::PBL_3.Properties.Resources.eye;
            this.showpass.ImageSize = new System.Drawing.Size(23, 23);
            this.showpass.Location = new System.Drawing.Point(1140, 574);
            this.showpass.Name = "showpass";
            this.showpass.PressedColor = System.Drawing.Color.Gray;
            this.showpass.Size = new System.Drawing.Size(22, 20);
            this.showpass.TabIndex = 29;
            this.showpass.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.showpass.Click += new System.EventHandler(this.showpass_Click);
            // 
            // hidepass
            // 
            this.hidepass.BackColor = System.Drawing.Color.Transparent;
            this.hidepass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.hidepass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.hidepass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.hidepass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.hidepass.FillColor = System.Drawing.Color.Transparent;
            this.hidepass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hidepass.ForeColor = System.Drawing.Color.White;
            this.hidepass.Image = ((System.Drawing.Image)(resources.GetObject("hidepass.Image")));
            this.hidepass.ImageSize = new System.Drawing.Size(23, 23);
            this.hidepass.Location = new System.Drawing.Point(1140, 574);
            this.hidepass.Name = "hidepass";
            this.hidepass.PressedColor = System.Drawing.Color.Gray;
            this.hidepass.Size = new System.Drawing.Size(22, 20);
            this.hidepass.TabIndex = 30;
            this.hidepass.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.hidepass.Click += new System.EventHandler(this.hidepass_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PBL_3.Properties.Resources.BlueBackground;
            this.ClientSize = new System.Drawing.Size(1280, 780);
            this.Controls.Add(this.hidepass);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.forgotPasswordBtn);
            this.Controls.Add(this.passwordLb);
            this.Controls.Add(this.usernameLb);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.usernameTb);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(500, 500);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2GradientButton loginBtn;
        private Guna.UI2.WinForms.Guna2TextBox passwordTb;
        private Guna.UI2.WinForms.Guna2TextBox usernameTb;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel usernameLb;
        private Guna.UI2.WinForms.Guna2HtmlLabel passwordLb;
        private Guna.UI2.WinForms.Guna2Button forgotPasswordBtn;
        private Guna.UI2.WinForms.Guna2Button showpass;
        private Guna.UI2.WinForms.Guna2Button hidepass;
    }
}

