namespace Pasal
{
    partial class Pay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay));
            this.lbvendor = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbdate2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbrate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbamt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbpayment = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbtitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbchq = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbchqno = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbacc = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbclose = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btndone = new Bunifu.Framework.UI.BunifuThinButton2();
            this.border = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Datepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.cbpayment = new MetroFramework.Controls.MetroComboBox();
            this.cbacc = new MetroFramework.Controls.MetroComboBox();
            this.tbsupp = new MetroFramework.Controls.MetroTextBox();
            this.lbrecieptno = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbrecieptno = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbvendor
            // 
            this.lbvendor.AutoSize = true;
            this.lbvendor.BackColor = System.Drawing.Color.Transparent;
            this.lbvendor.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvendor.Location = new System.Drawing.Point(60, 108);
            this.lbvendor.Name = "lbvendor";
            this.lbvendor.Size = new System.Drawing.Size(65, 20);
            this.lbvendor.TabIndex = 25;
            this.lbvendor.Text = "Supplier:";
            // 
            // lbdate2
            // 
            this.lbdate2.AutoSize = true;
            this.lbdate2.BackColor = System.Drawing.Color.Transparent;
            this.lbdate2.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdate2.Location = new System.Drawing.Point(61, 52);
            this.lbdate2.Name = "lbdate2";
            this.lbdate2.Size = new System.Drawing.Size(42, 20);
            this.lbdate2.TabIndex = 23;
            this.lbdate2.Text = "Date:";
            // 
            // lbrate
            // 
            this.lbrate.AutoSize = true;
            this.lbrate.BackColor = System.Drawing.Color.Transparent;
            this.lbrate.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrate.Location = new System.Drawing.Point(60, 166);
            this.lbrate.Name = "lbrate";
            this.lbrate.Size = new System.Drawing.Size(63, 20);
            this.lbrate.TabIndex = 22;
            this.lbrate.Text = "Amount:";
            // 
            // tbamt
            // 
            this.tbamt.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbamt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbamt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbamt.BorderThickness = 3;
            this.tbamt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbamt.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbamt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbamt.isPassword = false;
            this.tbamt.Location = new System.Drawing.Point(57, 185);
            this.tbamt.Margin = new System.Windows.Forms.Padding(4);
            this.tbamt.Name = "tbamt";
            this.tbamt.Size = new System.Drawing.Size(186, 32);
            this.tbamt.TabIndex = 20;
            this.tbamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbpayment
            // 
            this.lbpayment.AutoSize = true;
            this.lbpayment.BackColor = System.Drawing.Color.Transparent;
            this.lbpayment.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpayment.Location = new System.Drawing.Point(59, 278);
            this.lbpayment.Name = "lbpayment";
            this.lbpayment.Size = new System.Drawing.Size(103, 20);
            this.lbpayment.TabIndex = 27;
            this.lbpayment.Text = "Payment Type:";
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitle.Location = new System.Drawing.Point(83, 3);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(129, 39);
            this.lbtitle.TabIndex = 28;
            this.lbtitle.Text = "Payment";
            this.lbtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbchq
            // 
            this.lbchq.AutoSize = true;
            this.lbchq.BackColor = System.Drawing.Color.Transparent;
            this.lbchq.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbchq.Location = new System.Drawing.Point(61, 278);
            this.lbchq.Name = "lbchq";
            this.lbchq.Size = new System.Drawing.Size(82, 20);
            this.lbchq.TabIndex = 30;
            this.lbchq.Text = "Cheque No:";
            // 
            // tbchqno
            // 
            this.tbchqno.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbchqno.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbchqno.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbchqno.BorderThickness = 3;
            this.tbchqno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbchqno.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbchqno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbchqno.isPassword = false;
            this.tbchqno.Location = new System.Drawing.Point(60, 298);
            this.tbchqno.Margin = new System.Windows.Forms.Padding(4);
            this.tbchqno.Name = "tbchqno";
            this.tbchqno.Size = new System.Drawing.Size(183, 32);
            this.tbchqno.TabIndex = 29;
            this.tbchqno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbacc
            // 
            this.lbacc.AutoSize = true;
            this.lbacc.BackColor = System.Drawing.Color.Transparent;
            this.lbacc.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbacc.Location = new System.Drawing.Point(61, 278);
            this.lbacc.Name = "lbacc";
            this.lbacc.Size = new System.Drawing.Size(65, 20);
            this.lbacc.TabIndex = 32;
            this.lbacc.Text = "Account:";
            // 
            // lbclose
            // 
            this.lbclose.AutoSize = true;
            this.lbclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbclose.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbclose.Location = new System.Drawing.Point(262, 3);
            this.lbclose.Name = "lbclose";
            this.lbclose.Size = new System.Drawing.Size(35, 39);
            this.lbclose.TabIndex = 33;
            this.lbclose.Text = "X";
            this.lbclose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbclose.Click += new System.EventHandler(this.lbclose_Click);
            this.lbclose.MouseLeave += new System.EventHandler(this.lbclose_MouseLeave);
            this.lbclose.MouseHover += new System.EventHandler(this.lbclose_MouseHover);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 17;
            this.bunifuElipse1.TargetControl = this;
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
            this.btndone.Location = new System.Drawing.Point(61, 350);
            this.btndone.Margin = new System.Windows.Forms.Padding(5);
            this.btndone.Name = "btndone";
            this.btndone.Size = new System.Drawing.Size(181, 40);
            this.btndone.TabIndex = 34;
            this.btndone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndone.Click += new System.EventHandler(this.btndone_Click);
            // 
            // border
            // 
            this.border.BorderColorFocused = System.Drawing.Color.Blue;
            this.border.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.border.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.border.BorderThickness = 3;
            this.border.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.border.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.border.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.border.isPassword = false;
            this.border.Location = new System.Drawing.Point(57, 130);
            this.border.Margin = new System.Windows.Forms.Padding(4);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(185, 32);
            this.border.TabIndex = 35;
            this.border.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Datepicker1
            // 
            this.Datepicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.Datepicker1.BorderRadius = 0;
            this.Datepicker1.ForeColor = System.Drawing.Color.White;
            this.Datepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Datepicker1.FormatCustom = null;
            this.Datepicker1.Location = new System.Drawing.Point(58, 75);
            this.Datepicker1.Name = "Datepicker1";
            this.Datepicker1.Size = new System.Drawing.Size(185, 30);
            this.Datepicker1.TabIndex = 21;
            this.Datepicker1.Value = new System.DateTime(2018, 3, 26, 1, 28, 34, 73);
            // 
            // cbpayment
            // 
            this.cbpayment.FormattingEnabled = true;
            this.cbpayment.ItemHeight = 23;
            this.cbpayment.Items.AddRange(new object[] {
            "Cash",
            "Cheque",
            "Transfer"});
            this.cbpayment.Location = new System.Drawing.Point(60, 299);
            this.cbpayment.Name = "cbpayment";
            this.cbpayment.Size = new System.Drawing.Size(182, 29);
            this.cbpayment.TabIndex = 52;
            this.cbpayment.UseSelectable = true;
            this.cbpayment.TextChanged += new System.EventHandler(this.cbpayment_TextChanged);
            // 
            // cbacc
            // 
            this.cbacc.FormattingEnabled = true;
            this.cbacc.ItemHeight = 23;
            this.cbacc.Location = new System.Drawing.Point(60, 298);
            this.cbacc.Name = "cbacc";
            this.cbacc.Size = new System.Drawing.Size(183, 29);
            this.cbacc.TabIndex = 53;
            this.cbacc.UseSelectable = true;
            // 
            // tbsupp
            // 
            this.tbsupp.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.tbsupp.CustomButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbsupp.CustomButton.Image = global::Pasal.Properties.Resources.Forrst_50px;
            this.tbsupp.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.tbsupp.CustomButton.Name = "";
            this.tbsupp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbsupp.CustomButton.Style = MetroFramework.MetroColorStyle.Teal;
            this.tbsupp.CustomButton.TabIndex = 1;
            this.tbsupp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbsupp.CustomButton.UseSelectable = true;
            this.tbsupp.CustomButton.UseVisualStyleBackColor = false;
            this.tbsupp.CustomButton.Visible = false;
            this.tbsupp.DisplayIcon = true;
            this.tbsupp.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.tbsupp.Lines = new string[0];
            this.tbsupp.Location = new System.Drawing.Point(62, 135);
            this.tbsupp.MaxLength = 32767;
            this.tbsupp.Name = "tbsupp";
            this.tbsupp.PasswordChar = '\0';
            this.tbsupp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbsupp.SelectedText = "";
            this.tbsupp.SelectionLength = 0;
            this.tbsupp.SelectionStart = 0;
            this.tbsupp.ShortcutsEnabled = true;
            this.tbsupp.Size = new System.Drawing.Size(177, 23);
            this.tbsupp.TabIndex = 54;
            this.tbsupp.UseCustomBackColor = true;
            this.tbsupp.UseSelectable = true;
            this.tbsupp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbsupp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lbrecieptno
            // 
            this.lbrecieptno.AutoSize = true;
            this.lbrecieptno.BackColor = System.Drawing.Color.Transparent;
            this.lbrecieptno.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrecieptno.Location = new System.Drawing.Point(61, 222);
            this.lbrecieptno.Name = "lbrecieptno";
            this.lbrecieptno.Size = new System.Drawing.Size(81, 20);
            this.lbrecieptno.TabIndex = 56;
            this.lbrecieptno.Text = "Reciept No:";
            // 
            // tbrecieptno
            // 
            this.tbrecieptno.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbrecieptno.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbrecieptno.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbrecieptno.BorderThickness = 3;
            this.tbrecieptno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbrecieptno.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbrecieptno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbrecieptno.isPassword = false;
            this.tbrecieptno.Location = new System.Drawing.Point(58, 241);
            this.tbrecieptno.Margin = new System.Windows.Forms.Padding(4);
            this.tbrecieptno.Name = "tbrecieptno";
            this.tbrecieptno.Size = new System.Drawing.Size(185, 32);
            this.tbrecieptno.TabIndex = 55;
            this.tbrecieptno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(300, 398);
            this.ControlBox = false;
            this.Controls.Add(this.tbchqno);
            this.Controls.Add(this.lbdate2);
            this.Controls.Add(this.lbrecieptno);
            this.Controls.Add(this.tbrecieptno);
            this.Controls.Add(this.tbsupp);
            this.Controls.Add(this.cbpayment);
            this.Controls.Add(this.border);
            this.Controls.Add(this.btndone);
            this.Controls.Add(this.lbclose);
            this.Controls.Add(this.lbtitle);
            this.Controls.Add(this.lbvendor);
            this.Controls.Add(this.lbrate);
            this.Controls.Add(this.tbamt);
            this.Controls.Add(this.Datepicker1);
            this.Controls.Add(this.lbchq);
            this.Controls.Add(this.lbacc);
            this.Controls.Add(this.lbpayment);
            this.Controls.Add(this.cbacc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Pay";
            this.Load += new System.EventHandler(this.Pay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lbvendor;
        private Bunifu.Framework.UI.BunifuCustomLabel lbdate2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbrate;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbamt;
        private Bunifu.Framework.UI.BunifuCustomLabel lbpayment;
        private Bunifu.Framework.UI.BunifuCustomLabel lbtitle;
        private Bunifu.Framework.UI.BunifuCustomLabel lbchq;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbchqno;
        private Bunifu.Framework.UI.BunifuCustomLabel lbacc;
        private Bunifu.Framework.UI.BunifuCustomLabel lbclose;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btndone;
        private Bunifu.Framework.UI.BunifuMetroTextbox border;
        private MetroFramework.Controls.MetroComboBox cbacc;
        private MetroFramework.Controls.MetroComboBox cbpayment;
        private Bunifu.Framework.UI.BunifuDatepicker Datepicker1;
        private MetroFramework.Controls.MetroTextBox tbsupp;
        private Bunifu.Framework.UI.BunifuCustomLabel lbrecieptno;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbrecieptno;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;

    }
}