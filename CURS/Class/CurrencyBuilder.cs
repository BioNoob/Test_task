using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Net;
using System.Xml;
using System.Xml.Linq;
using System.Globalization;
using System.IO;

namespace CURS.Class
{
    public static class Options
    {
        public static OptionsBuild opt = OptionsBuild.Default;
    }
    public static class CurrencyBuilder
    {
        public static string connetionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Directory.GetCurrentDirectory()}\Kurs_base.mdf;Integrated Security=True";
        private static List<Currency> _data = null;
        private static List<Currency> GetActual(DateTime Dt)
        {
            List<Currency> ValCurs = new List<Currency>();
            string dt = Dt.ToShortDateString();
            try
            {
                //XDocument doc = XDocument.Load($"http://www.cbr.ru/scripts/XML_daily.asp?date_req={dt}");

                string xmlStr;
                using (var wc = new WebClient())
                {
                    xmlStr = wc.DownloadString($"http://www.cbr.ru/scripts/XML_daily.asp?date_req={dt}");
                }
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(xmlStr);
                XDocument doc = XDocument.Parse(xmlStr);


                foreach (var item in doc.Element("ValCurs").Elements("Valute"))
                {
                    Currency cr = new Currency();
                    cr.date = String.Format("{0:MM.dd.yyyy}", Dt);
                    cr.code = item.Element("CharCode").Value.ToUpper();
                    double value; int nominal;
                    double.TryParse(item.Element("Value").Value, out value);
                    int.TryParse(item.Element("Nominal").Value, out nominal);
                    if (Options.opt.nominal)
                        cr.val = value / nominal;
                    else
                        cr.val = value;
                    ValCurs.Add(cr);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return ValCurs;
        }
        public static DataTable Former(DateTime Dt)
        {
            DataTable dtb = new DataTable();
            dtb.Clear();
            dtb.Columns.Add("Дата");
            dtb.Columns.Add("Код");
            dtb.Columns.Add("Значение").DataType = Type.GetType("System.Decimal");
            _data = GetActual(Dt);
            foreach (var item in _data)
            {
                DataRow row = dtb.NewRow();
                row["Дата"] = item.date;
                row["Код"] = item.code;
                row["Значение"] = item.val;//.ToString(new CultureInfo("en-US"));
                dtb.Rows.Add(row);
            }
            return dtb;
        }
        public static DataTable ClearBase()
        {
            Connection cnn = new Connection(connetionString);
            cnn.OpenConn();
            try
            {
                    string command = $"TRUNCATE TABLE Kurs";
                    return cnn.ExecReq_resp(command);
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                cnn.CloseConn();
            }
        }
        public static void UpdateBase_fromTable(DataTable dt)
        {
            Connection cnn = new Connection(connetionString);
            cnn.OpenConn();
            try
            {
                foreach (DataRow item in dt.Rows)
                {
                    Currency cr = new Currency(item.Field<string>("Дата"), item.Field<string>("Код"), (double)item.Field<decimal>("Значение"));
                    string command = $"INSERT INTO Kurs VALUES ('{cr.date}','{cr.code}',{cr.val.ToString(new CultureInfo("en-US"))})";
                    if (!cnn.ExecReq(command))
                        throw new Exception("Запись не прошла");
                }
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                cnn.CloseConn();
            }
        }
        public static DataTable LoadBase()
        {
            Connection cnn = new Connection(connetionString);
            cnn.OpenConn();
            DataTable dt = cnn.ExecReq_resp("SELECT * FROM Kurs");
            cnn.CloseConn();
            return dt;
        }
        public static void UpdateBase_fromTable_xml(DateTime Dt)
        {

            Connection cnn = new Connection(connetionString);
            cnn.OpenConn();
            try
            {
                DataTable dataTable = Former(Dt);
                using (var bulkCopy = new SqlBulkCopy(cnn.con_str, SqlBulkCopyOptions.KeepIdentity))
                {
                    //foreach (DataColumn col in dataTable.Columns)
                    //{
                        SqlBulkCopyColumnMapping mapping1 = new SqlBulkCopyColumnMapping("Дата", "Дата");
                        SqlBulkCopyColumnMapping mapping2 = new SqlBulkCopyColumnMapping("Код", "Валюта");
                        SqlBulkCopyColumnMapping mapping3 = new SqlBulkCopyColumnMapping("Значение", "Курс");

                        bulkCopy.ColumnMappings.Add(mapping1);
                        bulkCopy.ColumnMappings.Add(mapping2);
                        bulkCopy.ColumnMappings.Add(mapping3);
                    //}

                    bulkCopy.BulkCopyTimeout = 400;
                    bulkCopy.DestinationTableName = "Kurs";
                    bulkCopy.WriteToServer(dataTable);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cnn.CloseConn();
            }
        }

    }
}
