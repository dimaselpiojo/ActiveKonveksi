using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using ActiveKonveksi.Controller;
using DevExpress.XtraEditors;

namespace ActiveKonveksi.Helper
{
    public class ADOHelper
    {
        public static string connectionString;

        public ADOHelper()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConString"].ToString();
        }
        public DataTable ListByQuery(string sQuery)
        {
            OBJSQL objSQL = new OBJSQL();
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                bool bRet = false;
                ExecuteController exe = new ExecuteController();
                conn.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand()
                    {
                        Connection = conn,
                        CommandText = sQuery,
                        CommandType = CommandType.Text,
                        CommandTimeout = 0
                    };
                    int nRet = cmd.ExecuteNonQuery();
                    if (nRet <= 0)
                    {
                        bRet = false;
                        exe.EXE = bRet;
                    }
                    else
                    {
                        bRet = true;
                        exe.EXE = bRet;
                    }
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    objSQL.MSGOUT = ex.Message;
                    XtraMessageBox.Show(ex.Message);
                }
            }
            return dt;
        }

        public OBJSQL InsertQuery(string sQuery, List<MySqlParameter> _params = null)
        {
            OBJSQL objSQL = new OBJSQL();
            Int32 record = 0;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
               MySqlTransaction trans1 = conn.BeginTransaction();
                try
                {
                    MySqlCommand cmd = new MySqlCommand()
                    {
                        Connection = conn,
                        Transaction = trans1,
                        CommandText = sQuery,
                        CommandType = CommandType.Text,
                    };

                    cmd.Parameters.AddRange(_params.ToArray());
                    record = cmd.ExecuteNonQuery();
                    trans1.Commit();
                }
                catch (Exception ex)
                {
                    trans1.Rollback();
                    XtraMessageBox.Show(ex.Message);
                }
                if (record != 0)
                {
                    XtraMessageBox.Show(ConfigurationManager.AppSettings["msg_success_insert"]);
                    GlobalVar.Success = true;
                }
                else
                {
                    GlobalVar.Success = false;
                }
            }

            return objSQL;
        }
        public OBJSQL DeleteQuery(string sQuery)
        {
            OBJSQL objSQL = new OBJSQL();
            Int32 record = 0;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlTransaction trans1 = conn.BeginTransaction();
                try
                {
                    MySqlCommand cmd = new MySqlCommand()
                    {
                        Connection = conn,
                        Transaction = trans1,
                        CommandText = sQuery,
                        CommandType = CommandType.Text,
                    };
                    record = cmd.ExecuteNonQuery();
                    trans1.Commit();
                }
                catch (Exception ex)
                {
                    trans1.Rollback();
                    XtraMessageBox.Show(ex.Message);
                }
                if (record != 0)
                {
                    XtraMessageBox.Show(ConfigurationManager.AppSettings["msg_success_delete"]);
                    GlobalVar.Success = true;
                }
                else
                {
                    GlobalVar.Success = false;
                }
            }

            return objSQL;
        }

    }
}
