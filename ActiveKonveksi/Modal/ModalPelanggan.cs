using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ActiveKonveksi.Controller;
using ActiveKonveksi.Model;
using ActiveKonveksi.Helper;

namespace ActiveKonveksi.Modal
{
    public partial class ModalPelanggan : DevExpress.XtraEditors.XtraForm
    {
        public bool edit = false;
        public string kode = null;
        public ModalPelanggan()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                savePelanggan(textKode.Text, textNama.Text, textAlamat.Text, textTelepon.Text, textEmail.Text, textKeterangan.Text);
            }
            else
            {
                updatePelanggan(textKode.Text, textNama.Text, textAlamat.Text, textTelepon.Text, textEmail.Text, textKeterangan.Text);
            }
        }
        private void savePelanggan(string _kode, string _nama, string _alamat, string _tlp, string _email, string _keterangan)
        {
            InsertController ic = new InsertController();
            ListController lc = new ListController();
            MPelanggan i = new MPelanggan()
            {
                kode = _kode,
                nama = _nama,
                alamat = _alamat,
                tlp = _tlp,
                email = _email,
                keterangan = _keterangan,
            };
            OBJSQL obj = ic.SaveNewPelanggan(i);
        }
        private void updatePelanggan(string _kode, string _nama, string _alamat, string _tlp, string _email, string _keterangan)
        {
            InsertController ic = new InsertController();
            ListController lc = new ListController();
            MPelanggan i = new MPelanggan()
            {
                kode = _kode,
                nama = _nama,
                alamat = _alamat,
                tlp = _tlp,
                email = _email,
                keterangan = _keterangan,
            };
            OBJSQL obj = ic.UpdatePelanggan(i, kode);
        }
    }
}