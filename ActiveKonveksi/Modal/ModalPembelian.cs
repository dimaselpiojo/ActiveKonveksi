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
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using DevExpress.Data;
using ActiveKonveksi.Model;
using ActiveKonveksi.Helper;
using DevExpress.XtraGrid.Views.Grid;
using MySql.Data.MySqlClient;
using System.Configuration;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace ActiveKonveksi.Modal
{
    public partial class ModalPembelian : DevExpress.XtraEditors.XtraForm
    {
        private DataTable dt;
        public bool finished = false;
        public bool edit = false;
        public string kreditTunai,Supp,idPembelian = null;
        public DateTime? jatuhTempo = null;
        public ModalPembelian()
        {
            InitializeComponent();
            gridPembelian.DataSource = CreateTable(1);
            gridViewPembelian.Columns["id_barang_pembelian"].Visible = false;
            gridViewPembelian.Columns["id_supplier_pembelian"].Visible = false;
            gridViewPembelian.Columns["id_kredit_pembelian"].Visible = false;
            gridViewPembelian.Columns["id_satuan_pembelian"].Visible = false;
            gridPembelian.DataSource = dt;
            CreateUnboundColumn();


        }
        private void CreateUnboundColumn()
        {
            gridViewPembelian.Columns["Total"].DisplayFormat.FormatType = FormatType.Numeric;
            gridViewPembelian.Columns["Total"].SummaryItem.SummaryType = SummaryItemType.Sum;
            gridViewPembelian.Columns["Total"].SummaryItem.DisplayFormat = "Total = {0:n2}";
            
        }
        private DataTable CreateTable(int RowCount)
        {
            dt = new DataTable();
            dt.Columns.Add("id_barang_pembelian", Type.GetType("System.Int32"));
            dt.Columns.Add("id_supplier_pembelian", Type.GetType("System.Int32"));
            dt.Columns.Add("id_kredit_pembelian", Type.GetType("System.Int32"));
            dt.Columns.Add("id_satuan_pembelian", Type.GetType("System.Int32"));

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
        void controller(bool read, bool enable)
        {
            dateTanggal.Properties.ReadOnly = read;
            textFaktur.Properties.ReadOnly = read;
            lookTunaiKredit.Properties.ReadOnly = read;
            dateJatuhTempo.Properties.ReadOnly = read;
            lookSupplier.Properties.ReadOnly = read;
            searchLookKode.Properties.ReadOnly = read;
            spinJumlah.Properties.ReadOnly = read;
            spinBeli.Properties.ReadOnly = read;
            spinDisc.Properties.ReadOnly = read;
            gridPembelian.Enabled = enable;
            spinTotal.Properties.ReadOnly = read;
            btnOk.Enabled = enable;
            spinTunai.Properties.ReadOnly = read;
            spinKembalian.Properties.ReadOnly = read;
            btnAddSupplier.Enabled = enable;
        }
        private void ModalPembelian_Load(object sender, EventArgs e)
        {
            spinDisc.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            spinJumlah.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            spinTunai.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            _lookKredit();
            _lookSupplier();
            _searchLookKode();
            _lookUpSatuan();
            if (edit == false)
            {
                dateJatuhTempo.Enabled = false;
                dateTanggal.DateTime = DateTime.Now;
            }
            else
            {
                string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

                if (kreditTunai != null)
                {
                    lookTunaiKredit.Text = kreditTunai;
                }
                if (jatuhTempo != null)
                {
                    dateJatuhTempo.DateTime = Convert.ToDateTime(jatuhTempo);
                }
                lookSupplier.Text = Supp;

                object dataSource = gridPembelian.DataSource;
                this.gridPembelian.DataSource = null;
                this.gridPembelian.DataSource = this.CreateTable(1);
                using (MySqlConnection mySqlConnection = new MySqlConnection(ConString))
                {
                    using (MySqlCommand mySqlCommand = mySqlConnection.CreateCommand())
                    {
                        try
                        {
                            mySqlConnection.Open();
                            mySqlCommand.CommandText = "select * from vDetailPembelian where idPembelian = "+idPembelian;
                            using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
                            {
                                while (mySqlDataReader.Read())
                                {
                                    this.dt.Rows.Add(new object[]
                                    {
                                        mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("IdPembelian")),
                                        mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("IdSupplier")),
                                        mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("IdKredit")),
                                        mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("IdSatuan")),

                                        mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("Kode")),
                                        mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("Nama")),
                                        mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("Jumlah")),
                                        mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("Satuan")),
                                        mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("HargaBeli")),
                                        mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("Diskon")),
                                        mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("HargaBersih")),
                                        mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("Total"))

                                    });

                                }
                                spinTunai.Value = Convert.ToDecimal(mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("Tunai")));

                            }
                        }
                        catch (MySqlException ex)
                        {
                            XtraMessageBox.Show(ex.Message);

                        }
                        finally
                        {
                            if (mySqlConnection != null)
                            {
                                mySqlConnection.Close();
                                gridPembelian.ForceInitialize();
                                var test = gridViewPembelian.Columns["Total"].SummaryItem.SummaryValue;
                                gridViewPembelian.BestFitColumns();
                                spinSubTotal.Value = Math.Round(Convert.ToDecimal(test), 2);
                                spinGrandTotal.Value = spinSubTotal.Value;
                                spinKembalian.Value = spinTunai.Value - spinGrandTotal.Value;
                            }
                        }
                    }
                }
                controller(true, false);


            }
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
            lookSupplier.Properties.ValueMember = "Id";
            lookSupplier.Properties.PopulateColumns();
            lookSupplier.Properties.Columns["Id"].Visible = false;
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
                string comment = "";
                object id_barang_pembelian = this.searchLookKode.Properties.View.GetFocusedRowCellValue("Id");
                object id_supplier_pembelian = lookSupplier.EditValue;
                object id_kredit_pembelian = lookTunaiKredit.EditValue;
                object id_satuan_pembelian = lookSatuan.EditValue;

                if ((spinJumlah.Value != 0) && (searchLookKode.Text != "") && (searchLookKode.Text != " ") && (textNama.Text != "") && (textNama.Text != " ") && (textFaktur.Text != "") && (textFaktur.Text != " "))
                {
                    dt.Rows.Add(new object[]
                    {
                           (Int32)id_barang_pembelian,
                           (Int32)id_supplier_pembelian,
                           (Int32)id_barang_pembelian,
                           (Int32)id_satuan_pembelian,
                           searchLookKode.Text,
                           textNama.Text,
                           (Int32)spinJumlah.Value,
                           lookSatuan.Text,
                           spinBeli.Value,
                           spinDisc.Value,
                           spinNetto.Value,
                           spinTotal.Value
                    });
                    gridPembelian.ForceInitialize();
                    var test = gridViewPembelian.Columns["Total"].SummaryItem.SummaryValue;
                    gridViewPembelian.BestFitColumns();
                    spinSubTotal.Value = Math.Round(Convert.ToDecimal(test), 2);    
                    spinGrandTotal.Value = spinSubTotal.Value;
                    spinKembalian.Value = spinTunai.Value - spinGrandTotal.Value;

                    //clear
                    searchLookKode.Text = "";
                    spinJumlah.Value = 0;
                    textNama.Text = "";
                    spinBeli.Value = 0;
                    spinDisc.Value = 0;
                    spinNetto.Value = 0;
                    spinTotal.Value = 0;
                    dateJatuhTempo.Enabled = false;
                    /////////////////////
                }
                else
                {
                    if ((searchLookKode.Text == "") || (searchLookKode.Text == " "))
                    {
                        comment += "Silahkan pilih salah satu Kode/Barcode\n";
                    }
                    if ((textFaktur.Text == "") || (textFaktur.Text == " "))
                    {
                        comment += "Silahkan isi kolom faktur\n";
                    }
                    if (spinJumlah.Value == 0)
                    {
                        comment += "Silahkan isi kolom jumlah";
                    }
                    XtraMessageBox.Show(comment);
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void spinTunai_EditValueChanged(object sender, EventArgs e)
        {
            spinKembalian.Value = spinTunai.Value- spinGrandTotal.Value;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Int32 id_supplier_pembelian = Convert.ToInt32(lookSupplier.EditValue);
            Int32 id_kredit_pembelian = Convert.ToInt32(lookTunaiKredit.EditValue);
            Int32 id_satuan_pembelian = Convert.ToInt32(lookSatuan.EditValue);
            string comment = "";
            bool validation = true;
            DateTime? _jatuh = null;
            if (lookTunaiKredit.ItemIndex != 0)
            {
                _jatuh = dateJatuhTempo.DateTime;
            }

            if (!string.IsNullOrWhiteSpace(textFaktur.Text)) 
            {
                //jika tunai
                if ((lookTunaiKredit.ItemIndex == 0) && (spinKembalian.Value >=0 ))
                {
                    if (gridViewPembelian.RowCount > 0)
                    {
                        validation = true;
                        saveSupplier(textFaktur.Text, dateTanggal.DateTime, id_kredit_pembelian, id_supplier_pembelian, _jatuh, Convert.ToDouble(spinSubTotal.Value), 0, Convert.ToDouble(spinGrandTotal.Value), Convert.ToDouble(spinTunai.Value), Convert.ToDouble(spinKembalian.Value), gridViewPembelian);
                    }
                    else
                    {
                        validation = false;
                        comment += "Periksa kembali barang yang ada beli \n";
                    }
                }
                else if (lookTunaiKredit.ItemIndex > 0)
                {
                    validation = true;
                    saveSupplier(textFaktur.Text, dateTanggal.DateTime, id_kredit_pembelian, id_supplier_pembelian, _jatuh, Convert.ToDouble(spinSubTotal.Value), 0, Convert.ToDouble(spinGrandTotal.Value), Convert.ToDouble(spinTunai.Value), Convert.ToDouble(spinKembalian.Value), gridViewPembelian);
                }
                else
                {
                    validation = false;
                    comment += "Periksa kembali uang anda \n";
                }
            }
            else
            {
                validation = false;
                if (string.IsNullOrWhiteSpace(textFaktur.Text))
                {
                    validation = false;
                    comment += "No. Faktur harus diisi \n";
                }
                if (spinKembalian.Value < 0)
                {
                    validation = false;
                    comment += "Silahkan cek kembalian anda \n";
                }
                
            }
            if (!validation)
            {
                XtraMessageBox.Show(comment);
            }

        }

        private void saveSupplier(string _faktur, DateTime _tanggal, Int32 _id_kredit_pembelian, Int32 _id_supplier_pembelian,  DateTime? _jatuhtempo, double _subtotal, Int32 _diskon, double _grandtotal, double _tunai, double _kembali, GridView _gridview)
        {
            GlobalVar.Success = false;
            InsertController ic = new InsertController();
            ListController lc = new ListController();
            MPembelian i = new MPembelian()
            {
                faktur = _faktur,
                tanggal = _tanggal,
                id_kredit_pembelian = _id_kredit_pembelian,
                id_supplier_pembelian = _id_supplier_pembelian,
                jatuhtempo = _jatuhtempo,
                subtotal = _subtotal,
                diskon = _diskon,
                grandtotal = _grandtotal,
                tunai = _tunai,
                kembali = _kembali
            };
            OBJSQL obj = ic.SaveNewPembelian(i, _gridview);
            if (GlobalVar.Success)
            {
                textFaktur.Text = "";
                searchLookKode.Text = "";
                spinJumlah.Value = 0;
                textNama.Text = "";
                spinBeli.Value = 0;
                spinDisc.Value = 0;
                spinNetto.Value = 0;
                spinSubTotal.Value = 0;
                spinTotal.Value = 0;
                spinGrandTotal.Value = 0;
                spinTunai.Value = 0;
                spinKembalian.Value = 0;
                gridPembelian.DataSource = null;
                gridPembelian.DataSource = CreateTable(1);
                dateJatuhTempo.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void gridViewPembelian_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                contextMenuStrip1.Show(view.GridControl, e.Point);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridViewPembelian != null && gridViewPembelian.SelectedRowsCount != 0)
            {
                DataRow[] array = new DataRow[gridViewPembelian.SelectedRowsCount];
                for (int i = 0; i < gridViewPembelian.SelectedRowsCount; i++)
                {
                    array[i] = gridViewPembelian.GetDataRow(gridViewPembelian.GetSelectedRows()[i]);
                }
                gridViewPembelian.BeginSort();
                try
                {
                    DataRow[] array2 = array;
                    for (int j = 0; j < array2.Length; j++)
                    {
                        DataRow dataRow = array2[j];
                        dataRow.Delete();
                    }
                }
                finally
                {
                    gridViewPembelian.EndSort();
                }
            }
        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridPembelian.DataSource = null;
            gridPembelian.DataSource = this.CreateTable(1);
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            ModalSupplier MS = new ModalSupplier();
            if (MS.ShowDialog() == DialogResult.OK)
            {
                _lookSupplier();
            }
        }

        private void lookTunaiKredit_EditValueChanged(object sender, EventArgs e)
        {
            switch (lookTunaiKredit.ItemIndex)
            {
                case 0:
                    dateJatuhTempo.Enabled = false;
                    spinTunai.Enabled = true;
                    spinKembalian.Enabled = true;
                    break;
                case 1:
                    dateJatuhTempo.Enabled = true;
                    dateJatuhTempo.DateTime = DateTime.Now;
                    spinTunai.Enabled = false;
                    spinKembalian.Enabled = false;
                    break;
            }
        }
    }

}