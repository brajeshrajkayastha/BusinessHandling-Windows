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
    public partial class Forgotpassword : Form
    {
        Database database = new Database();
        string sql = "";

        public Forgotpassword()
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

        private void lbclose_MouseLeave(object sender, EventArgs e)
        {
            lbclose.ForeColor = System.Drawing.Color.Black;
        }

        private void Forgotpassword_Load(object sender, EventArgs e)
        {
            tbnewpass.Text = "";
            tbnewpassc.Text = "";
            tbpincode.Text = "";
            tbuser.Text = "";

            tbnewpass.Enabled = false;
            tbnewpassc.Enabled = false;
            btndone.Enabled = false;
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            sql = "SELECT ID FROM ACCOUNT WHERE [Username]='"+tbuser.Text+"' AND Pin="+tbpincode.Text+"";
            database.load(sql,data);

            if(data.Rows.Count == 1){
                MessageBox.Show("Enter New Password","Change Password",MessageBoxButtons.OK,MessageBoxIcon.Information);

                tbnewpass.Enabled = true;
                tbnewpassc.Enabled = true;
                btndone.Enabled = true;
            }
            else{
                MessageBox.Show("Invalid Username Or Pin","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                tbpincode.Text = "";
                tbuser.Text = "";
            }
        }

        private void btndone_Click(object sender, EventArgs e)
        {
            if (tbnewpass.Text == tbnewpassc.Text)
            {
                sql="UPDATE ACCOUNT SET [Password]='"+tbnewpassc.Text+"'";
                database.update(sql);

                MessageBox.Show("Successfully password changed. New password is: "+tbnewpassc.Text+"", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else {
                MessageBox.Show("Both password don't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbnewpass.Text = "";
                tbnewpassc.Text = "";
            }
        }
    }
}
