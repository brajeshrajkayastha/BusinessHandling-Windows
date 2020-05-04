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
    public partial class Deposit : Form
    {
        Database database = new Database();
        Values IDvalue = new Values();
        Validation valid = new Validation();
        string sql;
        public Deposit()
        {
            InitializeComponent();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            database.combobox("Account_Name","Bank_Acc","",cbacc);
            tbamt.Text = "";
            tbdepositer.Text = "";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int accid;
            accid = IDvalue.account(cbacc.Text);
            if (valid.name(tbdepositer.Text) == true && valid.number(tbamt.Text) == true)
            {
                sql = "INSERT INTO [Bank_Trans] ([Account],[Trans_Type],[Date],[Amount],[Depositer's_Name]) VALUES (" + accid + ",'" + "Deposit" + "','" + Datepicker1.Value.ToShortDateString() + "'," + tbamt.Text + ",'" + tbdepositer.Text + "')";
                database.update(sql);

                tbamt.Text = "";
                tbdepositer.Text = "";
                cbacc.Text = "";

                MessageBox.Show("Successfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Invalid Depositer's Name or Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbamt.Text = "";
                tbdepositer.Text = "";
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
