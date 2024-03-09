namespace PBL_3
{
    partial class VerifyEmailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emailTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.sendCodeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.codeTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.cancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.validateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.usernameLb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.emailLb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.codeLb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(860, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your username before validing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(905, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Forgot Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 4;
            // 
            // emailTb
            // 
            this.emailTb.BackColor = System.Drawing.Color.Transparent;
            this.emailTb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.emailTb.BorderRadius = 12;
            this.emailTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTb.DefaultText = "E-mail";
            this.emailTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTb.ForeColor = System.Drawing.Color.PowderBlue;
            this.emailTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTb.Location = new System.Drawing.Point(863, 512);
            this.emailTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTb.Name = "emailTb";
            this.emailTb.PasswordChar = '\0';
            this.emailTb.PlaceholderText = "";
            this.emailTb.SelectedText = "";
            this.emailTb.Size = new System.Drawing.Size(319, 48);
            this.emailTb.TabIndex = 28;
            this.emailTb.TabStop = false;
            this.emailTb.TextChanged += new System.EventHandler(this.emailTb_TextChanged);
            this.emailTb.Click += new System.EventHandler(this.emailTb_Click);
            // 
            // usernameTb
            // 
            this.usernameTb.BackColor = System.Drawing.Color.Transparent;
            this.usernameTb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.usernameTb.BorderRadius = 12;
            this.usernameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTb.DefaultText = "Username";
            this.usernameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTb.ForeColor = System.Drawing.Color.PowderBlue;
            this.usernameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTb.Location = new System.Drawing.Point(863, 437);
            this.usernameTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.PasswordChar = '\0';
            this.usernameTb.PlaceholderText = "";
            this.usernameTb.SelectedText = "";
            this.usernameTb.Size = new System.Drawing.Size(319, 48);
            this.usernameTb.TabIndex = 29;
            this.usernameTb.TabStop = false;
            this.usernameTb.TextChanged += new System.EventHandler(this.usernameTb_TextChanged);
            this.usernameTb.Click += new System.EventHandler(this.usernameTb_Click);
            // 
            // sendCodeBtn
            // 
            this.sendCodeBtn.BackColor = System.Drawing.Color.Transparent;
            this.sendCodeBtn.BorderRadius = 7;
            this.sendCodeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sendCodeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sendCodeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendCodeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sendCodeBtn.FillColor = System.Drawing.Color.LightSeaGreen;
            this.sendCodeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendCodeBtn.ForeColor = System.Drawing.Color.White;
            this.sendCodeBtn.Location = new System.Drawing.Point(1035, 586);
            this.sendCodeBtn.Name = "sendCodeBtn";
            this.sendCodeBtn.Size = new System.Drawing.Size(147, 35);
            this.sendCodeBtn.TabIndex = 30;
            this.sendCodeBtn.Text = "Send Code";
            this.sendCodeBtn.Click += new System.EventHandler(this.sendCodeBtn_Click);
            // 
            // codeTb
            // 
            this.codeTb.BackColor = System.Drawing.Color.Transparent;
            this.codeTb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.codeTb.BorderRadius = 12;
            this.codeTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeTb.DefaultText = "Code";
            this.codeTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.codeTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.codeTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.codeTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.codeTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.codeTb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTb.ForeColor = System.Drawing.Color.PowderBlue;
            this.codeTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.codeTb.Location = new System.Drawing.Point(863, 640);
            this.codeTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.codeTb.Name = "codeTb";
            this.codeTb.PasswordChar = '\0';
            this.codeTb.PlaceholderText = "";
            this.codeTb.SelectedText = "";
            this.codeTb.Size = new System.Drawing.Size(319, 48);
            this.codeTb.TabIndex = 28;
            this.codeTb.TabStop = false;
            this.codeTb.TextChanged += new System.EventHandler(this.codeTb_TextChanged);
            this.codeTb.Click += new System.EventHandler(this.codeTb_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.BorderRadius = 7;
            this.cancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelBtn.FillColor = System.Drawing.Color.LightSeaGreen;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(863, 716);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(147, 35);
            this.cancelBtn.TabIndex = 30;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // validateBtn
            // 
            this.validateBtn.BackColor = System.Drawing.Color.Transparent;
            this.validateBtn.BorderRadius = 7;
            this.validateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.validateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.validateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.validateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.validateBtn.FillColor = System.Drawing.Color.LightSeaGreen;
            this.validateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateBtn.ForeColor = System.Drawing.Color.White;
            this.validateBtn.Location = new System.Drawing.Point(1035, 716);
            this.validateBtn.Name = "validateBtn";
            this.validateBtn.Size = new System.Drawing.Size(147, 35);
            this.validateBtn.TabIndex = 30;
            this.validateBtn.Text = "Validate";
            this.validateBtn.Click += new System.EventHandler(this.validateBtn_Click);
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
            this.guna2ControlBox3.TabIndex = 31;
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
            this.guna2ControlBox2.TabIndex = 32;
            // 
            // usernameLb
            // 
            this.usernameLb.BackColor = System.Drawing.Color.Transparent;
            this.usernameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLb.ForeColor = System.Drawing.Color.Transparent;
            this.usernameLb.Location = new System.Drawing.Point(1050, 490);
            this.usernameLb.Margin = new System.Windows.Forms.Padding(1);
            this.usernameLb.Name = "usernameLb";
            this.usernameLb.Size = new System.Drawing.Size(132, 17);
            this.usernameLb.TabIndex = 33;
            this.usernameLb.Text = "Username doesn\'t exist";
            // 
            // emailLb
            // 
            this.emailLb.BackColor = System.Drawing.Color.Transparent;
            this.emailLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLb.ForeColor = System.Drawing.Color.Transparent;
            this.emailLb.Location = new System.Drawing.Point(1050, 565);
            this.emailLb.Margin = new System.Windows.Forms.Padding(1);
            this.emailLb.Name = "emailLb";
            this.emailLb.Size = new System.Drawing.Size(132, 17);
            this.emailLb.TabIndex = 34;
            this.emailLb.Text = "Username doesn\'t exist";
            // 
            // codeLb
            // 
            this.codeLb.BackColor = System.Drawing.Color.Transparent;
            this.codeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeLb.ForeColor = System.Drawing.Color.Transparent;
            this.codeLb.Location = new System.Drawing.Point(1050, 693);
            this.codeLb.Margin = new System.Windows.Forms.Padding(1);
            this.codeLb.Name = "codeLb";
            this.codeLb.Size = new System.Drawing.Size(132, 17);
            this.codeLb.TabIndex = 34;
            this.codeLb.Text = "Username doesn\'t exist";
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
            this.guna2CirclePictureBox1.TabIndex = 27;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::PBL_3.Properties.Resources.painting;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(754, 783);
            this.guna2PictureBox1.TabIndex = 26;
            this.guna2PictureBox1.TabStop = false;
            // 
            // VerifyEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PBL_3.Properties.Resources.BlueBackground;
            this.ClientSize = new System.Drawing.Size(1280, 780);
            this.Controls.Add(this.codeLb);
            this.Controls.Add(this.emailLb);
            this.Controls.Add(this.usernameLb);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.validateBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.sendCodeBtn);
            this.Controls.Add(this.codeTb);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.usernameTb);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerifyEmailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox emailTb;
        private Guna.UI2.WinForms.Guna2TextBox usernameTb;
        private Guna.UI2.WinForms.Guna2Button sendCodeBtn;
        private Guna.UI2.WinForms.Guna2TextBox codeTb;
        private Guna.UI2.WinForms.Guna2Button cancelBtn;
        private Guna.UI2.WinForms.Guna2Button validateBtn;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel usernameLb;
        private Guna.UI2.WinForms.Guna2HtmlLabel emailLb;
        private Guna.UI2.WinForms.Guna2HtmlLabel codeLb;
    }
}