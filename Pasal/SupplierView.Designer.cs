namespace Pasal
{
    partial class SupplierView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblist = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnadd = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnpay = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.dgsupplist = new MetroFramework.Controls.MetroGrid();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgsupplist)).BeginInit();
            this.SuspendLayout();
            // 
            // lblist
            // 
            this.lblist.AutoSize = true;
            this.lblist.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblist.Location = new System.Drawing.Point(12, 32);
            this.lblist.Name = "lblist";
            this.lblist.Size = new System.Drawing.Size(75, 17);
            this.lblist.TabIndex = 23;
            this.lblist.Text = "Supplier List:";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnadd.color = System.Drawing.Color.SeaGreen;
            this.btnadd.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.ImagePosition = 6;
            this.btnadd.ImageZoom = 55;
            this.btnadd.LabelPosition = 21;
            this.btnadd.LabelText = "Add";
            this.btnadd.Location = new System.Drawing.Point(6, 72);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(65, 60);
            this.btnadd.TabIndex = 27;
            this.btnadd.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // btnpay
            // 
            this.btnpay.BackColor = System.Drawing.Color.SeaGreen;
            this.btnpay.color = System.Drawing.Color.SeaGreen;
            this.btnpay.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnpay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpay.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpay.ForeColor = System.Drawing.Color.White;
            this.btnpay.Image = ((System.Drawing.Image)(resources.GetObject("btnpay.Image")));
            this.btnpay.ImagePosition = 6;
            this.btnpay.ImageZoom = 55;
            this.btnpay.LabelPosition = 21;
            this.btnpay.LabelText = "Payment";
            this.btnpay.Location = new System.Drawing.Point(6, 7);
            this.btnpay.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnpay.Name = "btnpay";
            this.btnpay.Size = new System.Drawing.Size(65, 60);
            this.btnpay.TabIndex = 28;
            this.btnpay.Click += new System.EventHandler(this.btnpay_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnadd);
            this.panel.Controls.Add(this.btnpay);
            this.panel.Location = new System.Drawing.Point(510, 52);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(77, 143);
            this.panel.TabIndex = 29;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 17;
            this.bunifuElipse1.TargetControl = this.panel;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(521, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // dgsupplist
            // 
            this.dgsupplist.AllowUserToAddRows = false;
            this.dgsupplist.AllowUserToDeleteRows = false;
            this.dgsupplist.AllowUserToOrderColumns = true;
            this.dgsupplist.AllowUserToResizeColumns = false;
            this.dgsupplist.AllowUserToResizeRows = false;
            this.dgsupplist.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgsupplist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgsupplist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgsupplist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgsupplist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgsupplist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgsupplist.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgsupplist.EnableHeadersVisualStyles = false;
            this.dgsupplist.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgsupplist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgsupplist.HighLightPercentage = 1F;
            this.dgsupplist.Location = new System.Drawing.Point(15, 56);
            this.dgsupplist.Name = "dgsupplist";
            this.dgsupplist.ReadOnly = true;
            this.dgsupplist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgsupplist.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgsupplist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgsupplist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgsupplist.Size = new System.Drawing.Size(556, 400);
            this.dgsupplist.TabIndex = 35;
            // 
            // SupplierView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblist);
            this.Controls.Add(this.dgsupplist);
            this.Name = "SupplierView";
            this.Size = new System.Drawing.Size(590, 471);
            this.Load += new System.EventHandler(this.SupplierView_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgsupplist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblist;
        private Bunifu.Framework.UI.BunifuTileButton btnadd;
        private Bunifu.Framework.UI.BunifuTileButton btnpay;
        private System.Windows.Forms.Panel panel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private MetroFramework.Controls.MetroGrid dgsupplist;
    }
}
