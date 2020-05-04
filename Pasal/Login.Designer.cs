namespace Pasal
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbuser = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkfpass = new MetroFramework.Controls.MetroLink();
            this.btnlogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbin = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbuser = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbtitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbpass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbpass = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 17;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbuser);
            this.panel1.Controls.Add(this.lbpass);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.linkfpass);
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Controls.Add(this.lbin);
            this.panel1.Controls.Add(this.tbpass);
            this.panel1.Controls.Add(this.tbuser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(359, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 500);
            this.panel1.TabIndex = 0;
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.BackColor = System.Drawing.Color.Transparent;
            this.lbuser.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuser.Location = new System.Drawing.Point(73, 235);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(69, 19);
            this.lbuser.TabIndex = 17;
            this.lbuser.Text = "Username";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Pasal.Properties.Resources.Shutdown_50px;
            this.pictureBox3.Location = new System.Drawing.Point(281, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pasal.Properties.Resources.User_100px;
            this.pictureBox2.Location = new System.Drawing.Point(125, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // linkfpass
            // 
            this.linkfpass.BackColor = System.Drawing.Color.Transparent;
            this.linkfpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkfpass.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.linkfpass.ForeColor = System.Drawing.Color.Crimson;
            this.linkfpass.Location = new System.Drawing.Point(189, 441);
            this.linkfpass.Name = "linkfpass";
            this.linkfpass.Size = new System.Drawing.Size(140, 23);
            this.linkfpass.Style = MetroFramework.MetroColorStyle.Teal;
            this.linkfpass.TabIndex = 10;
            this.linkfpass.Text = "Forgot Password?";
            this.linkfpass.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.linkfpass.UseCustomBackColor = true;
            this.linkfpass.UseCustomForeColor = true;
            this.linkfpass.UseSelectable = true;
            this.linkfpass.UseStyleColors = true;
            this.linkfpass.Click += new System.EventHandler(this.linkfpass_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.ActiveBorderThickness = 2;
            this.btnlogin.ActiveCornerRadius = 20;
            this.btnlogin.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnlogin.ActiveForecolor = System.Drawing.Color.LimeGreen;
            this.btnlogin.ActiveLineColor = System.Drawing.Color.LimeGreen;
            this.btnlogin.BackColor = System.Drawing.Color.White;
            this.btnlogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlogin.BackgroundImage")));
            this.btnlogin.ButtonText = "Login";
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnlogin.IdleBorderThickness = 1;
            this.btnlogin.IdleCornerRadius = 20;
            this.btnlogin.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnlogin.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnlogin.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnlogin.Location = new System.Drawing.Point(90, 392);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(181, 41);
            this.btnlogin.TabIndex = 8;
            this.btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lbin
            // 
            this.lbin.AutoSize = true;
            this.lbin.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbin.Location = new System.Drawing.Point(120, 33);
            this.lbin.Name = "lbin";
            this.lbin.Size = new System.Drawing.Size(106, 39);
            this.lbin.TabIndex = 7;
            this.lbin.Text = "Sign In";
            this.lbin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbuser
            // 
            this.tbuser.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.tbuser.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbuser.BorderColorMouseHover = System.Drawing.Color.RoyalBlue;
            this.tbuser.BorderThickness = 3;
            this.tbuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbuser.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbuser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbuser.isPassword = false;
            this.tbuser.Location = new System.Drawing.Point(55, 222);
            this.tbuser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(247, 45);
            this.tbuser.TabIndex = 5;
            this.tbuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbuser.Enter += new System.EventHandler(this.tbuser_Enter);
            this.tbuser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbuser_MouseDown);
            this.tbuser.MouseLeave += new System.EventHandler(this.tbuser_MouseLeave);
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.Font = new System.Drawing.Font("Roboto Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitle.Location = new System.Drawing.Point(88, 278);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(174, 77);
            this.lbtitle.TabIndex = 8;
            this.lbtitle.Text = "Pasal";
            this.lbtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // tbpass
            // 
            this.tbpass.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.tbpass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbpass.BorderColorMouseHover = System.Drawing.Color.RoyalBlue;
            this.tbpass.BorderThickness = 3;
            this.tbpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbpass.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbpass.isPassword = true;
            this.tbpass.Location = new System.Drawing.Point(55, 310);
            this.tbpass.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(247, 45);
            this.tbpass.TabIndex = 6;
            this.tbpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbpass.Enter += new System.EventHandler(this.tbpass_Enter);
            this.tbpass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbpass_MouseDown);
            this.tbpass.MouseLeave += new System.EventHandler(this.tbpass_MouseLeave);
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.BackColor = System.Drawing.Color.Transparent;
            this.lbpass.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpass.Location = new System.Drawing.Point(73, 324);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(67, 19);
            this.lbpass.TabIndex = 18;
            this.lbpass.Text = "Password";
            // 
            // Login
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbtitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pasal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbuser;
        private Bunifu.Framework.UI.BunifuCustomLabel lbtitle;
        private Bunifu.Framework.UI.BunifuCustomLabel lbin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnlogin;
        private MetroFramework.Controls.MetroLink linkfpass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbuser;
        private Bunifu.Framework.UI.BunifuCustomLabel lbpass;
        public Bunifu.Framework.UI.BunifuMetroTextbox tbpass;
        
    }
}

