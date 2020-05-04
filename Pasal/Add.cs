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
    public partial class Add : Form
    {
        Database database = new Database();
        Validation valid = new Validation();
        string sql;
        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            tbaddr4ess.Text = "";
            tbcompany.Text = "";
            tbcontact.Text = "";
            tbname.Text = "";
            tbbalance.Text = "";
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

        private void btndone_Click(object sender, EventArgs e)
        {
            if (valid.name(tbname.Text) == true && valid.number(tbcontact.Text) == true && valid.name(tbaddr4ess.Text) == true && valid.name(tbcompany.Text) == true && valid.number(tbbalance.Text)==true)
            {
                sql = "INSERT INTO [SUPPLIER] ([Supplier_Name],[Address],[Contact],[Company],[Balance]) VALUES ('" + tbname.Text + "','" + tbaddr4ess.Text + "'," + tbcontact.Text + ",'" + tbcompany.Text + "',"+tbbalance.Text+")";
                database.update(sql);

                MessageBox.Show("Succesfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbaddr4ess.Text = "";
                tbcompany.Text = "";
                tbcontact.Text = "";
                tbname.Text = "";
                tbbalance.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid Input datas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbaddr4ess.Text = "";
                tbcompany.Text = "";
                tbcontact.Text = "";
                tbname.Text="";
                tbbalance.Text = "";
            }
        }

    }
}

