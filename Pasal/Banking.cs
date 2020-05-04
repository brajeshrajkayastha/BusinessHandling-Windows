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
    public partial class Banking : UserControl
    {
        Database database = new Database();
        Validation valid = new Validation();
        string sql;
        public Banking()
        {
            InitializeComponent();
        }

        public void Banking_Load(object sender, EventArgs e)
        {
            DataTable data= new DataTable();
            sql = "SELECT * FROM Bank_Acc";
            database.load(sql, data);
            dgacclist.DataSource = data;

            tbaccname.Text = "";
            tbaccno.Text = "";
            tbbank.Text = "";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (valid.name(tbaccname.Text) == true && valid.number(tbaccno.Text) == true && valid.name(tbbank.Text) == true)
            {
                sql = "INSERT INTO [Bank_Acc] ([Account_Name],[Account_No],[Bank]) VALUES ('" + tbaccname.Text + "'," + tbaccno.Text + ",'" + tbbank.Text + "')";
                database.update(sql);

                MessageBox.Show("Successfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbbank.Text = "";
                tbaccno.Text = "";
                tbaccname.Text = "";
            }
            else {
                MessageBox.Show("Invalid Input data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbbank.Text = "";
                tbaccno.Text = "";
                tbaccname.Text = "";
            }

        }

        private void btndeposite_Click(object sender, EventArgs e)
        {
            Deposit frm = new Deposit();
            frm.Show();
        }

        private void btnchq_Click(object sender, EventArgs e)
        {
            Cheque chq = new Cheque();
            chq.Show();

        }
    }
}
