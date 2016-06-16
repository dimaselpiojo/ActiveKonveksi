using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveKonveksi.Model
{
    public class MPembelian
    {
        public int id_pembelian { get; set; }
        public string faktur { get; set; }
        public DateTime tanggal { get; set; }
        public Int32 id_kredit_pembelian { get; set; }
        public DateTime jatuhtempo { get; set; }
        public Int32 id_supplier_pembelian { get; set; }
        public string kodebarcode { get; set; }
        public string nama { get; set; }
        public Int32 jumlah { get; set; }
        public Int32 id_satuan_pembelian { get; set; }
        public decimal hargabeli { get; set; }
        public Int32 diskon { get; set; }
        public decimal hargabersih { get; set; }
        public decimal total { get; set; }
    }
}
