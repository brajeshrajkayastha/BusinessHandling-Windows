namespace Pasal
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.lbclose = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbtitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbcompany = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbrate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbaddr4ess = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbcontact = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btndone = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbbalance = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SuspendLayout();
            // 
            // lbclose
            // 
            this.lbclose.AutoSize = true;
            this.lbclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbclose.Location = new System.Drawing.Point(253, 9);
            this.lbclose.Name = "lbclose";
            this.lbclose.Size = new System.Drawing.Size(39, 37);
            this.lbclose.TabIndex = 35;
            this.lbclose.Text = "X";
            this.lbclose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbclose.Click += new System.EventHandler(this.lbclose_Click);
            this.lbclose.MouseLeave += new System.EventHandler(this.lbclose_MouseLeave);
            this.lbclose.MouseHover += new System.EventHandler(this.lbclose_MouseHover);
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitle.Location = new System.Drawing.Point(46, 9);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(219, 37);
            this.lbtitle.TabIndex = 34;
            this.lbtitle.Text = "New Supplier";
            this.lbtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 17;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(55, 234);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(80, 20);
            this.bunifuCustomLabel2.TabIndex = 39;
            this.bunifuCustomLabel2.Text = "Company:";
            // 
            // tbcompany
            // 
            this.tbcompany.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbcompany.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbcompany.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbcompany.BorderThickness = 3;
            this.tbcompany.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbcompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbcompany.isPassword = false;
            this.tbcompany.Location = new System.Drawing.Point(53, 254);
            this.tbcompany.Margin = new System.Windows.Forms.Padding(4);
            this.tbcompany.Name = "tbcompany";
            this.tbcompany.Size = new System.Drawing.Size(185, 32);
            this.tbcompany.TabIndex = 38;
            this.tbcompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbrate
            // 
            this.lbrate.AutoSize = true;
            this.lbrate.BackColor = System.Drawing.Color.Transparent;
            this.lbrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrate.Location = new System.Drawing.Point(56, 65);
            this.lbrate.Name = "lbrate";
            this.lbrate.Size = new System.Drawing.Size(55, 20);
            this.lbrate.TabIndex = 37;
            this.lbrate.Text = "Name:";
            // 
            // tbname
            // 
            this.tbname.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbname.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbname.BorderThickness = 3;
            this.tbname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbname.isPassword = false;
            this.tbname.Location = new System.Drawing.Point(53, 84);
            this.tbname.Margin = new System.Windows.Forms.Padding(4);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(185, 32);
            this.tbname.TabIndex = 36;
            this.tbname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(56, 122);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(72, 20);
            this.bunifuCustomLabel1.TabIndex = 41;
            this.bunifuCustomLabel1.Text = "Address:";
            // 
            // tbaddr4ess
            // 
            this.tbaddr4ess.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbaddr4ess.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbaddr4ess.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbaddr4ess.BorderThickness = 3;
            this.tbaddr4ess.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbaddr4ess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbaddr4ess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbaddr4ess.isPassword = false;
            this.tbaddr4ess.Location = new System.Drawing.Point(53, 141);
            this.tbaddr4ess.Margin = new System.Windows.Forms.Padding(4);
            this.tbaddr4ess.Name = "tbaddr4ess";
            this.tbaddr4ess.Size = new System.Drawing.Size(185, 32);
            this.tbaddr4ess.TabIndex = 40;
            this.tbaddr4ess.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(56, 179);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(69, 20);
            this.bunifuCustomLabel3.TabIndex = 43;
            this.bunifuCustomLabel3.Text = "Contact:";
            // 
            // tbcontact
            // 
            this.tbcontact.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbcontact.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbcontact.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbcontact.BorderThickness = 3;
            this.tbcontact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcontact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbcontact.isPassword = false;
            this.tbcontact.Location = new System.Drawing.Point(53, 198);
            this.tbcontact.Margin = new System.Windows.Forms.Padding(4);
            this.tbcontact.Name = "tbcontact";
            this.tbcontact.Size = new System.Drawing.Size(185, 32);
            this.tbcontact.TabIndex = 42;
            this.tbcontact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btndone
            // 
            this.btndone.ActiveBorderThickness = 1;
            this.btndone.ActiveCornerRadius = 20;
            this.btndone.ActiveFillColor = System.Drawing.Color.Black;
            this.btndone.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btndone.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btndone.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btndone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndone.BackgroundImage")));
            this.btndone.ButtonText = "Done";
            this.btndone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndone.ForeColor = System.Drawing.Color.SeaGreen;
            this.btndone.IdleBorderThickness = 1;
            this.btndone.IdleCornerRadius = 20;
            this.btndone.IdleFillColor = System.Drawing.Color.Transparent;
            this.btndone.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btndone.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btndone.Location = new System.Drawing.Point(51, 361);
            this.btndone.Margin = new System.Windows.Forms.Padding(5);
            this.btndone.Name = "btndone";
            this.btndone.Size = new System.Drawing.Size(181, 40);
            this.btndone.TabIndex = 44;
            this.btndone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndone.Click += new System.EventHandler(this.btndone_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(55, 300);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(71, 20);
            this.bunifuCustomLabel4.TabIndex = 46;
            this.bunifuCustomLabel4.Text = "Balance:";
            // 
            // tbbalance
            // 
            this.tbbalance.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbbalance.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbbalance.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbbalance.BorderThickness = 3;
            this.tbbalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbbalance.isPassword = false;
            this.tbbalance.Location = new System.Drawing.Point(53, 320);
            this.tbbalance.Margin = new System.Windows.Forms.Padding(4);
            this.tbbalance.Name = "tbbalance";
            this.tbbalance.Size = new System.Drawing.Size(185, 32);
            this.tbbalance.TabIndex = 45;
            this.tbbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Add
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(300, 415);
            this.ControlBox = false;
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.tbbalance);
            this.Controls.Add(this.btndone);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.tbcontact);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.tbaddr4ess);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.tbcompany);
            this.Controls.Add(this.lbrate);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lbclose);
            this.Controls.Add(this.lbtitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lbclose;
        private Bunifu.Framework.UI.BunifuCustomLabel lbtitle;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbcontact;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbaddr4ess;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbcompany;
        private Bunifu.Framework.UI.BunifuCustomLabel lbrate;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbname;
        private Bunifu.Framework.UI.BunifuThinButton2 btndone;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbbalance;
    }
}