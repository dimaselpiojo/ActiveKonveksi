namespace ActiveKonveksi.Module
{
    partial class Barang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridBarang = new DevExpress.XtraGrid.GridControl();
            this.gridViewBarang = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // gridBarang
            // 
            this.gridBarang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBarang.Location = new System.Drawing.Point(0, 0);
            this.gridBarang.MainView = this.gridViewBarang;
            this.gridBarang.Name = "gridBarang";
            this.gridBarang.Size = new System.Drawing.Size(547, 410);
            this.gridBarang.TabIndex = 6;
            this.gridBarang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBarang});
            // 
            // gridViewBarang
            // 
            this.gridViewBarang.GridControl = this.gridBarang;
            this.gridViewBarang.Name = "gridViewBarang";
            this.gridViewBarang.OptionsBehavior.Editable = false;
            this.gridViewBarang.OptionsFind.AlwaysVisible = true;
            this.gridViewBarang.OptionsView.ColumnAutoWidth = false;
            this.gridViewBarang.OptionsView.ShowFooter = true;
            this.gridViewBarang.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewBarang_RowClick);
            this.gridViewBarang.DoubleClick += new System.EventHandler(this.gridViewBarang_DoubleClick);
            // 
            // Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 410);
            this.ControlBox = false;
            this.Controls.Add(this.gridBarang);
            this.Name = "Barang";
            this.Text = "Barang";
            this.Load += new System.EventHandler(this.Barang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridBarang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBarang;
    }
}