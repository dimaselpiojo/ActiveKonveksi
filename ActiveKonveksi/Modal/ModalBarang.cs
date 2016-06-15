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
using DevExpress.XtraEditors.Controls;
using ActiveKonveksi.Model;
using ActiveKonveksi.Helper;

namespace ActiveKonveksi.Modal
{
    public partial class ModalBarang : DevExpress.XtraEditors.XtraForm
    {
        public bool edit = false;
        public string kategori = null;
        public string satuan = null;
        public string kode = null;
        public ModalBarang()
        {
            InitializeComponent();
        }

        private void ModalBarang_Load(object sender, EventArgs e)
        {
            _lookUpKategori();
            _lookUpSatuan();
            if ((kategori != null) && (satuan != null))
            {
                lookKategori.Text = kategori;
                lookSatuan.Text = satuan;   
            }
        }
        public void _lookUpKategori()
        {
            ListController lc = new ListController();
            DataTable dt = lc.gridKategori();
            lookKategori.Properties.DataSource = dt;
            lookKategori.Properties.DisplayMember = "Nama";
            lookKategori.Properties.ValueMember = "id_kategori";
            lookKategori.Properties.PopulateColumns();
            lookKategori.Properties.Columns["id_kategori"].Visible = false;
            lookKategori.Properties.AutoSearchColumnIndex = Convert.ToInt32(1);
            lookKategori.ItemIndex = 0;
            lookKategori.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
        }
        public void _lookUpSatuan()
        {
            ListController lc = new ListController();
            DataTable dt = lc.gridSatuan();
            lookSatuan.Properties.DataSource = dt;
            lookSatuan.Properties.DisplayMember = "Nama";
            lookSatuan.Properties.ValueMember = "id_satuan";
            lookSatuan.Properties.PopulateColumns();
            lookSatuan.Properties.Columns["id_satuan"].Visible = false;
            lookSatuan.Properties.AutoSearchColumnIndex = Convert.ToInt32(1);
            lookSatuan.ItemIndex = 0;
            lookSatuan.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                Int32 _kategori = Convert.ToInt32(lookKategori.EditValue);
                Int32 _satuan = Convert.ToInt32(lookSatuan.EditValue);
                saveBarang(textKode.Text, textNama.Text, spinJumlah.Value, spinBeli.Value, spinJual.Value, spinDiskon.Value, _kategori, _satuan);
            }
            else
            {
                Int32 _kategori = Convert.ToInt32(lookKategori.EditValue);
                Int32 _satuan = Convert.ToInt32(lookSatuan.EditValue);
                 
                updateBarang(textKode.Text, textNama.Text, spinJumlah.Value, spinBeli.Value, spinJual.Value, spinDiskon.Value, _kategori, _satuan);
            }
        }
        private void saveBarang(string _kode, string _nama, Decimal _jumlah, Decimal _hargabeli, Decimal _hargajual, Decimal _diskon, Int32 _id_kategori_barang, Int32 _id_satuan_barang)
        {
            InsertController ic = new InsertController();
            ListController lc = new ListController();
            MBarang i = new MBarang()
            {
                kode = _kode,
                nama = _nama,
                jumlah = _jumlah,
                harga_beli = _hargabeli,
                harga_jual = _hargajual,
                diskon = _diskon,
                id_kategori_barang = _id_kategori_barang,
                id_satuan_barang = _id_satuan_barang
            };
            OBJSQL obj = ic.SaveNewBarang(i);
        }
        private void updateBarang(string _kode, string _nama, Decimal _jumlah, Decimal _hargabeli, Decimal _hargajual, Decimal _diskon, Int32 _id_kategori_barang, Int32 _id_satuan_barang)
        {
            InsertController ic = new InsertController();
            ListController lc = new ListController();
            MBarang i = new MBarang()
            {
                kode = _kode,
                nama = _nama,
                jumlah = _jumlah,
                harga_beli = _hargabeli,
                harga_jual = _hargajual,
                diskon = _diskon,
                id_kategori_barang = _id_kategori_barang,
                id_satuan_barang = _id_satuan_barang
            };
            OBJSQL obj = ic.UpdateBarang(i, kode);
        }
    }
}