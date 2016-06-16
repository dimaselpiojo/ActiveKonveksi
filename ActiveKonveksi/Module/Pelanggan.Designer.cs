namespace ActiveKonveksi.Module
{
    partial class Pelanggan
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
            this.gridPelanggan = new DevExpress.XtraGrid.GridControl();
            this.gridViewPelanggan = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridPelanggan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPelanggan)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPelanggan
            // 
            this.gridPelanggan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPelanggan.Location = new System.Drawing.Point(0, 0);
            this.gridPelanggan.MainView = this.gridViewPelanggan;
            this.gridPelanggan.Name = "gridPelanggan";
            this.gridPelanggan.Size = new System.Drawing.Size(440, 376);
            this.gridPelanggan.TabIndex = 8;
            this.gridPelanggan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPelanggan});
            // 
            // gridViewPelanggan
            // 
            this.gridViewPelanggan.GridControl = this.gridPelanggan;
            this.gridViewPelanggan.Name = "gridViewPelanggan";
            this.gridViewPelanggan.OptionsBehavior.Editable = false;
            this.gridViewPelanggan.OptionsFind.AlwaysVisible = true;
            this.gridViewPelanggan.OptionsView.ColumnAutoWidth = false;
            this.gridViewPelanggan.OptionsView.ShowFooter = true;
            this.gridViewPelanggan.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewPelanggan_RowClick);
            this.gridViewPelanggan.DoubleClick += new System.EventHandler(this.gridViewPelanggan_DoubleClick);
            // 
            // Pelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 376);
            this.ControlBox = false;
            this.Controls.Add(this.gridPelanggan);
            this.Name = "Pelanggan";
            this.Text = "Pelanggan";
            this.Load += new System.EventHandler(this.Pelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPelanggan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPelanggan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridPelanggan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPelanggan;
    }
}