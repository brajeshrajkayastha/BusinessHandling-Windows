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
    public partial class Cheque : Form
    {
        Database database = new Database();
        Values IDvalue = new Values();
        string sql;


        public Cheque()
        {
            InitializeComponent();
        }

        private void lbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbclose_MouseHover(object sender, EventArgs e)
        {
            lbclose.ForeColor = System.Drawing.Color.Crimson;
        }

        private void lbclose_Leave(object sender, EventArgs e)
        {
            lbclose.ForeColor = System.Drawing.Color.Black;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            int accid;
            accid=IDvalue.account(cbacc.Text);
            DataTable data = new DataTable();
            sql = "SELECT [Cheque_No],[Supplier],[Date],[Amount] FROM CHEQUE WHERE Account="+accid+"";
            database.load(sql, data);
            dgchqlist.DataSource = data;

        }

        private void Cheque_Load(object sender, EventArgs e)
        {
            database.combobox("Account_Name","Bank_Acc","",cbacc);

            dgchqlist.DataSource = null; 
        }



    }
}
