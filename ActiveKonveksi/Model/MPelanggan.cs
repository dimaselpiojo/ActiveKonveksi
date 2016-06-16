using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveKonveksi.Model
{
    public class MPelanggan
    {
        public int id { get; set; }
        public string kode { get; set; }
        public string nama { get; set; }
        public string alamat { get; set; }
        public string tlp { get; set; }
        public string email { get; set; }
        public Int32 rating_transaksi { get; set; }
        public Int32 rating_akumulasi { get; set; }
        public string keterangan { get; set; }
    }
}
