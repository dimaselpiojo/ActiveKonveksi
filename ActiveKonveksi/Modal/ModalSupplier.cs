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
    public partial class ModalSupplier : DevExpress.XtraEditors.XtraForm
    {
        public bool edit = false;
        public string kode = null;
        public ModalSupplier()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                saveSupplier(textKode.Text, textNama.Text, textAlamat.Text, textTelepon.Text, textEmail.Text, textKontak.Text, textKeterangan.Text);
            }
            else
            {
                updateSupplier(textKode.Text, textNama.Text, textAlamat.Text, textTelepon.Text, textEmail.Text, textKontak.Text, textKeterangan.Text);
            }
        }
        private void saveSupplier(string _kode, string _nama, string _alamat, string _tlp, string _email, string _kontak, string _keterangan)
        {
            InsertController ic = new InsertController();
            ListController lc = new ListController();
            MSupplier i = new MSupplier()
            {
                kode = _kode,
                nama = _nama,
                alamat = _alamat,
                tlp = _tlp,
                email = _email,
                kontak = _kontak,
                keterangan = _keterangan,
            };
            OBJSQL obj = ic.SaveNewSupplier(i);
        }
        private void updateSupplier(string _kode, string _nama, string _alamat, string _tlp, string _email, string _kontak, string _keterangan)
        {
            InsertController ic = new InsertController();
            ListController lc = new ListController();
            MSupplier i = new MSupplier()
            {
                kode = _kode,
                nama = _nama,
                alamat = _alamat,
                tlp = _tlp,
                email = _email,
                kontak = _kontak,
                keterangan = _keterangan,
            };
            OBJSQL obj = ic.UpdateSupplier(i,kode);
        }
    }
}