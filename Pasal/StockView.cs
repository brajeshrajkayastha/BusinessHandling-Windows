using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasal
{
    public partial class StockView : UserControl
    {

        Database database = new Database();
        string sql;

        public StockView()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.Show();
        }

        public void StockView_Load(object sender, EventArgs e)
        {
            tbproduct.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbproduct.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection pauto = new AutoCompleteStringCollection();
            database.autocomplete("Product_Name", "PRODUCT", pauto);
            tbproduct.AutoCompleteCustomSource = pauto;
  
            DataTable data = new DataTable();
            sql = "SELECT * FROM STOCK";
            database.load(sql, data);
            dgstock.DataSource = data;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            int productID;
            DataTable data1 = new DataTable();
            Values Idvalue= new Values();
            productID = Idvalue.product(tbproduct.Text);

            if (productID != 0)
            {
                sql = "SELECT * FROM STOCK WHERE Product=" + productID + "";
                database.load(sql, data1);
                dgstock.DataSource = data1;

                for (int i = 0; i < data1.Rows.Count; i++) {
                    string a;
                    a = data1.Rows[i][1].ToString();
                    DataTable data2 = new DataTable();
                    sql="SELECT [Product_Name] FROM PRODUCT WHERE ID="+a+"";
                    database.load(sql, data2);

                    PName.DataGridView.DataSource = data2.Rows[i][0].ToString();
                }      
            }
            else {
                MessageBox.Show("Product Not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbproduct.Text = "";
            }
        }

    }
}
