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
        public DateTime? jatuhtempo { get; set; }
        public Int32 id_supplier_pembelian { get; set; }
        public double subtotal { get; set; }
        public Int32 diskon { get; set; }
        public double grandtotal { get; set; }
        public double tunai { get; set; }
        public double kembali { get; set; }
    }
}
