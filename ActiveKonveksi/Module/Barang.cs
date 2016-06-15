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
using ActiveKonveksi.Modal;

namespace ActiveKonveksi.Module
{
    public partial class Barang : DevExpress.XtraEditors.XtraForm
    {
        public string kodeBarang;
        public Barang()
        {
            InitializeComponent();
        }

        private void Barang_Load(object sender, EventArgs e)
        {
            loadBarang();
        }
        public void loadBarang()
        {
            ListController lc = new ListController();
            DataTable dt = lc.gridvBarang();
            gridBarang.DataSource = dt;
            gridViewBarang.PopulateColumns();
            gridViewBarang.ShowEditor();
            gridViewBarang.BestFitColumns();
        }

        private void gridViewBarang_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            kodeBarang = gridViewBarang.GetRowCellValue(gridViewBarang.FocusedRowHandle, "Kode").ToString();
        }

        private void gridViewBarang_DoubleClick(object sender, EventArgs e)
        {
            ModalBarang MI = new ModalBarang();
            MI.Text = "Edit Barang";
            MI.btnOk.Text = "Update";
            MI.edit = true;
            MI.kode = gridViewBarang.GetRowCellValue(gridViewBarang.FocusedRowHandle, "Kode").ToString();
            //MI._lookUpKategori();
            //MI._lookUpSatuan();
            MI.textKode.Text = gridViewBarang.GetRowCellValue(gridViewBarang.FocusedRowHandle, "Kode").ToString();
            MI.textNama.Text = gridViewBarang.GetRowCellValue(gridViewBarang.FocusedRowHandle, "Nama").ToString();
            MI.kategori = gridViewBarang.GetRowCellValue(gridViewBarang.FocusedRowHandle, "kategori").ToString();
            MI.satuan = gridViewBarang.GetRowCellValue(gridViewBarang.FocusedRowHandle, "Satuan").ToString();
            MI.spinJumlah.Value = Convert.ToDecimal(gridViewBarang.GetRowCellValue(gridViewBarang.FocusedRowHandle, "Jumlah").ToString());
            MI.spinBeli.Value = Convert.ToDecimal(gridViewBarang.GetRowCellValue(gridViewBarang.FocusedRowHandle, "HargaBeli").ToString());
            MI.spinJual.Value = Convert.ToDecimal(gridViewBarang.GetRowCellValue(gridViewBarang.FocusedRowHandle, "HargaJual").ToString());
            MI.spinDiskon.Value = Convert.ToDecimal(gridViewBarang.GetRowCellValue(gridViewBarang.FocusedRowHandle, "Diskon").ToString());
            if (MI.ShowDialog() == DialogResult.OK)
            {
                loadBarang();
            }
        }
    }
}