namespace Pasal
{
    partial class StockView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnsearch = new Bunifu.Framework.UI.BunifuThinButton2();
            this.border = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnEdit = new Bunifu.Framework.UI.BunifuTileButton();
            this.tbproduct = new MetroFramework.Controls.MetroTextBox();
            this.dgstock = new MetroFramework.Controls.MetroGrid();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgstock)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(17, 17);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(205, 16);
            this.lb1.TabIndex = 22;
            this.lb1.Text = "Specific Search For Product:";
            // 
            // btnsearch
            // 
            this.btnsearch.ActiveBorderThickness = 5;
            this.btnsearch.ActiveCornerRadius = 20;
            this.btnsearch.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnsearch.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnsearch.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnsearch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnsearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsearch.BackgroundImage")));
            this.btnsearch.ButtonText = "Search";
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnsearch.IdleBorderThickness = 1;
            this.btnsearch.IdleCornerRadius = 20;
            this.btnsearch.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnsearch.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnsearch.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnsearch.Location = new System.Drawing.Point(385, 40);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(114, 41);
            this.btnsearch.TabIndex = 21;
            this.btnsearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // border
            // 
            this.border.BorderColorFocused = System.Drawing.Color.Blue;
            this.border.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.border.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.border.BorderThickness = 3;
            this.border.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.border.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.border.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.border.isPassword = false;
            this.border.Location = new System.Drawing.Point(6, 38);
            this.border.Margin = new System.Windows.Forms.Padding(4);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(370, 44);
            this.border.TabIndex = 20;
            this.border.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.color = System.Drawing.Color.SeaGreen;
            this.btnEdit.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImagePosition = 8;
            this.btnEdit.ImageZoom = 35;
            this.btnEdit.LabelPosition = 29;
            this.btnEdit.LabelText = "Edit";
            this.btnEdit.Location = new System.Drawing.Point(519, 30);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(65, 60);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbproduct
            // 
            this.tbproduct.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.tbproduct.CustomButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbproduct.CustomButton.Image = global::Pasal.Properties.Resources.Forrst_50px;
            this.tbproduct.CustomButton.Location = new System.Drawing.Point(327, 1);
            this.tbproduct.CustomButton.Name = "";
            this.tbproduct.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.tbproduct.CustomButton.Style = MetroFramework.MetroColorStyle.Teal;
            this.tbproduct.CustomButton.TabIndex = 1;
            this.tbproduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbproduct.CustomButton.UseSelectable = true;
            this.tbproduct.CustomButton.UseVisualStyleBackColor = false;
            this.tbproduct.CustomButton.Visible = false;
            this.tbproduct.DisplayIcon = true;
            this.tbproduct.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.tbproduct.Lines = new string[0];
            this.tbproduct.Location = new System.Drawing.Point(11, 43);
            this.tbproduct.MaxLength = 32767;
            this.tbproduct.Name = "tbproduct";
            this.tbproduct.PasswordChar = '\0';
            this.tbproduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbproduct.SelectedText = "";
            this.tbproduct.SelectionLength = 0;
            this.tbproduct.SelectionStart = 0;
            this.tbproduct.ShortcutsEnabled = true;
            this.tbproduct.Size = new System.Drawing.Size(361, 35);
            this.tbproduct.TabIndex = 56;
            this.tbproduct.UseCustomBackColor = true;
            this.tbproduct.UseSelectable = true;
            this.tbproduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbproduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dgstock
            // 
            this.dgstock.AllowUserToAddRows = false;
            this.dgstock.AllowUserToDeleteRows = false;
            this.dgstock.AllowUserToResizeColumns = false;
            this.dgstock.AllowUserToResizeRows = false;
            this.dgstock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgstock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgstock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgstock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgstock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgstock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgstock.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgstock.EnableHeadersVisualStyles = false;
            this.dgstock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgstock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgstock.HighLightPercentage = 1F;
            this.dgstock.Location = new System.Drawing.Point(11, 100);
            this.dgstock.Name = "dgstock";
            this.dgstock.ReadOnly = true;
            this.dgstock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgstock.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgstock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgstock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgstock.Size = new System.Drawing.Size(569, 352);
            this.dgstock.TabIndex = 57;
            // 
            // PName
            // 
            this.PName.HeaderText = "P.Name";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            // 
            // StockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.dgstock);
            this.Controls.Add(this.tbproduct);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.border);
            this.Name = "StockView";
            this.Size = new System.Drawing.Size(590, 471);
            this.Load += new System.EventHandler(this.StockView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgstock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lb1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnsearch;
        private Bunifu.Framework.UI.BunifuMetroTextbox border;
        private Bunifu.Framework.UI.BunifuTileButton btnEdit;
        private MetroFramework.Controls.MetroTextBox tbproduct;
        private MetroFramework.Controls.MetroGrid dgstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;

    }
}
