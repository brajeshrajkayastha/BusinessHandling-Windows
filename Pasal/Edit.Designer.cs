namespace Pasal
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbclose = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbtitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tab = new MetroFramework.Controls.MetroTabControl();
            this.tabadd = new MetroFramework.Controls.MetroTabPage();
            this.btndone1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tbproduct1 = new MetroFramework.Controls.MetroTextBox();
            this.border2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbqty = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbqty = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbrate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbproduct2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbrate = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tabdelete = new MetroFramework.Controls.MetroTabPage();
            this.btndone2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tbproduct2 = new MetroFramework.Controls.MetroTextBox();
            this.bunifuMetroTextbox2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbqty2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tab.SuspendLayout();
            this.tabadd.SuspendLayout();
            this.tabdelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 17;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lbclose
            // 
            this.lbclose.AutoSize = true;
            this.lbclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbclose.Location = new System.Drawing.Point(260, 9);
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
            this.lbtitle.Location = new System.Drawing.Point(75, 9);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(171, 37);
            this.lbtitle.TabIndex = 34;
            this.lbtitle.Text = "Stock Edit";
            this.lbtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabadd);
            this.tab.Controls.Add(this.tabdelete);
            this.tab.Location = new System.Drawing.Point(4, 56);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(291, 346);
            this.tab.TabIndex = 36;
            this.tab.UseSelectable = true;
            // 
            // tabadd
            // 
            this.tabadd.Controls.Add(this.btndone1);
            this.tabadd.Controls.Add(this.tbproduct1);
            this.tabadd.Controls.Add(this.border2);
            this.tabadd.Controls.Add(this.lbqty);
            this.tabadd.Controls.Add(this.tbqty);
            this.tabadd.Controls.Add(this.lbrate);
            this.tabadd.Controls.Add(this.lbproduct2);
            this.tabadd.Controls.Add(this.tbrate);
            this.tabadd.HorizontalScrollbarBarColor = true;
            this.tabadd.HorizontalScrollbarHighlightOnWheel = false;
            this.tabadd.HorizontalScrollbarSize = 10;
            this.tabadd.Location = new System.Drawing.Point(4, 38);
            this.tabadd.Name = "tabadd";
            this.tabadd.Size = new System.Drawing.Size(283, 304);
            this.tabadd.TabIndex = 0;
            this.tabadd.Text = "Stock Add";
            this.tabadd.VerticalScrollbarBarColor = true;
            this.tabadd.VerticalScrollbarHighlightOnWheel = false;
            this.tabadd.VerticalScrollbarSize = 10;
            // 
            // btndone1
            // 
            this.btndone1.ActiveBorderThickness = 1;
            this.btndone1.ActiveCornerRadius = 20;
            this.btndone1.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btndone1.ActiveForecolor = System.Drawing.Color.White;
            this.btndone1.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btndone1.BackColor = System.Drawing.SystemColors.Control;
            this.btndone1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndone1.BackgroundImage")));
            this.btndone1.ButtonText = "Done";
            this.btndone1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndone1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndone1.ForeColor = System.Drawing.Color.SeaGreen;
            this.btndone1.IdleBorderThickness = 1;
            this.btndone1.IdleCornerRadius = 20;
            this.btndone1.IdleFillColor = System.Drawing.Color.White;
            this.btndone1.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btndone1.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btndone1.Location = new System.Drawing.Point(55, 252);
            this.btndone1.Margin = new System.Windows.Forms.Padding(5);
            this.btndone1.Name = "btndone1";
            this.btndone1.Size = new System.Drawing.Size(181, 41);
            this.btndone1.TabIndex = 72;
            this.btndone1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndone1.Click += new System.EventHandler(this.btndone1_Click);
            // 
            // tbproduct1
            // 
            this.tbproduct1.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.tbproduct1.CustomButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbproduct1.CustomButton.Image = global::Pasal.Properties.Resources.Forrst_50px;
            this.tbproduct1.CustomButton.Location = new System.Drawing.Point(204, 1);
            this.tbproduct1.CustomButton.Name = "";
            this.tbproduct1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbproduct1.CustomButton.Style = MetroFramework.MetroColorStyle.Teal;
            this.tbproduct1.CustomButton.TabIndex = 1;
            this.tbproduct1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbproduct1.CustomButton.UseSelectable = true;
            this.tbproduct1.CustomButton.UseVisualStyleBackColor = false;
            this.tbproduct1.CustomButton.Visible = false;
            this.tbproduct1.DisplayIcon = true;
            this.tbproduct1.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.tbproduct1.Lines = new string[0];
            this.tbproduct1.Location = new System.Drawing.Point(30, 42);
            this.tbproduct1.MaxLength = 32767;
            this.tbproduct1.Name = "tbproduct1";
            this.tbproduct1.PasswordChar = '\0';
            this.tbproduct1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbproduct1.SelectedText = "";
            this.tbproduct1.SelectionLength = 0;
            this.tbproduct1.SelectionStart = 0;
            this.tbproduct1.ShortcutsEnabled = true;
            this.tbproduct1.Size = new System.Drawing.Size(226, 23);
            this.tbproduct1.TabIndex = 66;
            this.tbproduct1.UseCustomBackColor = true;
            this.tbproduct1.UseSelectable = true;
            this.tbproduct1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbproduct1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // border2
            // 
            this.border2.BorderColorFocused = System.Drawing.Color.Blue;
            this.border2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.border2.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.border2.BorderThickness = 3;
            this.border2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.border2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.border2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.border2.isPassword = false;
            this.border2.Location = new System.Drawing.Point(25, 37);
            this.border2.Margin = new System.Windows.Forms.Padding(4);
            this.border2.Name = "border2";
            this.border2.Size = new System.Drawing.Size(235, 32);
            this.border2.TabIndex = 65;
            this.border2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbqty
            // 
            this.lbqty.AutoSize = true;
            this.lbqty.BackColor = System.Drawing.Color.Transparent;
            this.lbqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbqty.Location = new System.Drawing.Point(31, 166);
            this.lbqty.Name = "lbqty";
            this.lbqty.Size = new System.Drawing.Size(72, 20);
            this.lbqty.TabIndex = 64;
            this.lbqty.Text = "Quantity:";
            // 
            // tbqty
            // 
            this.tbqty.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbqty.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbqty.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbqty.BorderThickness = 3;
            this.tbqty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbqty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbqty.isPassword = false;
            this.tbqty.Location = new System.Drawing.Point(30, 190);
            this.tbqty.Margin = new System.Windows.Forms.Padding(4);
            this.tbqty.Name = "tbqty";
            this.tbqty.Size = new System.Drawing.Size(230, 32);
            this.tbqty.TabIndex = 63;
            this.tbqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbrate
            // 
            this.lbrate.AutoSize = true;
            this.lbrate.BackColor = System.Drawing.Color.Transparent;
            this.lbrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrate.Location = new System.Drawing.Point(31, 91);
            this.lbrate.Name = "lbrate";
            this.lbrate.Size = new System.Drawing.Size(48, 20);
            this.lbrate.TabIndex = 62;
            this.lbrate.Text = "Rate:";
            // 
            // lbproduct2
            // 
            this.lbproduct2.AutoSize = true;
            this.lbproduct2.BackColor = System.Drawing.Color.Transparent;
            this.lbproduct2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbproduct2.Location = new System.Drawing.Point(31, 13);
            this.lbproduct2.Name = "lbproduct2";
            this.lbproduct2.Size = new System.Drawing.Size(68, 20);
            this.lbproduct2.TabIndex = 61;
            this.lbproduct2.Text = "Product:";
            // 
            // tbrate
            // 
            this.tbrate.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbrate.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbrate.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbrate.BorderThickness = 3;
            this.tbrate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbrate.isPassword = false;
            this.tbrate.Location = new System.Drawing.Point(30, 115);
            this.tbrate.Margin = new System.Windows.Forms.Padding(4);
            this.tbrate.Name = "tbrate";
            this.tbrate.Size = new System.Drawing.Size(230, 32);
            this.tbrate.TabIndex = 60;
            this.tbrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tabdelete
            // 
            this.tabdelete.Controls.Add(this.btndone2);
            this.tabdelete.Controls.Add(this.tbproduct2);
            this.tabdelete.Controls.Add(this.bunifuMetroTextbox2);
            this.tabdelete.Controls.Add(this.bunifuCustomLabel2);
            this.tabdelete.Controls.Add(this.tbqty2);
            this.tabdelete.Controls.Add(this.bunifuCustomLabel3);
            this.tabdelete.HorizontalScrollbarBarColor = true;
            this.tabdelete.HorizontalScrollbarHighlightOnWheel = false;
            this.tabdelete.HorizontalScrollbarSize = 10;
            this.tabdelete.Location = new System.Drawing.Point(4, 38);
            this.tabdelete.Name = "tabdelete";
            this.tabdelete.Size = new System.Drawing.Size(283, 304);
            this.tabdelete.TabIndex = 1;
            this.tabdelete.Text = "Stock Delete";
            this.tabdelete.VerticalScrollbarBarColor = true;
            this.tabdelete.VerticalScrollbarHighlightOnWheel = false;
            this.tabdelete.VerticalScrollbarSize = 10;
            // 
            // btndone2
            // 
            this.btndone2.ActiveBorderThickness = 1;
            this.btndone2.ActiveCornerRadius = 20;
            this.btndone2.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btndone2.ActiveForecolor = System.Drawing.Color.White;
            this.btndone2.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btndone2.BackColor = System.Drawing.SystemColors.Control;
            this.btndone2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndone2.BackgroundImage")));
            this.btndone2.ButtonText = "Done";
            this.btndone2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndone2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndone2.ForeColor = System.Drawing.Color.SeaGreen;
            this.btndone2.IdleBorderThickness = 1;
            this.btndone2.IdleCornerRadius = 20;
            this.btndone2.IdleFillColor = System.Drawing.Color.White;
            this.btndone2.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btndone2.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btndone2.Location = new System.Drawing.Point(50, 231);
            this.btndone2.Margin = new System.Windows.Forms.Padding(5);
            this.btndone2.Name = "btndone2";
            this.btndone2.Size = new System.Drawing.Size(181, 41);
            this.btndone2.TabIndex = 84;
            this.btndone2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndone2.Click += new System.EventHandler(this.btndone2_Click);
            // 
            // tbproduct2
            // 
            this.tbproduct2.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.tbproduct2.CustomButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbproduct2.CustomButton.Image = global::Pasal.Properties.Resources.Forrst_50px;
            this.tbproduct2.CustomButton.Location = new System.Drawing.Point(204, 1);
            this.tbproduct2.CustomButton.Name = "";
            this.tbproduct2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbproduct2.CustomButton.Style = MetroFramework.MetroColorStyle.Teal;
            this.tbproduct2.CustomButton.TabIndex = 1;
            this.tbproduct2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbproduct2.CustomButton.UseSelectable = true;
            this.tbproduct2.CustomButton.UseVisualStyleBackColor = false;
            this.tbproduct2.CustomButton.Visible = false;
            this.tbproduct2.DisplayIcon = true;
            this.tbproduct2.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.tbproduct2.Lines = new string[0];
            this.tbproduct2.Location = new System.Drawing.Point(28, 58);
            this.tbproduct2.MaxLength = 32767;
            this.tbproduct2.Name = "tbproduct2";
            this.tbproduct2.PasswordChar = '\0';
            this.tbproduct2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbproduct2.SelectedText = "";
            this.tbproduct2.SelectionLength = 0;
            this.tbproduct2.SelectionStart = 0;
            this.tbproduct2.ShortcutsEnabled = true;
            this.tbproduct2.Size = new System.Drawing.Size(226, 23);
            this.tbproduct2.TabIndex = 76;
            this.tbproduct2.UseCustomBackColor = true;
            this.tbproduct2.UseSelectable = true;
            this.tbproduct2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbproduct2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuMetroTextbox2
            // 
            this.bunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox2.BorderThickness = 3;
            this.bunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox2.isPassword = false;
            this.bunifuMetroTextbox2.Location = new System.Drawing.Point(23, 53);
            this.bunifuMetroTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox2.Name = "bunifuMetroTextbox2";
            this.bunifuMetroTextbox2.Size = new System.Drawing.Size(235, 32);
            this.bunifuMetroTextbox2.TabIndex = 75;
            this.bunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(24, 128);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(72, 20);
            this.bunifuCustomLabel2.TabIndex = 71;
            this.bunifuCustomLabel2.Text = "Quantity:";
            // 
            // tbqty2
            // 
            this.tbqty2.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbqty2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbqty2.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbqty2.BorderThickness = 3;
            this.tbqty2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbqty2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbqty2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbqty2.isPassword = false;
            this.tbqty2.Location = new System.Drawing.Point(23, 152);
            this.tbqty2.Margin = new System.Windows.Forms.Padding(4);
            this.tbqty2.Name = "tbqty2";
            this.tbqty2.Size = new System.Drawing.Size(235, 32);
            this.tbqty2.TabIndex = 70;
            this.tbqty2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(24, 29);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(68, 20);
            this.bunifuCustomLabel3.TabIndex = 69;
            this.bunifuCustomLabel3.Text = "Product:";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(300, 409);
            this.ControlBox = false;
            this.Controls.Add(this.tab);
            this.Controls.Add(this.lbclose);
            this.Controls.Add(this.lbtitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.tab.ResumeLayout(false);
            this.tabadd.ResumeLayout(false);
            this.tabadd.PerformLayout();
            this.tabdelete.ResumeLayout(false);
            this.tabdelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private MetroFramework.Controls.MetroTabControl tab;
        private MetroFramework.Controls.MetroTabPage tabadd;
        private MetroFramework.Controls.MetroTabPage tabdelete;
        private Bunifu.Framework.UI.BunifuCustomLabel lbclose;
        private Bunifu.Framework.UI.BunifuCustomLabel lbtitle;
        private MetroFramework.Controls.MetroTextBox tbproduct1;
        private Bunifu.Framework.UI.BunifuMetroTextbox border2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbqty;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbqty;
        private Bunifu.Framework.UI.BunifuCustomLabel lbrate;
        private Bunifu.Framework.UI.BunifuCustomLabel lbproduct2;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbrate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbqty2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private MetroFramework.Controls.MetroTextBox tbproduct2;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox2;
        private Bunifu.Framework.UI.BunifuThinButton2 btndone1;
        private Bunifu.Framework.UI.BunifuThinButton2 btndone2;
    }
}