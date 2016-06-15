using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveKonveksi
{
    public class GlobalVar
    {
        private static string _userID, _userName, _level, _tabselected, _rolesArray;
        private static bool _any, _success;
        public static string TabSelected
        {
            get { return _tabselected; }
            set { _tabselected = value; }
        }
        public static bool Success
        {
            get
            {
                return _success;
            }
            set
            {
                _success = value;
            }
        }
    }
}
