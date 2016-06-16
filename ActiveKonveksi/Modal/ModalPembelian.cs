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

namespace ActiveKonveksi.Modal
{
    public partial class ModalPembelian : DevExpress.XtraEditors.XtraForm
    {
        public ModalPembelian()
        {
            InitializeComponent();
        }

        private void ModalPembelian_Load(object sender, EventArgs e)
        {
            dateTanggal.DateTime = DateTime.Now;
            _lookKredit();
            _lookSupplier();
            _gridLookKode();
            _lookUpSatuan();
            spinDisc.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            spinJumlah.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
        }
        public void _lookKredit()
        {
            ListController lc = new ListController();
            DataTable dt = lc.gridTunaiKredit();
            lookTunaiKredit.Properties.DataSource = dt;
            lookTunaiKredit.Properties.DisplayMember = "Nama";
            lookTunaiKredit.Properties.ValueMember = "Id";
            lookTunaiKredit.Properties.PopulateColumns();
            lookTunaiKredit.Properties.Columns["Id"].Visible = false;
            lookTunaiKredit.Properties.AutoSearchColumnIndex = Convert.ToInt32(1);
            lookTunaiKredit.ItemIndex = 0;
            lookTunaiKredit.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
        }
        public void _lookSupplier()
        {
            ListController lc = new ListController();
            DataTable dt = lc.gridSupplier();
            lookSupplier.Properties.DataSource = dt;
            lookSupplier.Properties.DisplayMember = "Nama";
            lookSupplier.Properties.ValueMember = "Kode";
            lookSupplier.Properties.PopulateColumns();
            //lookSupplier.Properties.Columns["Kode"].Visible = false;
            lookSupplier.Properties.AutoSearchColumnIndex = Convert.ToInt32(1);
            lookSupplier.ItemIndex = 0;
            lookSupplier.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
        }
        public void _gridLookKode()
        {
            ListController lc = new ListController();
            DataTable dt = lc.gridvBarang();
            searchLookKode.Properties.DataSource = dt;
            searchLookKode.Properties.DisplayMember = "Nama";
            searchLookKode.Properties.ValueMember = "Kode";
            searchLookKode.Properties.PopupFindMode = FindMode.Always;
            searchLookKode.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
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

        private void searchLookKode_EditValueChanged(object sender, EventArgs e)
        {
            object Nama = this.searchLookKode.Properties.View.GetFocusedRowCellValue("Nama");
            object HargaBeli = this.searchLookKode.Properties.View.GetFocusedRowCellValue("HargaBeli");
            object Satuan = this.searchLookKode.Properties.View.GetFocusedRowCellValue("Satuan");
            textNama.Text = Nama.ToString();
            spinBeli.Value = (decimal)HargaBeli;
            lookSatuan.Text = Satuan.ToString();
        }

 
        private void spinJumlah_EditValueChanged(object sender, EventArgs e)
        {
            object jum = spinJumlah.Value;
            object dis = spinDisc.Value;
            spinNetto.Value = spinBeli.Value - ((spinDisc.Value / 100) * spinBeli.Value);
            spinTotal.Value = spinNetto.Value * spinJumlah.Value;
        }

        private void spinEdit6_EditValueChanged(object sender, EventArgs e)
        {
            object jum = spinJumlah.Value;
            object dis = spinDisc.Value;
            spinNetto.Value = spinBeli.Value - ((spinDisc.Value / 100) * spinBeli.Value);
            spinTotal.Value = spinNetto.Value * spinJumlah.Value;
        }

    }

}