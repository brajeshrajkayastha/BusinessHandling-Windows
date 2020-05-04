namespace Pasal
{
    partial class Forgotpassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forgotpassword));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btndone = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbnewpassc = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbnewpass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btncheck = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbpincode = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbrate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbuser = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbtitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbclose = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 17;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btndone
            // 
            this.btndone.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btndone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btndone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndone.BorderRadius = 0;
            this.btndone.ButtonText = "Done";
            this.btndone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndone.DisabledColor = System.Drawing.Color.Gray;
            this.btndone.Iconcolor = System.Drawing.Color.Transparent;
            this.btndone.Iconimage = ((System.Drawing.Image)(resources.GetObject("btndone.Iconimage")));
            this.btndone.Iconimage_right = null;
            this.btndone.Iconimage_right_Selected = null;
            this.btndone.Iconimage_Selected = null;
            this.btndone.IconMarginLeft = 0;
            this.btndone.IconMarginRight = 0;
            this.btndone.IconRightVisible = true;
            this.btndone.IconRightZoom = 0D;
            this.btndone.IconVisible = true;
            this.btndone.IconZoom = 90D;
            this.btndone.IsTab = false;
            this.btndone.Location = new System.Drawing.Point(216, 288);
            this.btndone.Name = "btndone";
            this.btndone.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btndone.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btndone.OnHoverTextColor = System.Drawing.Color.White;
            this.btndone.selected = false;
            this.btndone.Size = new System.Drawing.Size(94, 32);
            this.btndone.TabIndex = 62;
            this.btndone.Text = "Done";
            this.btndone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndone.Textcolor = System.Drawing.Color.White;
            this.btndone.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndone.Click += new System.EventHandler(this.btndone_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(16, 267);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(176, 20);
            this.bunifuCustomLabel2.TabIndex = 61;
            this.bunifuCustomLabel2.Text = "Confirm New Password:";
            // 
            // tbnewpassc
            // 
            this.tbnewpassc.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbnewpassc.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbnewpassc.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbnewpassc.BorderThickness = 3;
            this.tbnewpassc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbnewpassc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnewpassc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbnewpassc.isPassword = false;
            this.tbnewpassc.Location = new System.Drawing.Point(11, 288);
            this.tbnewpassc.Margin = new System.Windows.Forms.Padding(4);
            this.tbnewpassc.Name = "tbnewpassc";
            this.tbnewpassc.Size = new System.Drawing.Size(185, 32);
            this.tbnewpassc.TabIndex = 60;
            this.tbnewpassc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(16, 204);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(117, 20);
            this.bunifuCustomLabel3.TabIndex = 59;
            this.bunifuCustomLabel3.Text = "New Password:";
            // 
            // tbnewpass
            // 
            this.tbnewpass.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbnewpass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbnewpass.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbnewpass.BorderThickness = 3;
            this.tbnewpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbnewpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnewpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbnewpass.isPassword = false;
            this.tbnewpass.Location = new System.Drawing.Point(11, 225);
            this.tbnewpass.Margin = new System.Windows.Forms.Padding(4);
            this.tbnewpass.Name = "tbnewpass";
            this.tbnewpass.Size = new System.Drawing.Size(185, 32);
            this.tbnewpass.TabIndex = 58;
            this.tbnewpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-4, 178);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(362, 35);
            this.bunifuSeparator1.TabIndex = 57;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btncheck
            // 
            this.btncheck.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btncheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btncheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncheck.BorderRadius = 0;
            this.btncheck.ButtonText = "Check";
            this.btncheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncheck.DisabledColor = System.Drawing.Color.Gray;
            this.btncheck.Iconcolor = System.Drawing.Color.Transparent;
            this.btncheck.Iconimage = ((System.Drawing.Image)(resources.GetObject("btncheck.Iconimage")));
            this.btncheck.Iconimage_right = null;
            this.btncheck.Iconimage_right_Selected = null;
            this.btncheck.Iconimage_Selected = null;
            this.btncheck.IconMarginLeft = 0;
            this.btncheck.IconMarginRight = 0;
            this.btncheck.IconRightVisible = true;
            this.btncheck.IconRightZoom = 0D;
            this.btncheck.IconVisible = true;
            this.btncheck.IconZoom = 90D;
            this.btncheck.IsTab = false;
            this.btncheck.Location = new System.Drawing.Point(216, 139);
            this.btncheck.Name = "btncheck";
            this.btncheck.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btncheck.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btncheck.OnHoverTextColor = System.Drawing.Color.White;
            this.btncheck.selected = false;
            this.btncheck.Size = new System.Drawing.Size(94, 32);
            this.btncheck.TabIndex = 56;
            this.btncheck.Text = "Check";
            this.btncheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncheck.Textcolor = System.Drawing.Color.White;
            this.btncheck.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(14, 115);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(77, 20);
            this.bunifuCustomLabel1.TabIndex = 55;
            this.bunifuCustomLabel1.Text = "Pin Code:";
            // 
            // tbpincode
            // 
            this.tbpincode.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbpincode.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbpincode.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbpincode.BorderThickness = 3;
            this.tbpincode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbpincode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpincode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbpincode.isPassword = false;
            this.tbpincode.Location = new System.Drawing.Point(11, 139);
            this.tbpincode.Margin = new System.Windows.Forms.Padding(4);
            this.tbpincode.Name = "tbpincode";
            this.tbpincode.Size = new System.Drawing.Size(185, 32);
            this.tbpincode.TabIndex = 54;
            this.tbpincode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbrate
            // 
            this.lbrate.AutoSize = true;
            this.lbrate.BackColor = System.Drawing.Color.Transparent;
            this.lbrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrate.Location = new System.Drawing.Point(14, 55);
            this.lbrate.Name = "lbrate";
            this.lbrate.Size = new System.Drawing.Size(87, 20);
            this.lbrate.TabIndex = 53;
            this.lbrate.Text = "Username:";
            // 
            // tbuser
            // 
            this.tbuser.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbuser.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbuser.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbuser.BorderThickness = 3;
            this.tbuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbuser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbuser.isPassword = false;
            this.tbuser.Location = new System.Drawing.Point(11, 79);
            this.tbuser.Margin = new System.Windows.Forms.Padding(4);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(185, 32);
            this.tbuser.TabIndex = 52;
            this.tbuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitle.Location = new System.Drawing.Point(37, 4);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(276, 37);
            this.lbtitle.TabIndex = 51;
            this.lbtitle.Text = "Forgot Password";
            this.lbtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbclose
            // 
            this.lbclose.AutoSize = true;
            this.lbclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbclose.Location = new System.Drawing.Point(319, 4);
            this.lbclose.Name = "lbclose";
            this.lbclose.Size = new System.Drawing.Size(39, 37);
            this.lbclose.TabIndex = 50;
            this.lbclose.Text = "X";
            this.lbclose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbclose.Click += new System.EventHandler(this.lbclose_Click);
            this.lbclose.MouseLeave += new System.EventHandler(this.lbclose_MouseLeave);
            this.lbclose.MouseHover += new System.EventHandler(this.lbclose_MouseHover);
            // 
            // Forgotpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(360, 330);
            this.ControlBox = false;
            this.Controls.Add(this.btndone);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.tbnewpassc);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.tbnewpass);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.tbpincode);
            this.Controls.Add(this.lbrate);
            this.Controls.Add(this.tbuser);
            this.Controls.Add(this.lbtitle);
            this.Controls.Add(this.lbclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Forgotpassword";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Forgotpassword";
            this.Load += new System.EventHandler(this.Forgotpassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btndone;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbnewpassc;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbnewpass;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuFlatButton btncheck;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbpincode;
        private Bunifu.Framework.UI.BunifuCustomLabel lbrate;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbuser;
        private Bunifu.Framework.UI.BunifuCustomLabel lbtitle;
        private Bunifu.Framework.UI.BunifuCustomLabel lbclose;
    }
}