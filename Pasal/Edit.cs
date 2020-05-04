using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasal
{
    public partial class Edit : Form
    {
        Database database = new Database();
        Validation valid = new Validation();
        Values IDvalue = new Values();
        string sql;
        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {

            tbproduct1.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbproduct1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection pauto = new AutoCompleteStringCollection();
            database.autocomplete("Product_Name", "PRODUCT", pauto);
            tbproduct1.AutoCompleteCustomSource = pauto;

            tbproduct2.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbproduct2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection pauto1 = new AutoCompleteStringCollection();
            database.autocomplete("Product_Name", "PRODUCT", pauto);
            tbproduct2.AutoCompleteCustomSource = pauto1;

            tbproduct1.Text = "";
            tbproduct2.Text = "";
            tbqty.Text = "";
            tbqty2.Text = "";
            tbrate.Text = "";

        }

        private void btndone1_Click(object sender, EventArgs e)
        {
            int productID;
            productID = IDvalue.product(tbproduct1.Text);
            if (productID != 0)
            {
                if (valid.number(tbrate.Text) == true && valid.number(tbqty.Text) == true)
                {
                    DataTable data = new DataTable();
                    sql="SELECT [Quantity] FROM [STOCK] WHERE [Product]="+productID+"";
                    database.load(sql, data);

                    if (data.Rows.Count == 1)
                    {

                        sql = "UPDATE STOCK SET [Quantity] = [Quantity] + "+tbqty.Text+" WHERE Product=" + productID + "";
                        database.update(sql);

                        MessageBox.Show("Succesfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else { 
                        sql="INSERT INTO STOCK ([Product],[Quantity]) VALUES ("+productID+","+tbqty.Text+")";
                        database.update(sql);

                        MessageBox.Show("Succesfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        tbproduct1.Text = "";
                        tbqty.Text = "";
                        tbrate.Text = "";
                    }
                }
                else {
                    MessageBox.Show("Invalid Rate or Quantity input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbqty.Text = "";
                    tbrate.Text = "";
                }
            }
            else {

                MessageBox.Show("Product Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbproduct1.Text = "";
                tbqty.Text = "";
                tbrate.Text = "";
            }
        }

        private void btndone2_Click(object sender, EventArgs e)
        {
            int productID;
            productID = IDvalue.product(tbproduct1.Text);
            if (productID != 0)
            {
                if (valid.number(tbqty2.Text) == true)
                {
                    sql = "UPDATE STOCK SET [Quantity] = [Quantity] - " + tbqty2.Text + " WHERE Product=" + productID + "";
                    database.update(sql);

                    MessageBox.Show("Succesfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tbproduct2.Text = "";
                    tbqty2.Text = "";
                }
                else {
                    MessageBox.Show("Stock Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbproduct2.Text = "";
                    tbqty2.Text = "";
                }
            }
            else {
                MessageBox.Show("Product Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbproduct2.Text = "";
                tbqty2.Text = "";
            }
        }

        private void lbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbclose_MouseHover(object sender, EventArgs e)
        {
            lbclose.ForeColor = System.Drawing.Color.Crimson;
        }

        private void lbclose_MouseLeave(object sender, EventArgs e)
        {
            lbclose.ForeColor = System.Drawing.Color.Black;
        }

    }
}
