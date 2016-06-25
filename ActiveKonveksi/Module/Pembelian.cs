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
    public partial class Pembelian : DevExpress.XtraEditors.XtraForm
    {
        public Pembelian()
        {
            InitializeComponent();
        }

        private void Pembelian_Load(object sender, EventArgs e)
        {
            datePertama.DateTime = DateTime.Now;
            dateKedua.DateTime = DateTime.Now;
            
            loadPembelian();
            
        }
        public void loadPembelian()
        {
            ListController lc = new ListController();
            DataTable dt = lc.gridvPembelian(datePertama.DateTime, dateKedua.DateTime);
            gridPembelian.DataSource = dt;
            gridViewPembelian.PopulateColumns();
            gridViewPembelian.ShowEditor();
            gridViewPembelian.BestFitColumns();
        }

        private void gridViewPembelian_DoubleClick(object sender, EventArgs e)
        {
            ModalPembelian MPL = new ModalPembelian();
            MPL.edit = true;
            MPL.dateTanggal.DateTime = Convert.ToDateTime(gridViewPembelian.GetRowCellValue(gridViewPembelian.FocusedRowHandle, "Tanggal"));
            MPL.textFaktur.Text = gridViewPembelian.GetRowCellValue(gridViewPembelian.FocusedRowHandle, "Faktur").ToString();
            MPL.kreditTunai = gridViewPembelian.GetRowCellValue(gridViewPembelian.FocusedRowHandle, "TunaiKredit").ToString();
            object dateEdit = gridViewPembelian.GetRowCellValue(gridViewPembelian.FocusedRowHandle, "JatuhTempo");
            MPL.jatuhTempo = string.IsNullOrEmpty(dateEdit.ToString()) ? (DateTime?)null : DateTime.Parse(dateEdit.ToString());
            MPL.Supp = gridViewPembelian.GetRowCellValue(gridViewPembelian.FocusedRowHandle, "NamaSupplier").ToString();
            MPL.idPembelian = gridViewPembelian.GetRowCellValue(gridViewPembelian.FocusedRowHandle, "IdPembelian").ToString();
            MPL.ShowDialog();
        }

        private void datePertama_EditValueChanged(object sender, EventArgs e)
        {
            datePertama.Properties.MaxValue = dateKedua.DateTime;
            dateKedua.Properties.MinValue = datePertama.DateTime;
            loadPembelian();
        }

        private void dateKedua_EditValueChanged(object sender, EventArgs e)
        {
            datePertama.Properties.MaxValue = dateKedua.DateTime;
            dateKedua.Properties.MinValue = datePertama.DateTime;
            loadPembelian();
        }
    }
}