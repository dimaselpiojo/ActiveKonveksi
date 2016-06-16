using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using ActiveKonveksi.Module;
using ActiveKonveksi.Controller;
using ActiveKonveksi.Modal;
using ActiveKonveksi.Helper;

namespace ActiveKonveksi
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
            InitTreeListControl();
            InitGrid();

        }
        Dashboard _Dashboard = null;
        Barang _Barang = null;
        Supplier _Supplier = null;
        Pelanggan _Pelanggan = null;
        void InitTreeListControl()
        {
            ListController lc = new ListController();
            DataTable dt = lc.gridMenus();
            treeNavigate.DataSource = dt;
            treeNavigate.PopulateColumns();
            treeNavigate.ExpandAll();
            treeNavigate.Columns["formname"].VisibleIndex = -1;
        }

        void DataBinding(Projects projects)
        {
           
        }
        void InitGrid()
        {
          
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (_Dashboard == null)
            {
                _Dashboard = new Dashboard();
                _Dashboard.MdiParent = this;

            }
            splashScreenManager1.ShowWaitForm();
            _Dashboard.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            _Dashboard.Show();
            splashScreenManager1.CloseWaitForm();
        }

        private void treeNavigate_Click(object sender, EventArgs e)
        {
            GlobalVar.TabSelected = treeNavigate.FocusedNode[treeNavigate.Columns[1]].ToString();
            switch (treeNavigate.FocusedNode[treeNavigate.Columns[1]].ToString())
            {
                case "Dashboard":
                    if (_Dashboard == null)
                    {
                        _Dashboard = new Dashboard();
                        _Dashboard.MdiParent = this;

                    }
                    splashScreenManager1.ShowWaitForm();
                    _Dashboard.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                    _Dashboard.Show();
                    splashScreenManager1.CloseWaitForm();
                   
                    break;
                case "Barang":
                    if (_Barang == null)
                    {
                        _Barang = new Barang();
                        _Barang.MdiParent = this;

                    }
                    splashScreenManager1.ShowWaitForm();
                    _Barang.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                    _Barang.Show();
                    splashScreenManager1.CloseWaitForm();

                    break;
                case "Supplier":
                    if (_Supplier == null)
                    {
                        _Supplier = new Supplier();
                        _Supplier.MdiParent = this;

                    }
                    splashScreenManager1.ShowWaitForm();
                    _Supplier.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                    _Supplier.Show();
                    splashScreenManager1.CloseWaitForm();

                    break;
                case "Pelanggan":
                    if (_Pelanggan == null)
                    {
                        _Pelanggan = new Pelanggan();
                        _Pelanggan.MdiParent = this;

                    }
                    splashScreenManager1.ShowWaitForm();
                    _Pelanggan.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                    _Pelanggan.Show();
                    splashScreenManager1.CloseWaitForm();

                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string _menus = GlobalVar.TabSelected;
            switch (_menus)
            {
                case "Barang":
                    ModalBarang MI = new ModalBarang();
                    if (MI.ShowDialog() == DialogResult.OK)
                    {
                        _Barang.loadBarang();
                    }
                    break;
                case "Supplier":
                    ModalSupplier MS = new ModalSupplier();
                    if (MS.ShowDialog() == DialogResult.OK)
                    {
                        _Supplier.loadSupplier();
                    }
                    break;
                case "Pelanggan":
                    ModalPelanggan MP = new ModalPelanggan();
                    if (MP.ShowDialog() == DialogResult.OK)
                    {
                        _Pelanggan.loadPelanggan();
                    }
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string _menus = GlobalVar.TabSelected;
            DeleteController ic = new DeleteController();
            DialogResult result1;
            OBJSQL obj = null;
            switch (_menus)
            {
                case "Barang":
                    result1 = XtraMessageBox.Show("Are you sure you want to delete ? ",
                                                "Important Question",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
                    if (result1 == DialogResult.Yes)
                    {
                        obj = ic.Delete("m_barang", "kode", _Barang.kodeBarang);
                        _Barang.loadBarang();
                    }
                    break;
                case "Supplier":
                    result1 = XtraMessageBox.Show("Are you sure you want to delete ? ",
                                                "Important Question",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
                    if (result1 == DialogResult.Yes)
                    {
                        obj = ic.Delete("m_supplier", "kode", _Supplier.kodeSupplier);
                        _Supplier.loadSupplier();
                    }
                    break;
                case "Pelanggan":
                    result1 = XtraMessageBox.Show("Are you sure you want to delete ? ",
                                                "Important Question",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
                    if (result1 == DialogResult.Yes)
                    {
                        obj = ic.Delete("m_pelanggan", "kode", _Pelanggan.kodePelanggan);
                        _Pelanggan.loadPelanggan();
                    }
                    break;
            }
        }
    }
}