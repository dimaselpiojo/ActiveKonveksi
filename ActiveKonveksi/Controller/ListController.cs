using ActiveKonveksi.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveKonveksi.Controller
{
    public class ListController
    {
        /* Tabel Menu */
        #region Tabel Menu
        public DataTable gridMenus()
        {
            string SQL = "SELECT Menuid ID, name, formname , idarrange Grup from menu ";
            ADOHelper h = new ADOHelper();
            DataTable dt = h.ListByQuery(SQL);
            return dt;
        }
        #endregion
        /*===================================*/
        /* Tabel Barang */
        #region Tabel Barang
        public DataTable gridvBarang()
        {
            string SQL = "SELECT Id, Kode, Nama, Kategori, Jumlah, Satuan, HargaBeli, HargaJual, Diskon from vbarang ";
            ADOHelper h = new ADOHelper();
            DataTable dt = h.ListByQuery(SQL);
            return dt;
        }
        #endregion
        /*===================================*/
        /* Tabel Kategori */
        #region Tabel Kategori
        public DataTable gridKategori()
        {
            string SQL = "SELECT id_kategori, Nama from m_kategori ";
            ADOHelper h = new ADOHelper();
            DataTable dt = h.ListByQuery(SQL);
            return dt;
        }
        #endregion
        /*===================================*/
        /* Tabel Satuan */
        #region Tabel Satuan
        public DataTable gridSatuan()
        {
            string SQL = "SELECT id_satuan, Nama from m_satuan ";
            ADOHelper h = new ADOHelper();
            DataTable dt = h.ListByQuery(SQL);
            return dt;
        }
        #endregion
        /*===================================*/
        /* Tabel Supplier */
        #region Tabel Supplier
        public DataTable gridSupplier()
        {
            string SQL = "SELECT id_supplier Id, kode Kode, nama Nama, alamat Alamat, tlp Telepon, Email, Kontak, Keterangan from m_supplier ";
            ADOHelper h = new ADOHelper();
            DataTable dt = h.ListByQuery(SQL);
            return dt;
        }
        #endregion
        /*===================================*/
        /* Tabel Pelanggan */
        #region Tabel Pelanggan
        public DataTable gridPelanggan()
        {
            string SQL = "SELECT kode Kode, nama Nama, alamat Alamat, tlp Telepon, Email, rating_transaksi RatingTransaksi, rating_akumulasi RatingAkumulasi, Keterangan from m_pelanggan ";
            ADOHelper h = new ADOHelper();
            DataTable dt = h.ListByQuery(SQL);
            return dt;
        }
        #endregion
        /*===================================*/
        /* Tabel Pembelian */
        #region Tabel Pembelian
        public DataTable gridvPembelian()
        {
            string SQL = "SELECT * from vPembelian ";
            ADOHelper h = new ADOHelper();
            DataTable dt = h.ListByQuery(SQL);
            return dt;
        }

        public DataTable gridvPembelian(DateTime pertama, DateTime kedua)
        {
            pertama = pertama.Date;
            kedua = kedua.Date;
            string SQL = "SELECT * from vPembelian where tanggal between STR_TO_DATE('" + pertama+ "','%m/%d/%Y') and STR_TO_DATE('" + kedua+ "','%m/%d/%Y')";
            ADOHelper h = new ADOHelper();
            DataTable dt = h.ListByQuery(SQL);
            return dt;
        }
        #endregion
        /*===================================*/
        /* Tabel Tunai Kredit */
        #region Tabel Tunai Kredit
        public DataTable gridTunaiKredit()
        {
            string SQL = "SELECT id_kredit Id, Nama from kredit ";
            ADOHelper h = new ADOHelper();
            DataTable dt = h.ListByQuery(SQL);
            return dt;
        }
        #endregion
        /*===================================*/
    }
}
