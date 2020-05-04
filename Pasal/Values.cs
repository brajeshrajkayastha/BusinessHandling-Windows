using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Pasal
{   
    class Values
    {
        Database database = new Database();
        string sql;
        
        public int product(string product){
            DataTable data = new DataTable();
            sql = "SELECT ID FROM PRODUCT WHERE Product_Name='" + product + "'";
            database.load(sql,data);
            if (data.Rows.Count == 1){ 
                return (Int32.Parse(data.Rows[0][0].ToString()));
            }
            else{
                return 0;
            }
        }
        public int supplier(string supplier) {
            DataTable data = new DataTable();
            sql="SELECT ID FROM SUPPLIER WHERE Supplier_Name ='"+supplier+"'";
            database.load(sql, data);
            if (data.Rows.Count == 1) {
                return (Int32.Parse(data.Rows[0][0].ToString()));
            }
            else{
                return 0;
            }
        }

        public int account(string acc) {
            DataTable data = new DataTable();
            sql="SELECT ID FROM Bank_Acc WHERE Account_Name='"+acc+"'";
            database.load(sql, data);
            if (data.Rows.Count == 1)
            {
                return (Int32.Parse(data.Rows[0][0].ToString()));
            }
            else {
                return 0;
            }

        }

    }
}
