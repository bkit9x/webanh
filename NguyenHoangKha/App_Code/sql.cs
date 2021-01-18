using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace NguyenHoangKha.App_Code
{
    public class sql
    {

        private static string _connectionString = string.Empty;
        public static string ConnectionString
        {
            get
            {
                if (_connectionString.Equals(""))
                {
                    _connectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
                }
                return _connectionString;
            }
            set
            {
                _connectionString = value;
            }
        }


        public static OleDbConnection GetConnection()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            return conn;
        }


        public static void ExecuteNoneQuery(OleDbCommand cmd)
        {
            if (cmd.Connection != null)
            {
                cmd.ExecuteNonQuery();
            }
            else
            {
                OleDbConnection conn = GetConnection();
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
        }


        public static DataTable GetData(OleDbCommand cmd)
        {
            if (cmd.Connection != null)
            {
                using (DataSet ds = new DataSet())
                {
                    using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                    {
                        da.Fill(ds);
                        return ds.Tables[0];
                    }
                }
            }
            else
            {
                using (OleDbConnection conn = GetConnection())
                {
                    cmd.Connection = conn;
                    using (DataSet ds = new DataSet())
                    {
                        using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                        {
                            da.Fill(ds);
                            return ds.Tables[0];
                        }
                    }
                }
            }
        }


        public static DataSet GetData_OverDataset(OleDbCommand cmd)
        {
            if (cmd.Connection != null)
            {
                using (DataSet ds = new DataSet())
                {
                    using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                    {
                        da.Fill(ds);
                        return ds;
                    }
                }
            }
            else
            {
                using (OleDbConnection conn = GetConnection())
                {
                    cmd.Connection = conn;
                    using (DataSet ds = new DataSet())
                    {
                        using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                        {
                            da.Fill(ds);
                            return ds;
                        }
                    }
                }
            }
        }

    }
}