using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveKonveksi.Model
{
    public class MDetailPembelian
    {
        public int id_detailpembelian { get; set; }
        public Int32 id_pembelian_detail { get; set; }
        public Int32 id_barang_detail { get; set; }
        public Int32 jumlah { get; set; }
        public Int32 id_satuan_detail { get; set; }
        public double hargabeli { get; set; }
        public Int32 diskon { get; set; }
        public double hargabersih { get; set; }
        public double total { get; set; }
    }
}
