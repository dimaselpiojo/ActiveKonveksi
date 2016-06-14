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




    }
}
