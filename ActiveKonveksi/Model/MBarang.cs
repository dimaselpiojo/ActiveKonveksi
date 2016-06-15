using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveKonveksi.Model
{
    public class MBarang
    {
        public int id { get; set; }
        public string kode { get; set; }
        public string nama { get; set; }
        public decimal jumlah { get; set; }
        public decimal harga_beli { get; set; }
        public decimal harga_jual { get; set; }
        public decimal diskon { get; set; }
        public Int32 id_satuan_barang { get; set; }
        public Int32 id_kategori_barang { get; set; }
    }
}
