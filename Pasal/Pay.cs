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
    public partial class Pay : Form
    {
        Database database = new Database();
        Values IDvalue = new Values();
        Validation valid = new Validation();
        string sql;
        int y, y1, y2, y3, y4, y5;

        public Pay()
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

        private void Pay_Load(object sender, EventArgs e)
        {
            database.combobox("Account_Name", "Bank_Acc", "", cbacc);

            tbsupp.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbsupp.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection sauto = new AutoCompleteStringCollection();
            database.autocomplete("Supplier_Name", "SUPPLIER", sauto);
            tbsupp.AutoCompleteCustomSource = sauto;

            lbchq.Visible = false;
            tbchqno.Visible = false;
            lbacc.Visible = false;
            cbacc.Visible = false;

            tbamt.Text = "";
            tbchqno.Text = "";
            tbrecieptno.Text = "";
            tbsupp.Text = "";
            cbacc.Text = "";
            cbpayment.Text = "";
            
        }

        private void btndone_Click(object sender, EventArgs e)
        {
            int suppid,accid,chqid,balance;
            suppid = IDvalue.supplier(tbsupp.Text);
            accid=IDvalue.account(cbacc.Text);

            if (suppid != 0)
            {
                if (valid.number(tbamt.Text) == true && valid.number(tbrecieptno.Text) == true)
                {

                    if (cbpayment.Text == "Cheque" )
                    {
                        if (valid.number(tbchqno.Text) == true)
                        {
                            sql = "INSERT INTO [Cheque] ([Cheque_No],[Account],[Supplier],[Date],[Amount] VALUES (" + tbchqno.Text + "," + accid + "," + suppid + ",'" + Datepicker1.Value.ToShortDateString() + "'," + tbamt.Text + "))";
                            database.update(sql);

                            DataTable data = new DataTable();
                            sql="SELECT ID FROM CHEQUE WHERE [Cheque_No]="+tbchqno.Text+"";
                            database.load(sql,data);

                            chqid=Int32.Parse(data.Rows[0][0].ToString());
                                                        
                            sql = "INSERT INTO [Bank_Trans] ([Account],[Trans_Type],[Date],[Amount],[Cheque]) VALUES ("+accid+",'"+"Cheque"+"',"+Datepicker1.Value.ToShortDateString()+","+tbamt.Text+","+chqid+")";
                            database.update(sql);

                            DataTable data1 = new DataTable();
                            sql="SELECT [Balance] FROM SUPPLIER WHERE ID="+suppid+"";
                            database.load(sql, data1);
                            balance= Int32.Parse(data1.Rows[0][0].ToString());

                            balance -= Int32.Parse(tbamt.Text);

                            sql = "INSERT INTO [TRANSACTION] ([Date],[Supplier],[Debit(Dr)],[Balance_Type],[Balance],[Cheque],[BillNo/RecieptNo]) VALUES ('" + Datepicker1.Value.ToShortDateString() + "'," + suppid + "," + tbamt.Text + ",'" + "debit" + "'," + balance + ","+chqid+"," + tbrecieptno.Text + ")";
                            database.update(sql);

                            MessageBox.Show("Succesfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbamt.Text = "";
                            tbrecieptno.Text = "";
                            tbsupp.Text = "";
                        }
                        else {
                            MessageBox.Show("Invalid Cheque No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbchqno.Text = "";
                        }
                    }
                    else
                    {
                        DataTable data1 = new DataTable();
                        sql = "SELECT [Balance] FROM SUPPLIER WHERE ID=" + suppid + "";
                        database.load(sql, data1);
                        balance = Int32.Parse(data1.Rows[0][0].ToString());

                        balance -= Int32.Parse(tbamt.Text);

                        sql = "INSERT INTO [TRANSACTION] ([Date],[Supplier],[Debit(Dr)],[Balance_Type],[Balance],[BillNo/RecieptNo]) VALUES ('" + Datepicker1.Value.ToShortDateString() + "'," + suppid + "," + tbamt.Text + ",'" + "debit" + "'," + balance + "," + tbrecieptno.Text + ")";
                        database.update(sql);

                        MessageBox.Show("Successfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbamt.Text = "";
                        tbrecieptno.Text = "";
                        tbsupp.Text = "";
                    }
                }
                else 
                {
                    MessageBox.Show("Invalid Reciept No. or Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbamt.Text = "";
                    tbrecieptno.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Supplier not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbsupp.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (y < 382)
            {
                y += 13;
                y1 += 14;
                y2 += 7;
                y3 += 7;
                y4 += 12;
                y5 += 12;

                lbchq.Location = new System.Drawing.Point(61, y);
                tbchqno.Location = new System.Drawing.Point(60, y1);
                lbacc.Location = new System.Drawing.Point(61, y2);
                cbacc.Location = new System.Drawing.Point(60, y3);
                btndone.Location = new System.Drawing.Point(61, y4);
                this.ClientSize = new System.Drawing.Size(300, y5);

            }
            else {
                lbchq.Visible = true;
                tbchqno.Visible = true;
                lbacc.Visible = true;
                cbacc.Visible = true;
                timer1.Stop();

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (y > 278)
            {
                y -= 13;
                y1 -= 14;
                y2 -= 7;
                y3 -= 7;
                y4 -= 12;
                y5 -= 12;

                lbchq.Location = new System.Drawing.Point(61, y);
                tbchqno.Location = new System.Drawing.Point(60, y1);
                lbacc.Location = new System.Drawing.Point(61, y2);
                cbacc.Location = new System.Drawing.Point(60, y3);
                btndone.Location = new System.Drawing.Point(61, y4);
                this.ClientSize = new System.Drawing.Size(300, y5);
            }
            else {
                timer2.Stop();
            }
        }

        private void cbpayment_TextChanged(object sender, EventArgs e)
        {
            if (cbpayment.Text == "Cheque")
            {
                if (y <= 279)
                {
                    y = 279;
                    y1 = 298;
                    y2 = 278;
                    y3 = 298;
                    y4 = 350;
                    y5 = 398;
                    timer1.Start();
                }

            }
            else
            {
                if (y >= 382)
                {
                    y = 382;
                    y1 = 403;
                    y2 = 331;
                    y3 = 350;
                    y4 = 444;
                    y5 = 488;

                    lbchq.Visible = false;
                    tbchqno.Visible = false;
                    lbacc.Visible = false;
                    cbacc.Visible = false;
                    timer2.Start();
                }
            }
        }


    }
}
