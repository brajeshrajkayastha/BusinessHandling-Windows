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
    public partial class Main : Form
    {
        Database database = new Database();
        Validation valid = new Validation();
        Values IDvalue = new Values();
        public string User,sql;
        int x, x1, x2, x3, x4, x5, x6, x7, listqty = 0, c1 = 0, c = 0, mouseX = 0, mouseY = 0;
        string live;
        bool mousedown;
        
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            btnmain.BackColor = System.Drawing.Color.YellowGreen;
            tbmain.BringToFront();
            live = "main";
            lbbillno.Visible = false;
            tbbillno.Visible = false;

            tbproduct.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbproduct.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection pauto = new AutoCompleteStringCollection();
            database.autocomplete("Product_Name", "PRODUCT", pauto);
            tbproduct.AutoCompleteCustomSource = pauto;

            tbproduct2.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbproduct2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection pauto1 = new AutoCompleteStringCollection();
            database.autocomplete("Product_Name", "PRODUCT", pauto1);
            tbproduct2.AutoCompleteCustomSource = pauto1;
            
            tbsupp.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbsupps.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbsuppb.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbsupp.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbsupps.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbsuppb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection sauto = new AutoCompleteStringCollection();
            database.autocomplete("Supplier_Name", "SUPPLIER", sauto);
            tbsupp.AutoCompleteCustomSource = sauto;
            tbsupps.AutoCompleteCustomSource = sauto;
            tbsuppb.AutoCompleteCustomSource = sauto;

            database.combobox("Account_Name", "Bank_Acc", "", cbacc);

            tbname.Text = "";
            tbprofit.Text = "";
            tbamt.Text = "";
            dgsupp.DataSource = null;
            dgacc.DataSource = null;
            dgbillcon.DataSource = null;
            tbsupps.Text = "";
            tbsuppb.Text = "";
            cbacc.Text = "";
            cbbillno.Text = "";
            dgdaily.DataSource = null;
            dgdaily2.DataSource = null;
            dgmonth.DataSource = null;
            dgmonth2.DataSource = null;
            dgcustom.DataSource = null;

        }


        private void btnmain_Click(object sender, EventArgs e)
        {
            
            tbmain.BringToFront();
            live = "main";
            btnstock.BackColor = System.Drawing.Color.Teal;
            btnmain.BackColor = System.Drawing.Color.YellowGreen;
            btnsupplier.BackColor = System.Drawing.Color.Teal;
            btnbanking.BackColor = System.Drawing.Color.Teal;
            btntrans.BackColor = System.Drawing.Color.Teal;
            btnreport.BackColor = System.Drawing.Color.Teal;
            
            if(panel1.Width <= 65){
                stockView1.BringToFront();
                btnstock.BackColor = System.Drawing.Color.Goldenrod;
            }
            Main_Load(sender, e);

        }

        private void btnstock_Click(object sender, EventArgs e)
        {
            if (panel1.Width >= 187)
            {

                stockView1.BringToFront();
                live = "stock";
                btnstock.BackColor = System.Drawing.Color.YellowGreen;
                btnmain.BackColor = System.Drawing.Color.Teal;
                btnsupplier.BackColor = System.Drawing.Color.Teal;
                btnbanking.BackColor = System.Drawing.Color.Teal;
                btntrans.BackColor = System.Drawing.Color.Teal;
                btnreport.BackColor = System.Drawing.Color.Teal;

                
            }
            stockView1.StockView_Load(sender, e);
        }

        private void btnsupplier_Click(object sender, EventArgs e)
        {
            supplierView1.BringToFront();
            live = "supp";
            btnstock.BackColor = System.Drawing.Color.Teal;
            btnmain.BackColor = System.Drawing.Color.Teal;
            btnsupplier.BackColor = System.Drawing.Color.YellowGreen;
            btnbanking.BackColor = System.Drawing.Color.Teal;
            btntrans.BackColor = System.Drawing.Color.Teal;
            btnreport.BackColor = System.Drawing.Color.Teal;

            if (panel1.Width <= 65)
            {
                tab1.BringToFront();
                btntrans.BackColor = System.Drawing.Color.Goldenrod;
            }

            supplierView1.SupplierView_Load(sender, e);
        }

        private void btnbanking_Click(object sender, EventArgs e)
        {
            banking1.BringToFront();
            live = "bank";
            btnstock.BackColor = System.Drawing.Color.Teal;
            btnmain.BackColor = System.Drawing.Color.Teal;
            btnsupplier.BackColor = System.Drawing.Color.Teal;
            btnbanking.BackColor = System.Drawing.Color.YellowGreen;
            btntrans.BackColor = System.Drawing.Color.Teal;
            btnreport.BackColor = System.Drawing.Color.Teal;

            if (panel1.Width <= 65)
            {
                tab1.BringToFront();
                btntrans.BackColor = System.Drawing.Color.Goldenrod;
            }

            banking1.Banking_Load(sender, e);
        }

        private void btntrans_Click(object sender, EventArgs e)
        {
            if (panel1.Width >= 187)
            {

                tab1.BringToFront();
                live = "Trans";
                btnstock.BackColor = System.Drawing.Color.Teal;
                btnmain.BackColor = System.Drawing.Color.Teal;
                btnsupplier.BackColor = System.Drawing.Color.Teal;
                btnbanking.BackColor = System.Drawing.Color.Teal;
                btntrans.BackColor = System.Drawing.Color.YellowGreen;
                btnreport.BackColor = System.Drawing.Color.Teal;
            }

            Main_Load(sender, e);
            tab1.BringToFront();

        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            tabsales.BringToFront();
            live = "report";
            btnstock.BackColor = System.Drawing.Color.Teal;
            btnmain.BackColor = System.Drawing.Color.Teal;
            btnsupplier.BackColor = System.Drawing.Color.Teal;
            btnbanking.BackColor = System.Drawing.Color.Teal;
            btntrans.BackColor = System.Drawing.Color.Teal;
            btnreport.BackColor = System.Drawing.Color.YellowGreen;

            if (panel1.Width <= 65)
            {
                tab1.BringToFront();
                btntrans.BackColor = System.Drawing.Color.Goldenrod;
            }

            Main_Load(sender, e);
            tabsales.BringToFront();
            
        }
   

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 187)
            {
                x = 800;
                x1 = 35;
                x2 = 200;
                x3 = 200;
                x4 = 742;
                x5 =235;
                x6 =230;
                x7 = 670; 
                timer1.Start();
            }
            else {
                x =1280;
                x1 = 0 ;
                x2 = 80;
                x3 = 680;
                x4 = 1220;
                x5 = 510;
                x6 = 500;
                x7 = 940;

                timer2.Start();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (panel1.Width > 65)
            {
                panel1.Width -= 16;
                x2 -= 16;
                x1 -= 5;
                x += 60;
                x3 += 60;
                x4 += 60;
                x5 += 35;
                x6 += 34;
                x7 += 34;
                c += 1;
                pictureBox1.Location = new System.Drawing.Point(x1, 9);
                btnexit.Location = new System.Drawing.Point(x4, 9);
                lb2.Location = new System.Drawing.Point(x5, 26);
                tbsearch.Location = new System.Drawing.Point(x6, 23);
                btnsearch.Location = new System.Drawing.Point(x7, 16);
                tbmain.Location = new System.Drawing.Point(x2, 71);
                supplierView1.Location = new System.Drawing.Point(x2, 71);
                banking1.Location = new System.Drawing.Point(x2, 71);
                stockView1.Location = new System.Drawing.Point(x3, 71);
                tab1.Location = new System.Drawing.Point(x3, 71);
                this.ClientSize = new System.Drawing.Size(x, 550);
                tabsales.Location = new System.Drawing.Point(x2, 71);
                

            }
            else {

                if (live == "main" || live == "stock")
                {
                    stockView1.BringToFront();
                    tbmain.BringToFront();
                    btnstock.BackColor = System.Drawing.Color.Goldenrod;
                    btnmain.BackColor = System.Drawing.Color.YellowGreen;

                }
                else if (live == "bank" || live == "trans")
                {
                    tab1.BringToFront();
                    banking1.BringToFront();
                    tabbank.BringToFront();
                    btnbanking.BackColor = System.Drawing.Color.YellowGreen;
                    btntrans.BackColor = System.Drawing.Color.Goldenrod;
                }
                else if (live == "report" || live == "trans") {
                    tab1.BringToFront();
                    tabsales.BringToFront();
                    btnreport.BackColor = System.Drawing.Color.YellowGreen;
                    btntrans.BackColor = System.Drawing.Color.Goldenrod;
                }
                else
                {
                    tab1.BringToFront();
                    supplierView1.BringToFront();
                    tabsupp.BringToFront();
                    btnsupplier.BackColor = System.Drawing.Color.YellowGreen;
                    btntrans.BackColor = System.Drawing.Color.Goldenrod;
                }

                timer1.Stop();

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            if (panel1.Width < 187)
            {
                panel1.Width += 16;
                x2 += 15;
                x1 += 7;
                x -= 60;
                x3 -= 60;
                x4 -= 60;
                x5 -= 35;
                x6 -= 34;
                x7 -= 34;
                c1 += 1;
                pictureBox1.Location = new System.Drawing.Point(x1, 9);
                btnexit.Location = new System.Drawing.Point(x4, 9);
                lb2.Location = new System.Drawing.Point(x5, 26);
                tbsearch.Location = new System.Drawing.Point(x6, 23);
                btnsearch.Location = new System.Drawing.Point(x7, 16);
                tbmain.Location = new System.Drawing.Point(x2, 71);
                supplierView1.Location = new System.Drawing.Point(x2, 71);
                banking1.Location = new System.Drawing.Point(x2, 71);
                stockView1.Location = new System.Drawing.Point(x3, 71);
                tab1.Location = new System.Drawing.Point(x3, 71);
                tabsales.Location = new System.Drawing.Point(x2, 71);
                this.ClientSize = new System.Drawing.Size(x, 550);
            
            }
            else {
                if (live == "main")
                {
                    tbmain.BringToFront();
                }
                else if (live == "supp")
                {
                    supplierView1.BringToFront();
                }
                else if (live == "report") {
                    tabsales.BringToFront();
                }
                else
                {
                    banking1.BringToFront();
                }

                btnstock.BackColor = System.Drawing.Color.Teal;
                btntrans.BackColor = System.Drawing.Color.Teal;

                timer2.Stop();
            }
        }


        private void tbsearch_Enter(object sender, EventArgs e)
        {
            lb2.Visible = false;
        }

        private void tbsearch_Leave(object sender, EventArgs e)
        {
            if (tbsearch.Text == "")
            {
                lb2.Visible = true;
            }
        }

        private void btnlist1_Click(object sender, EventArgs e)
        {
            int productID, dbqty;
            productID = IDvalue.product(tbproduct.Text);
            if (productID != 0)
            {
                DataTable data = new DataTable();
                sql = "SELECT Quantity FROM STOCK WHERE Product=" + productID + "";
                database.load(sql, data);

                if (data.Rows.Count==1 && (Int32.Parse(data.Rows[0][0].ToString()) > listqty)){

                    dbqty = Int32.Parse(data.Rows[0][0].ToString());

                    if (valid.number(tbprice.Text) == true)
                    {
                        int sprofit = 0;

                        DataTable datap = new DataTable();
                        sql="SELECT [Price] FROM [PRODUCT] WHERE [ID]="+productID+"";
                        database.load(sql, datap);

                        sprofit = Int32.Parse(tbprice.Text) - Int32.Parse(datap.Rows[0][0].ToString());

                        if (sprofit <= 0)
                        {
                            MessageBox.Show("You are in loss of :" + sprofit + "", "Loss Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tbprice.Text = "";
                        }
                        else
                        {
                            dglist1.Rows.Add(productID, tbproduct.Text, tbprice.Text, sprofit);
                            listqty += 1;
                            tbproduct.Text = "";
                            tbprice.Text = "";

                        }
                    }
                    else {
                        MessageBox.Show("Please Enter Valid Price ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbprice.Text = "";
                    }
                }
                else {
                    MessageBox.Show("Empty Stock!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbproduct.Text = "";
                    tbprice.Text = "";
                }
            }
            else{
                MessageBox.Show("Product Not Found!", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbproduct.Text = "";
                tbprice.Text = "";
            }



        }

        private void btnlist2_Click(object sender, EventArgs e)
        {
            int productID,amt=0;
            productID = IDvalue.product(tbproduct2.Text);
            if (productID !=0)
            {
                if (valid.number(tbrate.Text) == true && valid.number(tbqty.Text) == true)
                {
                    DataTable datap = new DataTable();
                    sql="SELECT [Price]  FROM [Product] WHERE [ID]="+productID+"";
                    database.load(sql,datap);

                    if (Int32.Parse(datap.Rows[0][0].ToString()) == Int32.Parse(tbrate.Text))
                    {

                        amt = (Int32.Parse(tbrate.Text)) * (Int32.Parse(tbqty.Text));
                        dglist2.Rows.Add(productID, tbproduct2.Text, tbrate.Text, tbqty.Text, amt);

                    }
                    else {
                        if (MessageBox.Show("Old price is: " + datap.Rows[0][0].ToString() + ", Would You like to update the price to " + tbrate.Text + "?", "Price MisMatch", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                        {

                            sql = "UPDATE [PRODUCT] SET [Price]=" + tbrate.Text + "";
                            database.update(sql);

                            MessageBox.Show("Updated Price is " + tbrate.Text + "", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else {
                            MessageBox.Show("Database not update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    
                    }

                    tbproduct2.Text = "";
                    tbrate.Text = "";
                    tbqty.Text = "";

                    
                    
                }
                else {
                    MessageBox.Show("Invalid Rate or Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbrate.Text = "";
                    tbqty.Text = "";
                }
            }
            else{
                 MessageBox.Show("Product Not Found!", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                 tbproduct2.Text = "";
                 tbrate.Text = "";
                 tbqty.Text = "";
            }
        }

        private void btndone1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes") {
                if (dglist1.RowCount != 0)
                {
                    for (int i = 0; i < dglist1.RowCount; i++)
                    {
                        
                            DataTable data = new DataTable();
                            sql = "INSERT INTO SALES ([Product],[Price],[Date],[Profit]) VALUES (" + dglist1.Rows[i].Cells[0].Value + "," + dglist1.Rows[i].Cells[2].Value + ",'" + Datepicker1.Value.ToShortDateString() + "'," + dglist1.Rows[i].Cells[3].Value + ")";
                            database.update(sql);

                            sql = "UPDATE STOCK SET [Quantity] = [Quantity] - 1  WHERE Product=" + dglist1.Rows[i].Cells[0].Value + "";
                            database.load(sql, data);

                            MessageBox.Show("Successfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        tbproduct.Text = "";
                        tbprice.Text = "";

                    }

                else {
                    MessageBox.Show("Empty List");
                }
            }

            dglist1.Rows.Clear();
            dglist1.Refresh();
        }

        private void btndone2_Click(object sender, EventArgs e)
        {
            int supplierID,amount=0,balance,qty;
            supplierID = IDvalue.supplier(tbsupp.Text);
            if (supplierID != 0)
            {
                if (rdbillyes.Checked == true)
                {
                    DataTable datab = new DataTable();
                    sql = "SELECT * FROM BILLS WHERE Billno=" + tbbillno.Text + "";
                    database.load(sql, datab);

                    if (valid.number(tbbillno.Text) == true && datab.Rows.Count == 0)
                    {
                        if (MessageBox.Show("Are you sure? Supplier is " + tbsupp.Text + " And Bill No =" + tbbillno.Text, "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question).ToString() == "Yes")
                        {

                            if (dglist2.RowCount != 0)
                            {
                                    sql = "INSERT INTO BILLS ([BillNo],[Supplier],[BillDate]) VALUES (" + tbbillno.Text + "," + supplierID + ",'" + Datepicker2.Value.ToShortDateString() + "')";
                                    database.update(sql);

                                    for (int i = 0; i < dglist2.RowCount; i++)
                                    {

                                        amount = amount + Int32.Parse(dglist2.Rows[i].Cells[4].Value.ToString());

                                        DataTable data1 = new DataTable();
                                        sql = "INSERT INTO [Bill_Transactions] ([BillNo],[Product],[Rate],[Quantity],[Amount]) Values (" + tbbillno.Text + "," + dglist2.Rows[i].Cells[0].Value + "," + dglist2.Rows[i].Cells[2].Value + "," + dglist2.Rows[i].Cells[3].Value + "," + dglist2.Rows[i].Cells[4].Value + ")";
                                        database.update(sql);

                                        sql = "SELECT Quantity FROM STOCK WHERE Product=" + dglist2.Rows[i].Cells[0].Value + "";
                                        database.load(sql, data1);

                                        if (data1.Rows.Count == 0)
                                        {
                                            sql = "INSERT INTO [STOCK] ([Product],[Quantity]) VALUES (" + dglist2.Rows[i].Cells[0].Value + "," + dglist2.Rows[i].Cells[3].Value + ")";
                                            database.update(sql);
                                            
                                        }
                                        else {

                                            qty = Int32.Parse(data1.Rows[0][0].ToString());
                                            qty = qty + Int32.Parse(dglist2.Rows[i].Cells[3].Value.ToString());

                                            sql = "UPDATE STOCK SET Quantity=" + qty + " WHERE Product=" + dglist2.Rows[i].Cells[0].Value + "";
                                            database.update(sql);
                                        }

                                    }

                                    DataTable data = new DataTable();
                                    sql = "SELECT Balance FROM SUPPLIER WHERE ID=" + supplierID + "";
                                    database.load(sql, data);

                                    if (data.Rows.Count == 0)
                                    {
                                        balance = amount;
                                    }
                                    else {
                                        balance = Int32.Parse(data.Rows[0][0].ToString());
                                        balance = balance + amount;
                                    }

                                    sql = "INSERT INTO [TRANSACTION] ([Date],[Supplier],[Credit(Cr)],[Balance_Type],[Balance],[BillNo/RecieptNo]) VALUES ('" + Datepicker2.Value.ToShortDateString() + "'," + supplierID + "," + amount + ",'" + "Credit" + "'," + balance + "," + tbbillno.Text + ")";
                                    database.update(sql);

                                    sql = "UPDATE SUPPLIER SET [Balance]=" + balance + " WHERE ID=" + supplierID + "";
                                    database.update(sql);

                                    MessageBox.Show("Successfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    tbsupp.Text = "";
                                    tbbillno.Text = "";
                                    tbrate.Text="";
                                    tbproduct2.Text="";
                                    tbqty.Text="";



                            }
                            else
                            {
                                MessageBox.Show("Empty list. Enter data."); 
                            }

                            dglist2.Rows.Clear();
                            dglist2.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Edit Supplier or Bill No. !");

                            tbsupp.Text = "";
                            tbbillno.Text = "";

                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Bill No. entry Or Bill No. already exits for the supplier: "+tbsupp.Text+" ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbbillno.Text = "";
                    }
                }
                else if (rdbillno.Checked == true)
                {
                    if (dglist2.RowCount != 0)
                            {
                                for (int i = 0; i < dglist2.RowCount; i++)
                                    {

                                        amount = amount + Int32.Parse(dglist2.Rows[i].Cells[4].Value.ToString());

                                        DataTable data1 = new DataTable();
                                        sql = "SELECT Quantity FROM STOCK WHERE Product=" + dglist2.Rows[i].Cells[0].Value + "";
                                        database.load(sql, data1);

                                        if (data1.Rows.Count == 0)
                                        {
                                            sql = "INSERT INTO [STOCK] ([Product],[Quantity]) VALUES (" + dglist2.Rows[i].Cells[0].Value + "," + dglist2.Rows[i].Cells[3].Value + ")";
                                            database.update(sql);
                                        }
                                        else
                                        {
                                            qty = Int32.Parse(data1.Rows[0][0].ToString());
                                            qty = qty + Int32.Parse(dglist2.Rows[i].Cells[3].Value.ToString());

                                            sql = "UPDATE STOCK SET Quantity=" + qty + " WHERE Product=" + dglist2.Rows[i].Cells[0].Value + "";
                                            database.update(sql);
                                        }    
                                    }

                                DataTable data = new DataTable();
                                sql = "SELECT Balance FROM [Supplier] WHERE ID=" + supplierID + "";
                                database.load(sql, data);
                                if (data.Rows.Count == 0)
                                {
                                    balance = amount;
                                }
                                else {
                                    balance = Int32.Parse(data.Rows[0][0].ToString());
                                    balance = balance + amount;
                                }

                                sql = "INSERT INTO [TRANSACTION] ([Date],[Supplier],[Credit(Cr)],[Balance_Type],[Balance]) VALUES ('" + Datepicker2.Value.ToShortDateString() + "'," + supplierID + "," + amount + ",'" + "Credit" + "'," + balance + ")";
                                database.update(sql);

                                sql = "UPDATE [Supplier] SET [Balance]=" + balance + " WHERE Supplier=" + supplierID + "";
                                database.update(sql);

                                MessageBox.Show("Successfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                tbsupp.Text = "";
                                tbbillno.Text = "";
                                tbrate.Text = "";
                                tbproduct2.Text = "";
                                tbqty.Text = "";

                            }   
                            else
                            {
                                MessageBox.Show("Empty list. Enter data.");
                            }
                    dglist2.Rows.Clear();
                    dglist2.Refresh();
                }
                else
                {
                    MessageBox.Show("Select Billing Mode", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("Supplier not Found!");
                tbsupp.Text = "";
            }
        }

        private void rdbillyes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbillyes.Checked == true) {
                if (panel2.Height == 113) {
                    timer3.Start();
                }
                rdbillno.Checked = false;

            } 
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (panel2.Height < 178) {
                panel2.Height += 5;
            }
            else{
                timer3.Stop();
                lbbillno.Visible = true;
                tbbillno.Visible = true;
            }

        }

        private void rdbillno_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbillno.Checked == true)
            {
                if (panel2.Height == 178)
                {
                    timer4.Start();
                }
                rdbillyes.Checked = false;

            } 
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (panel2.Height > 113)
            {
                panel2.Height -= 5;
            }
            else
            {
                timer4.Stop();
            }
            lbbillno.Visible = false;
            tbbillno.Visible = false;
        }

        private void btnsview_Click(object sender, EventArgs e)
        {
            int suppid;
            suppid = IDvalue.supplier(tbsupps.Text);
            if (suppid != 0)
            {
                DataTable data = new DataTable();
                sql = "SELECT * FROM [TRANSACTION] WHERE [Supplier]=" +suppid+ "";
                database.load(sql, data);
                dgsupp.DataSource = data;
            }
            else {
                MessageBox.Show("Supplier Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbsupps.Text = "";
            }
        }

        private void btnview2_Click(object sender, EventArgs e)
        {
            int acc;
            acc = IDvalue.account(cbacc.Text);
            DataTable data = new DataTable();
            sql = "SELECT * FROM [Bank_Trans] WHERE Account="+acc+"";
            database.load(sql, data);

            dgacc.DataSource = data;
        }

        private void btnviewb_Click(object sender, EventArgs e)
        {
            int suppid;
            suppid = IDvalue.supplier(tbsuppb.Text);

            if (suppid != 0) { 
                DataTable data = new DataTable();
                sql = "SELECT * FROM [Bill_Transactions] WHERE BillNo=" +cbbillno.Text+ "";
                database.load(sql, data);
                dgbillcon.DataSource = data;
            }
            else
            {
                MessageBox.Show("Supplier Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbsuppb.Text = "";
            }
        }

        private void tbsuppb_TextChanged(object sender, EventArgs e)
        {
            int suppid;
            suppid = IDvalue.supplier(tbsuppb.Text);

            database.combobox("BillNo", "Bills", "[Supplier]=" + suppid + "", cbbillno);
        }

        private void btndone3_Click(object sender, EventArgs e)
        {
            if (valid.name(tbname.Text) == true && valid.number(tbprofit.Text) == true && valid.number(tbamt.Text)==true)
            {
                sql = "INSERT INTO [SALES] ([Others],[Price],[Date],[Profit]) VALUES ('" +tbname.Text+ "'," +tbamt.Text+ ",'" +Datepicker1.Value.ToShortDateString()+"',"+tbprofit.Text+")";
                database.update(sql);

                tbname.Text = "";
                tbprofit.Text = "";
                tbamt.Text = "";
                
            }
            else {
                MessageBox.Show("Invalid Input Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbname.Text = "";
                tbprofit.Text = "";
                tbamt.Text = "";
            }
        }

        private void btnmonth_Click(object sender, EventArgs e)
        {
            int total = 0, profit = 0, count = 1;
            DataTable data1 = new DataTable();
            string month = cbmonth.Text.Substring(cbmonth.Text.Length - 2, 2).Replace(" ",string.Empty);

            while (count >= 1){

                int daily = 0;

                DataTable data = new DataTable();
                sql = "SELECT * FROM SALES WHERE Date = #" + month + "/"+count+"/2018#";
                database.load(sql, data);

                count = data.Rows.Count;
                for (int j = 0; j < data.Rows.Count; j++) {
                    daily = daily + Int32.Parse(data.Rows[3][j].ToString());
                    profit = profit + Int32.Parse(data.Rows[5][j].ToString());
                }
                
                total = total + daily;

                dgmonth.Rows.Add(count, daily, profit);
            }

            lbm1.Text = total.ToString();
            lbm2.Text = profit.ToString();
            
            
        }

        private void btncustom_Click(object sender, EventArgs e)
        {

            DataTable data = new DataTable();
            sql = "SELECT * FROM SALES WHERE Date >= #" + bunifuDatepicker2.Value.ToShortDateString() + "# AND Date < #" + bunifuDatepicker3.Value.ToShortDateString() + "#";
            database.load(sql, data);

            dgcustom.DataSource = data;
        }

        private void dailybtn_Click(object sender, EventArgs e)
        {
            int total = 0, profit = 0;
            
            DataTable data = new DataTable();
            sql = "SELECT * FROM SALES WHERE Date = #" + bunifuDatepicker1.Value.ToShortDateString() + "#";
            database.load(sql, data);

            for (int i = 0; i < data.Rows.Count; i++) {

                total = total + Int32.Parse(data.Rows[i][3].ToString());
                profit = profit + Int32.Parse(data.Rows[i][5].ToString());

            }
            dgdaily.DataSource = data;

            lbd1.Text = total.ToString();
            lbd2.Text = profit.ToString();
        }

        private void moveable_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void moveable_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown == true) {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void moveable_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            Main_Load(sender, e);
            stockView1.StockView_Load(sender, e);
            supplierView1.SupplierView_Load(sender, e);
            banking1.Banking_Load(sender, e);
            btnreport_Click(sender, e);
            btntrans_Click(sender, e);
        }

        private void metroTabPage4_Click(object sender, EventArgs e)
        {

        }

    }
}