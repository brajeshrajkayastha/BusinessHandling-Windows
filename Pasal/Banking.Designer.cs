namespace Pasal
{
    partial class Banking
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Banking));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbvendorlist = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnchq = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgacclist = new MetroFramework.Controls.MetroGrid();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbbank = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbaccno = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbrate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbaccname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbtitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnadd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btndeposite = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgacclist)).BeginInit();
            this.SuspendLayout();
            // 
            // lbvendorlist
            // 
            this.lbvendorlist.AutoSize = true;
            this.lbvendorlist.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvendorlist.Location = new System.Drawing.Point(30, 210);
            this.lbvendorlist.Name = "lbvendorlist";
            this.lbvendorlist.Size = new System.Drawing.Size(76, 17);
            this.lbvendorlist.TabIndex = 32;
            this.lbvendorlist.Text = "Account List:";
            // 
            // btnchq
            // 
            this.btnchq.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnchq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnchq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnchq.BorderRadius = 0;
            this.btnchq.ButtonText = "Cheque";
            this.btnchq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnchq.DisabledColor = System.Drawing.Color.Gray;
            this.btnchq.Iconcolor = System.Drawing.Color.Transparent;
            this.btnchq.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnchq.Iconimage")));
            this.btnchq.Iconimage_right = null;
            this.btnchq.Iconimage_right_Selected = null;
            this.btnchq.Iconimage_Selected = null;
            this.btnchq.IconMarginLeft = 0;
            this.btnchq.IconMarginRight = 0;
            this.btnchq.IconRightVisible = true;
            this.btnchq.IconRightZoom = 0D;
            this.btnchq.IconVisible = true;
            this.btnchq.IconZoom = 80D;
            this.btnchq.IsTab = false;
            this.btnchq.Location = new System.Drawing.Point(476, 425);
            this.btnchq.Name = "btnchq";
            this.btnchq.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnchq.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnchq.OnHoverTextColor = System.Drawing.Color.White;
            this.btnchq.selected = false;
            this.btnchq.Size = new System.Drawing.Size(98, 32);
            this.btnchq.TabIndex = 35;
            this.btnchq.Text = "Cheque";
            this.btnchq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnchq.Textcolor = System.Drawing.Color.White;
            this.btnchq.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchq.Click += new System.EventHandler(this.btnchq_Click);
            // 
            // dgacclist
            // 
            this.dgacclist.AllowUserToAddRows = false;
            this.dgacclist.AllowUserToDeleteRows = false;
            this.dgacclist.AllowUserToResizeColumns = false;
            this.dgacclist.AllowUserToResizeRows = false;
            this.dgacclist.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgacclist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgacclist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgacclist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgacclist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgacclist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgacclist.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgacclist.EnableHeadersVisualStyles = false;
            this.dgacclist.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgacclist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgacclist.HighLightPercentage = 1F;
            this.dgacclist.Location = new System.Drawing.Point(26, 233);
            this.dgacclist.Name = "dgacclist";
            this.dgacclist.ReadOnly = true;
            this.dgacclist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgacclist.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgacclist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgacclist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgacclist.Size = new System.Drawing.Size(548, 175);
            this.dgacclist.TabIndex = 38;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(29, 132);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(111, 20);
            this.bunifuCustomLabel3.TabIndex = 50;
            this.bunifuCustomLabel3.Text = "Account\'s Bank:";
            // 
            // tbbank
            // 
            this.tbbank.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbbank.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbbank.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbbank.BorderThickness = 3;
            this.tbbank.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbbank.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbbank.isPassword = false;
            this.tbbank.Location = new System.Drawing.Point(26, 151);
            this.tbbank.Margin = new System.Windows.Forms.Padding(4);
            this.tbbank.Name = "tbbank";
            this.tbbank.Size = new System.Drawing.Size(263, 32);
            this.tbbank.TabIndex = 49;
            this.tbbank.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(343, 68);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(87, 20);
            this.bunifuCustomLabel1.TabIndex = 48;
            this.bunifuCustomLabel1.Text = "Account No:";
            // 
            // tbaccno
            // 
            this.tbaccno.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbaccno.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbaccno.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbaccno.BorderThickness = 3;
            this.tbaccno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbaccno.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbaccno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbaccno.isPassword = false;
            this.tbaccno.Location = new System.Drawing.Point(332, 87);
            this.tbaccno.Margin = new System.Windows.Forms.Padding(4);
            this.tbaccno.Name = "tbaccno";
            this.tbaccno.Size = new System.Drawing.Size(242, 32);
            this.tbaccno.TabIndex = 47;
            this.tbaccno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbrate
            // 
            this.lbrate.AutoSize = true;
            this.lbrate.BackColor = System.Drawing.Color.Transparent;
            this.lbrate.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrate.Location = new System.Drawing.Point(29, 68);
            this.lbrate.Name = "lbrate";
            this.lbrate.Size = new System.Drawing.Size(162, 20);
            this.lbrate.TabIndex = 46;
            this.lbrate.Text = "Account Holder\'s Name:";
            // 
            // tbaccname
            // 
            this.tbaccname.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbaccname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbaccname.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbaccname.BorderThickness = 3;
            this.tbaccname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbaccname.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbaccname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbaccname.isPassword = false;
            this.tbaccname.Location = new System.Drawing.Point(26, 87);
            this.tbaccname.Margin = new System.Windows.Forms.Padding(4);
            this.tbaccname.Name = "tbaccname";
            this.tbaccname.Size = new System.Drawing.Size(263, 32);
            this.tbaccname.TabIndex = 45;
            this.tbaccname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitle.Location = new System.Drawing.Point(19, 12);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(186, 39);
            this.lbtitle.TabIndex = 44;
            this.lbtitle.Text = "New Account";
            this.lbtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnadd
            // 
            this.btnadd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnadd.BorderRadius = 0;
            this.btnadd.ButtonText = "Add";
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.DisabledColor = System.Drawing.Color.Gray;
            this.btnadd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnadd.Iconimage = null;
            this.btnadd.Iconimage_right = null;
            this.btnadd.Iconimage_right_Selected = null;
            this.btnadd.Iconimage_Selected = null;
            this.btnadd.IconMarginLeft = 0;
            this.btnadd.IconMarginRight = 0;
            this.btnadd.IconRightVisible = true;
            this.btnadd.IconRightZoom = 0D;
            this.btnadd.IconVisible = true;
            this.btnadd.IconZoom = 80D;
            this.btnadd.IsTab = false;
            this.btnadd.Location = new System.Drawing.Point(476, 151);
            this.btnadd.Name = "btnadd";
            this.btnadd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnadd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnadd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnadd.selected = false;
            this.btnadd.Size = new System.Drawing.Size(98, 32);
            this.btnadd.TabIndex = 51;
            this.btnadd.Text = "Add";
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnadd.Textcolor = System.Drawing.Color.White;
            this.btnadd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndeposite
            // 
            this.btndeposite.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btndeposite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btndeposite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndeposite.BorderRadius = 0;
            this.btndeposite.ButtonText = "Deposit";
            this.btndeposite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndeposite.DisabledColor = System.Drawing.Color.Gray;
            this.btndeposite.Iconcolor = System.Drawing.Color.Transparent;
            this.btndeposite.Iconimage = ((System.Drawing.Image)(resources.GetObject("btndeposite.Iconimage")));
            this.btndeposite.Iconimage_right = null;
            this.btndeposite.Iconimage_right_Selected = null;
            this.btndeposite.Iconimage_Selected = null;
            this.btndeposite.IconMarginLeft = 0;
            this.btndeposite.IconMarginRight = 0;
            this.btndeposite.IconRightVisible = true;
            this.btndeposite.IconRightZoom = 0D;
            this.btndeposite.IconVisible = true;
            this.btndeposite.IconZoom = 80D;
            this.btndeposite.IsTab = false;
            this.btndeposite.Location = new System.Drawing.Point(347, 425);
            this.btndeposite.Name = "btndeposite";
            this.btndeposite.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btndeposite.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btndeposite.OnHoverTextColor = System.Drawing.Color.White;
            this.btndeposite.selected = false;
            this.btndeposite.Size = new System.Drawing.Size(98, 32);
            this.btndeposite.TabIndex = 52;
            this.btndeposite.Text = "Deposit";
            this.btndeposite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndeposite.Textcolor = System.Drawing.Color.White;
            this.btndeposite.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeposite.Click += new System.EventHandler(this.btndeposite_Click);
            // 
            // Banking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.btndeposite);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.tbbank);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.tbaccno);
            this.Controls.Add(this.lbrate);
            this.Controls.Add(this.tbaccname);
            this.Controls.Add(this.lbtitle);
            this.Controls.Add(this.dgacclist);
            this.Controls.Add(this.btnchq);
            this.Controls.Add(this.lbvendorlist);
            this.Name = "Banking";
            this.Size = new System.Drawing.Size(590, 471);
            this.Load += new System.EventHandler(this.Banking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgacclist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lbvendorlist;
        private Bunifu.Framework.UI.BunifuFlatButton btnchq;
        private MetroFramework.Controls.MetroGrid dgacclist;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbbank;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbaccno;
        private Bunifu.Framework.UI.BunifuCustomLabel lbrate;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbaccname;
        private Bunifu.Framework.UI.BunifuCustomLabel lbtitle;
        private Bunifu.Framework.UI.BunifuFlatButton btnadd;
        private Bunifu.Framework.UI.BunifuFlatButton btndeposite;
    }
}
