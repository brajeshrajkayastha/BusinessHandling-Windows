using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.OleDb;
using Bunifu; 
namespace Pasal
{
    class Database
    {
        public String Conn_str="Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SMS.accdb;";
        public OleDbConnection conn = null;

        public void load(string sql, DataTable dt) {
            try
            {
                conn = new OleDbConnection(Conn_str);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql,conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.SelectCommand = cmd;
                da.Fill(dt);
                conn.Close();
            }
            catch(Exception e) {
                MessageBox.Show("Database Error: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void update(string sql)
        {
            try
            {
                conn = new OleDbConnection(Conn_str);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Database Error: " + e.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void autocomplete(string field, string table, AutoCompleteStringCollection auto) {
            string sql;
            DataTable dt = new DataTable();
            sql="SELECT " +field+ " FROM " +table+ "";
            load(sql, dt);
            for (int i = 0; i < dt.Rows.Count; i++) {
                auto.Add(dt.Rows[i][0].ToString());
            }
            conn.Close();
        }

        public void combobox(string field, string table, string where, ComboBox cb) {
            string sql;
            DataTable data = new DataTable();
            if (where == "")
            {
                sql = "SELECT " + field + " FROM " + table + "";
                
            }
            else {
                sql = "SELECT " + field + " FROM " + table + " WHERE " + where + "";
            }
            load(sql, data);
            for (int i = 0; i < data.Rows.Count; i++) {
                cb.Items.Add(data.Rows[i][0].ToString());
            }
            conn.Close();
        }
    }
}

