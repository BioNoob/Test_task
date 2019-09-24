using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;

namespace CURS.Class
{
    public class Connection
    {
        private SqlConnection sql_conn { get; set; }
        public string con_str
        {
            get { return sql_conn.ConnectionString; }
        }
        private SqlDataAdapter sda;
        private SqlCommand sqm;
        public void CloseConn()
        {
            sql_conn.Close();
            sda.Dispose();
            sqm.Dispose();
        }
        public bool OpenConn()
        {
            try
            {
                if (sql_conn != null)
                {
                    sql_conn.Open();
                    return true;
                }
                else
                    throw new Exception();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        public DataTable ExecReq_resp(string req)
        {
            try
            {
                sqm.Connection = sql_conn;
                sqm.CommandText = req;
                sda.InsertCommand = sqm;
                sda.InsertCommand.ExecuteNonQuery();
                SqlDataReader reader = sqm.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Clear();
                //dt.Columns.Add("№").DataType = Type.GetType("System.Integer");
                //dt.Columns["№"].Unique = true;
                dt.Columns.Add("Дата");
                dt.Columns.Add("Код");
                dt.Columns.Add("Значение").DataType = Type.GetType("System.Decimal");
                double buf = 0;
                while (reader.Read())
                {
                    DataRow row = dt.NewRow();
                    row["Дата"] = String.Format("{0:MM.dd.yyyy}", reader[1]);
                    row["Код"] = reader[2];
                    //double.TryParse(reader[2].ToString(), out buf);
                    row["Значение"] = reader[3];//buf.ToString(new CultureInfo("en-US"));
                    dt.Rows.Add(row);
                }
                reader.Close();
                if (dt.Columns.Count > 0)
                    return dt;
                else
                    throw new Exception();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw new Exception(e.Message);
            }
        }
        public bool ExecReq(string req)
        {
            try
            {
                sqm.Connection = sql_conn;
                sqm.CommandText = req;
                sda.InsertCommand = sqm;
                int res = sda.InsertCommand.ExecuteNonQuery();
                if (res > 0)
                    return true;
                else
                    throw new Exception();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        
        public Connection(string constr)
        {
            sql_conn = new SqlConnection(constr);
            sda = new SqlDataAdapter();
            sqm = new SqlCommand();
        }
    }
}
