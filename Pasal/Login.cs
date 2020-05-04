using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Pasal
{
    public partial class Login : Form{
        Main Main = new Main();
        Database database = new Database();
        DataTable data = new DataTable();
        string sql;
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            sql="SELECT Username FROM ACCOUNT WHERE Username='"+tbuser.Text+"'AND Password='"+tbpass.Text+"'";
            database.load(sql, data);

                if (data.Rows.Count == 1)
                {
                    Main.User = data.Rows[0][0].ToString();
                    this.Hide();
                    Main.Show();
                }
                else
                {

                    lbuser.Text = "Invalid Username!";
                    lbpass.Text = "Invalid Password!";
                    lbuser.ForeColor = System.Drawing.Color.Crimson;
                    lbpass.ForeColor = System.Drawing.Color.Crimson;
                    tbpass.Text = "";

                }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void linkfpass_Click(object sender, EventArgs e)
        {
            Forgotpassword fpass = new Forgotpassword();
            fpass.Show();
        }


        private void tbuser_MouseLeave(object sender, EventArgs e)
        {
            if (tbuser.Text == "")
            {
                lbuser.Location = new System.Drawing.Point(63, 235);

            }
        }
        private void tbuser_MouseDown(object sender, MouseEventArgs e)
        {
            lbuser.Location = new System.Drawing.Point(63, 198);
        }
        private void tbpass_MouseDown(object sender, MouseEventArgs e)
        {
            lbpass.Location = new System.Drawing.Point(63,286);
        }
        private void tbpass_MouseLeave(object sender, EventArgs e)
        {
            if (tbpass.Text == "")
            {
                lbpass.Location = new System.Drawing.Point(63, 324);
            }
        }
        private void tbpass_Enter(object sender, EventArgs e)
        {
            lbpass.Location = new System.Drawing.Point(63, 286);
        }
        private void tbuser_Enter(object sender, EventArgs e)
        {
            lbuser.Location = new System.Drawing.Point(63, 198);
        }











    }
}
