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
        private DataTable dt;
        public ModalPembelian()
        {
            InitializeComponent();
            gridPembelian.DataSource = CreateTable(1);
            gridViewPembelian.Columns["Id"].Visible = false;
            gridPembelian.DataSource = dt;
        }

        private DataTable CreateTable(int RowCount)
        {
            dt = new DataTable();
            dt.Columns.Add("Id", Type.GetType("System.Int32"));
            dt.Columns.Add("Kode", Type.GetType("System.String"));
            dt.Columns.Add("Nama", Type.GetType("System.String"));
            dt.Columns.Add("Jumlah", Type.GetType("System.Int32"));
            dt.Columns.Add("Satuan", Type.GetType("System.String"));
            dt.Columns.Add("HargaBeli", Type.GetType("System.Double"));
            dt.Columns.Add("Diskon", Type.GetType("System.Double"));
            dt.Columns.Add("HargaBersih", Type.GetType("System.Double"));
            dt.Columns.Add("Total", Type.GetType("System.Double"));
            return dt;
        }
        private void ModalPembelian_Load(object sender, EventArgs e)
        {
            dateTanggal.DateTime = DateTime.Now;
            _lookKredit();
            _lookSupplier();
            _searchLookKode();
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
        public void _searchLookKode()
        {
            ListController lc = new ListController();
            DataTable dt = lc.gridvBarang();
            searchLookKode.Properties.DataSource = dt;
            searchLookKode.Properties.PopulateViewColumns();
            searchLookKode.Properties.DisplayMember = "Kode";
            searchLookKode.Properties.ValueMember = "Id";
            searchLookKode.Properties.View.Columns["Id"].Visible = false;
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
            spinBeli.Value = Convert.ToDecimal(HargaBeli);
            lookSatuan.Text = Satuan.ToString();

            double netto = Convert.ToDouble(spinBeli.Value - ((spinDisc.Value / 100) * spinBeli.Value));
            spinNetto.Value = Math.Round(Convert.ToDecimal(netto), 2);
            spinTotal.Value = spinNetto.Value * spinJumlah.Value;
        }
 
        private void spinJumlah_EditValueChanged(object sender, EventArgs e)
        {
            double netto = Convert.ToDouble(spinBeli.Value - ((spinDisc.Value / 100) * spinBeli.Value));
            spinNetto.Value = Math.Round(Convert.ToDecimal(netto), 2);
            spinTotal.Value = spinNetto.Value * spinJumlah.Value;
        }

        private void spinEdit6_EditValueChanged(object sender, EventArgs e)
        {
            double netto = Convert.ToDouble(spinBeli.Value - ((spinDisc.Value / 100) * spinBeli.Value));
            spinNetto.Value = Math.Round(Convert.ToDecimal(netto),2);
            spinTotal.Value = spinNetto.Value * spinJumlah.Value;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            
            //if (keyData == (Keys.Control | Keys.F)) #ctrl+f
            if (keyData == (Keys.Enter))
            {
                object Id = this.searchLookKode.Properties.View.GetFocusedRowCellValue("Id");
                object Satuan = lookSatuan.EditValue;
                if ((searchLookKode.Text != "" ) && (searchLookKode.Text != " ") && (textNama.Text != "") && (textNama.Text != " "))
                {
                    dt.Rows.Add(new object[]
                    {
                       (Int32)Id,
                       searchLookKode.Text,
                       textNama.Text,
                       (Int32)spinJumlah.Value,
                       lookSatuan.Text,
                       spinBeli.Value,
                       spinDisc.Value,
                       spinNetto.Value,
                       spinTotal.Value
                       
                });
                    gridViewPembelian.BestFitColumns();
                    //textSubCategory.Text = "";
                }
                else
                {
                    XtraMessageBox.Show("Silahkan lengkapi terlebih dahulu");
                }

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }

}