namespace ActiveKonveksi.Modal
{
    partial class ModalSupplier
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.textEmail = new DevExpress.XtraEditors.TextEdit();
            this.textKode = new DevExpress.XtraEditors.TextEdit();
            this.textNama = new DevExpress.XtraEditors.TextEdit();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.textAlamat = new DevExpress.XtraEditors.TextEdit();
            this.textTelepon = new DevExpress.XtraEditors.TextEdit();
            this.textKontak = new DevExpress.XtraEditors.TextEdit();
            this.textKeterangan = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAlamat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTelepon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKontak.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKeterangan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textEmail);
            this.layoutControl1.Controls.Add(this.textKode);
            this.layoutControl1.Controls.Add(this.textNama);
            this.layoutControl1.Controls.Add(this.btnOk);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.textAlamat);
            this.layoutControl1.Controls.Add(this.textTelepon);
            this.layoutControl1.Controls.Add(this.textKontak);
            this.layoutControl1.Controls.Add(this.textKeterangan);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(339, 33, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(284, 231);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(71, 108);
            this.textEmail.Name = "textEmail";
            this.textEmail.Properties.Mask.BeepOnError = true;
            this.textEmail.Properties.Mask.EditMask = "[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,4}";
            this.textEmail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEmail.Properties.NullValuePrompt = "roni@globalmedia-solution.com";
            this.textEmail.Size = new System.Drawing.Size(201, 20);
            this.textEmail.StyleController = this.layoutControl1;
            this.textEmail.TabIndex = 17;
            // 
            // textKode
            // 
            this.textKode.Location = new System.Drawing.Point(71, 12);
            this.textKode.Name = "textKode";
            this.textKode.Size = new System.Drawing.Size(201, 20);
            this.textKode.StyleController = this.layoutControl1;
            this.textKode.TabIndex = 4;
            // 
            // textNama
            // 
            this.textNama.Location = new System.Drawing.Point(71, 36);
            this.textNama.Name = "textNama";
            this.textNama.Properties.NullValuePrompt = "Roni";
            this.textNama.Size = new System.Drawing.Size(201, 20);
            this.textNama.StyleController = this.layoutControl1;
            this.textNama.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(12, 197);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(127, 22);
            this.btnOk.StyleController = this.layoutControl1;
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "Save";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(143, 197);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 22);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            // 
            // textAlamat
            // 
            this.textAlamat.Location = new System.Drawing.Point(71, 60);
            this.textAlamat.Name = "textAlamat";
            this.textAlamat.Properties.NullValuePrompt = "Bandung";
            this.textAlamat.Size = new System.Drawing.Size(201, 20);
            this.textAlamat.StyleController = this.layoutControl1;
            this.textAlamat.TabIndex = 5;
            // 
            // textTelepon
            // 
            this.textTelepon.Location = new System.Drawing.Point(71, 84);
            this.textTelepon.Name = "textTelepon";
            this.textTelepon.Properties.NullValuePrompt = "0813134589";
            this.textTelepon.Size = new System.Drawing.Size(201, 20);
            this.textTelepon.StyleController = this.layoutControl1;
            this.textTelepon.TabIndex = 5;
            // 
            // textKontak
            // 
            this.textKontak.Location = new System.Drawing.Point(71, 132);
            this.textKontak.Name = "textKontak";
            this.textKontak.Properties.NullValuePrompt = "Syahroni";
            this.textKontak.Size = new System.Drawing.Size(201, 20);
            this.textKontak.StyleController = this.layoutControl1;
            this.textKontak.TabIndex = 5;
            // 
            // textKeterangan
            // 
            this.textKeterangan.Location = new System.Drawing.Point(71, 156);
            this.textKeterangan.Name = "textKeterangan";
            this.textKeterangan.Size = new System.Drawing.Size(201, 20);
            this.textKeterangan.StyleController = this.layoutControl1;
            this.textKeterangan.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem2,
            this.layoutControlItem10,
            this.layoutControlItem12,
            this.layoutControlItem13,
            this.layoutControlItem14,
            this.layoutControlItem3,
            this.layoutControlItem11,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(284, 231);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textKode;
            this.layoutControlItem1.CustomizationFormText = "Kode";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(264, 24);
            this.layoutControlItem1.Text = "Kode";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textNama;
            this.layoutControlItem2.CustomizationFormText = "Nama";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(264, 24);
            this.layoutControlItem2.Text = "Nama";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(56, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 168);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(264, 17);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnOk;
            this.layoutControlItem10.CustomizationFormText = "layoutControlItem10";
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 185);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(131, 26);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.textAlamat;
            this.layoutControlItem12.CustomizationFormText = "Alamat";
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(264, 24);
            this.layoutControlItem12.Text = "Alamat";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.textTelepon;
            this.layoutControlItem13.CustomizationFormText = "Telepon";
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(264, 24);
            this.layoutControlItem13.Text = "Telepon";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.textKontak;
            this.layoutControlItem14.CustomizationFormText = "Kontak";
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(264, 24);
            this.layoutControlItem14.Text = "Kontak";
            this.layoutControlItem14.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textKeterangan;
            this.layoutControlItem3.CustomizationFormText = "Keterangan";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(264, 24);
            this.layoutControlItem3.Text = "Keterangan";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.btnCancel;
            this.layoutControlItem11.CustomizationFormText = "layoutControlItem11";
            this.layoutControlItem11.Location = new System.Drawing.Point(131, 185);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(133, 26);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textEmail;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(264, 24);
            this.layoutControlItem4.Text = "Email";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(56, 13);
            // 
            // ModalSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 231);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ModalSupplier";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Supplier";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAlamat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTelepon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKontak.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKeterangan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        public DevExpress.XtraEditors.TextEdit textKode;
        public DevExpress.XtraEditors.TextEdit textNama;
        public DevExpress.XtraEditors.SimpleButton btnOk;
        public DevExpress.XtraEditors.SimpleButton btnCancel;
        public DevExpress.XtraEditors.TextEdit textAlamat;
        public DevExpress.XtraEditors.TextEdit textTelepon;
        public DevExpress.XtraEditors.TextEdit textKontak;
        public DevExpress.XtraEditors.TextEdit textKeterangan;
        public DevExpress.XtraEditors.TextEdit textEmail;
    }
}