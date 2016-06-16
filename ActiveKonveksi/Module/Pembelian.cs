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
            loadPembelian();
        }
        public void loadPembelian()
        {
            ListController lc = new ListController();
            DataTable dt = lc.gridvPembelian();
            gridPembelian.DataSource = dt;
            gridViewPembelian.PopulateColumns();
            gridViewPembelian.ShowEditor();
            gridViewPembelian.BestFitColumns();
        }
    }
}