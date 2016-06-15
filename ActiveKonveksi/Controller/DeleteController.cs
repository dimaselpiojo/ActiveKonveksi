using ActiveKonveksi.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveKonveksi.Controller
{

    public class DeleteController
    {
        ADOHelper h = null;
        public DeleteController()
        {
            h = new ADOHelper();
        }
        public OBJSQL Delete(string table, string id, Int32 idWhere)
        {
            String SQLQuery =
                "DELETE FROM " + table +
                " WHERE " + id + " = " + idWhere;
            OBJSQL obj = h.DeleteQuery(SQLQuery);
            return obj;
        }
        public OBJSQL Delete(string table, string id, string idWhere)
        {
            String SQLQuery =
                "DELETE FROM " + table +
                " WHERE " + id + " = " + idWhere;
            OBJSQL obj = h.DeleteQuery(SQLQuery);
            return obj;
        }
    }
}
