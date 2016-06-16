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
    public partial class Pelanggan : DevExpress.XtraEditors.XtraForm
    {
        public string kodePelanggan;
        public Pelanggan()
        {
            InitializeComponent();
        }

        private void Pelanggan_Load(object sender, EventArgs e)
        {
            loadPelanggan();
        }
        public void loadPelanggan()
        {
            ListController lc = new ListController();
            DataTable dt = lc.gridPelanggan();
            gridPelanggan.DataSource = dt;
            gridViewPelanggan.PopulateColumns();
            gridViewPelanggan.ShowEditor();
            gridViewPelanggan.BestFitColumns();
        }

        private void gridViewPelanggan_DoubleClick(object sender, EventArgs e)
        {
            ModalPelanggan MI = new ModalPelanggan();
            MI.Text = "Edit Pelanggan";
            MI.btnOk.Text = "Update";
            MI.edit = true;
            MI.kode = gridViewPelanggan.GetRowCellValue(gridViewPelanggan.FocusedRowHandle, "Kode").ToString();
            //MI._lookUpKategori();
            //MI._lookUpSatuan();
            MI.textKode.Text = gridViewPelanggan.GetRowCellValue(gridViewPelanggan.FocusedRowHandle, "Kode").ToString();
            MI.textNama.Text = gridViewPelanggan.GetRowCellValue(gridViewPelanggan.FocusedRowHandle, "Nama").ToString();
            MI.textAlamat.Text = gridViewPelanggan.GetRowCellValue(gridViewPelanggan.FocusedRowHandle, "Alamat").ToString();
            MI.textTelepon.Text = gridViewPelanggan.GetRowCellValue(gridViewPelanggan.FocusedRowHandle, "Telepon").ToString();
            MI.textEmail.Text = gridViewPelanggan.GetRowCellValue(gridViewPelanggan.FocusedRowHandle, "Email").ToString();
            MI.textKeterangan.Text = gridViewPelanggan.GetRowCellValue(gridViewPelanggan.FocusedRowHandle, "Keterangan").ToString();
            if (MI.ShowDialog() == DialogResult.OK)
            {
                loadPelanggan();
            }
        }

        private void gridViewPelanggan_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            kodePelanggan = gridViewPelanggan.GetRowCellValue(gridViewPelanggan.FocusedRowHandle, "Kode").ToString();
        }
    }
}