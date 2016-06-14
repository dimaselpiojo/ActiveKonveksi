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
        void InitTreeListControl()
        {
            ListController lc = new ListController();
            DataTable dt = lc.gridMenus();
            treeNavigate.DataSource = dt;
            treeNavigate.PopulateColumns();
            treeNavigate.ExpandAll();
            treeNavigate.Columns["FormName"].VisibleIndex = -1;
        }

        void DataBinding(Projects projects)
        {
           
        }
        BindingList<Person> gridDataList = new BindingList<Person>();
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
    }
}