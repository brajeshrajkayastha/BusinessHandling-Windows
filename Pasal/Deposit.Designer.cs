namespace Pasal
{
    partial class Deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            this.cbacc = new MetroFramework.Controls.MetroComboBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Datepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lbqty = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbamt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbproduct2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbclose = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbtitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbdepositer = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnadd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // cbacc
            // 
            this.cbacc.FormattingEnabled = true;
            this.cbacc.ItemHeight = 23;
            this.cbacc.Location = new System.Drawing.Point(58, 107);
            this.cbacc.Name = "cbacc";
            this.cbacc.Size = new System.Drawing.Size(185, 29);
            this.cbacc.TabIndex = 58;
            this.cbacc.UseSelectable = true;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(61, 214);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(48, 20);
            this.bunifuCustomLabel6.TabIndex = 56;
            this.bunifuCustomLabel6.Text = "Date:";
            // 
            // Datepicker1
            // 
            this.Datepicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.Datepicker1.BorderRadius = 0;
            this.Datepicker1.ForeColor = System.Drawing.Color.White;
            this.Datepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Datepicker1.FormatCustom = null;
            this.Datepicker1.Location = new System.Drawing.Point(58, 237);
            this.Datepicker1.Name = "Datepicker1";
            this.Datepicker1.Size = new System.Drawing.Size(185, 29);
            this.Datepicker1.TabIndex = 55;
            this.Datepicker1.Value = new System.DateTime(2018, 3, 28, 9, 20, 44, 302);
            // 
            // lbqty
            // 
            this.lbqty.AutoSize = true;
            this.lbqty.BackColor = System.Drawing.Color.Transparent;
            this.lbqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbqty.Location = new System.Drawing.Point(61, 143);
            this.lbqty.Name = "lbqty";
            this.lbqty.Size = new System.Drawing.Size(69, 20);
            this.lbqty.TabIndex = 54;
            this.lbqty.Text = "Amount:";
            // 
            // tbamt
            // 
            this.tbamt.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbamt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbamt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbamt.BorderThickness = 3;
            this.tbamt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbamt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbamt.isPassword = false;
            this.tbamt.Location = new System.Drawing.Point(58, 167);
            this.tbamt.Margin = new System.Windows.Forms.Padding(4);
            this.tbamt.Name = "tbamt";
            this.tbamt.Size = new System.Drawing.Size(185, 32);
            this.tbamt.TabIndex = 53;
            this.tbamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbproduct2
            // 
            this.lbproduct2.AutoSize = true;
            this.lbproduct2.BackColor = System.Drawing.Color.Transparent;
            this.lbproduct2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbproduct2.Location = new System.Drawing.Point(61, 84);
            this.lbproduct2.Name = "lbproduct2";
            this.lbproduct2.Size = new System.Drawing.Size(72, 20);
            this.lbproduct2.TabIndex = 52;
            this.lbproduct2.Text = "Account:";
            // 
            // lbclose
            // 
            this.lbclose.AutoSize = true;
            this.lbclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbclose.Location = new System.Drawing.Point(250, 9);
            this.lbclose.Name = "lbclose";
            this.lbclose.Size = new System.Drawing.Size(39, 37);
            this.lbclose.TabIndex = 60;
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
            this.lbtitle.Location = new System.Drawing.Point(80, 9);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(132, 37);
            this.lbtitle.TabIndex = 59;
            this.lbtitle.Text = "Deposit";
            this.lbtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 17;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(61, 284);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(135, 20);
            this.bunifuCustomLabel1.TabIndex = 62;
            this.bunifuCustomLabel1.Text = "Depositer\'s Name";
            // 
            // tbdepositer
            // 
            this.tbdepositer.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbdepositer.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbdepositer.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbdepositer.BorderThickness = 3;
            this.tbdepositer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbdepositer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdepositer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbdepositer.isPassword = false;
            this.tbdepositer.Location = new System.Drawing.Point(58, 308);
            this.tbdepositer.Margin = new System.Windows.Forms.Padding(4);
            this.tbdepositer.Name = "tbdepositer";
            this.tbdepositer.Size = new System.Drawing.Size(185, 32);
            this.tbdepositer.TabIndex = 61;
            this.tbdepositer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnadd
            // 
            this.btnadd.ActiveBorderThickness = 5;
            this.btnadd.ActiveCornerRadius = 20;
            this.btnadd.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnadd.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnadd.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnadd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnadd.BackgroundImage")));
            this.btnadd.ButtonText = "Add";
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnadd.IdleBorderThickness = 1;
            this.btnadd.IdleCornerRadius = 20;
            this.btnadd.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnadd.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnadd.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnadd.Location = new System.Drawing.Point(87, 363);
            this.btnadd.Margin = new System.Windows.Forms.Padding(5);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(114, 41);
            this.btnadd.TabIndex = 63;
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.tbdepositer);
            this.Controls.Add(this.lbclose);
            this.Controls.Add(this.lbtitle);
            this.Controls.Add(this.cbacc);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.Datepicker1);
            this.Controls.Add(this.lbqty);
            this.Controls.Add(this.tbamt);
            this.Controls.Add(this.lbproduct2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 450);
            this.MinimizeBox = false;
            this.Name = "Deposit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Deposite";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbacc;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuDatepicker Datepicker1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbqty;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbamt;
        private Bunifu.Framework.UI.BunifuCustomLabel lbproduct2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbclose;
        private Bunifu.Framework.UI.BunifuCustomLabel lbtitle;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbdepositer;
        private Bunifu.Framework.UI.BunifuThinButton2 btnadd;
    }
}