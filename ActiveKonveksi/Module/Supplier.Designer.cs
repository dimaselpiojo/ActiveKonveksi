namespace ActiveKonveksi.Module
{
    partial class Supplier
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
            this.gridSupplier = new DevExpress.XtraGrid.GridControl();
            this.gridViewSupplier = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSupplier
            // 
            this.gridSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSupplier.Location = new System.Drawing.Point(0, 0);
            this.gridSupplier.MainView = this.gridViewSupplier;
            this.gridSupplier.Name = "gridSupplier";
            this.gridSupplier.Size = new System.Drawing.Size(407, 321);
            this.gridSupplier.TabIndex = 7;
            this.gridSupplier.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSupplier});
            // 
            // gridViewSupplier
            // 
            this.gridViewSupplier.GridControl = this.gridSupplier;
            this.gridViewSupplier.Name = "gridViewSupplier";
            this.gridViewSupplier.OptionsBehavior.Editable = false;
            this.gridViewSupplier.OptionsFind.AlwaysVisible = true;
            this.gridViewSupplier.OptionsView.ColumnAutoWidth = false;
            this.gridViewSupplier.OptionsView.ShowFooter = true;
            this.gridViewSupplier.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewSupplier_RowClick);
            this.gridViewSupplier.DoubleClick += new System.EventHandler(this.gridViewSupplier_DoubleClick);
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 321);
            this.ControlBox = false;
            this.Controls.Add(this.gridSupplier);
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridSupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSupplier;
    }
}