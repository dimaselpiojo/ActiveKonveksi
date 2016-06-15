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
    public partial class Supplier : DevExpress.XtraEditors.XtraForm
    {
        public string kodeSupplier;
        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            loadSupplier();
        }

        public void loadSupplier()
        {
            ListController lc = new ListController();
            DataTable dt = lc.gridSupplier();
            gridSupplier.DataSource = dt;
            gridViewSupplier.PopulateColumns();
            gridViewSupplier.ShowEditor();
            gridViewSupplier.BestFitColumns();
        }

        private void gridViewSupplier_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            kodeSupplier = gridViewSupplier.GetRowCellValue(gridViewSupplier.FocusedRowHandle, "Kode").ToString();

        }

        private void gridViewSupplier_DoubleClick(object sender, EventArgs e)
        {
            ModalSupplier MI = new ModalSupplier();
            MI.Text = "Edit Supplier";
            MI.btnOk.Text = "Update";
            MI.edit = true;
            MI.kode = gridViewSupplier.GetRowCellValue(gridViewSupplier.FocusedRowHandle, "Kode").ToString();
            //MI._lookUpKategori();
            //MI._lookUpSatuan();
            MI.textKode.Text = gridViewSupplier.GetRowCellValue(gridViewSupplier.FocusedRowHandle, "Kode").ToString();
            MI.textNama.Text = gridViewSupplier.GetRowCellValue(gridViewSupplier.FocusedRowHandle, "Nama").ToString();
            MI.textAlamat.Text = gridViewSupplier.GetRowCellValue(gridViewSupplier.FocusedRowHandle, "Alamat").ToString();
            MI.textTelepon.Text = gridViewSupplier.GetRowCellValue(gridViewSupplier.FocusedRowHandle, "Telepon").ToString();
            MI.textEmail.Text = gridViewSupplier.GetRowCellValue(gridViewSupplier.FocusedRowHandle, "Email").ToString();
            MI.textKontak.Text = gridViewSupplier.GetRowCellValue(gridViewSupplier.FocusedRowHandle, "Kontak").ToString();
            MI.textKeterangan.Text = gridViewSupplier.GetRowCellValue(gridViewSupplier.FocusedRowHandle, "Keterangan").ToString();
            if (MI.ShowDialog() == DialogResult.OK)
            {
                loadSupplier();
            }
        }
    }
}