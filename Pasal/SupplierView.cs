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
    public partial class SupplierView : UserControl
    {
        string sql;
        Database database = new Database();
        public SupplierView()

        {
            InitializeComponent();

        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            Pay pay = new Pay();
            pay.Show();
        }

        public void SupplierView_Load(object sender, EventArgs e)
        {
            panel.Height = 0;

            DataTable data = new DataTable();
            sql = "SELECT * FROM SUPPLIER";
            database.load(sql, data);
            dgsupplist.DataSource = data;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (panel.Height==0)
            {
                timer1.Start();
            }
            else {
                timer2.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel.Height < 143)
            {
                panel.Height += 25;
            }
            else {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (panel.Height > 0)
            {
                panel.Height -= 25;
            }
            else
            {
                timer2.Stop();
            }
        }
    }
}
