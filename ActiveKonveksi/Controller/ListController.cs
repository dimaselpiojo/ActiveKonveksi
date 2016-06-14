using ActiveKonveksi.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveKonveksi.Controller
{
    public class ListController
    {
        public DataTable gridMenus()
        {
            string SQL = "SELECT Menuid ID, name, formname , idarrange Grup from menu ";
            ADOHelper h = new ADOHelper();
            DataTable dt = h.ListByQuery(SQL);
            return dt;
        }
    }
}
