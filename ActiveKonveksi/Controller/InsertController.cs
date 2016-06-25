using ActiveKonveksi.Helper;
using ActiveKonveksi.Model;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveKonveksi.Controller
{
    public class InsertController
    {
        ADOHelper h = null;
        private string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        public InsertController()
        {
            h = new ADOHelper();
        }
        /* TABEL BARANG */
        #region Tabel Barang
        public OBJSQL SaveNewBarang(MBarang MBarang)
        {
            OBJSQL obj = null;
            List<MySqlParameter> sqlParam = new List<MySqlParameter>();
            sqlParam.Add(new MySqlParameter() { ParameterName = "@kode", MySqlDbType = MySqlDbType.VarChar, Value = MBarang.kode });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@nama", MySqlDbType = MySqlDbType.VarChar, Value = MBarang.nama });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@jumlah", MySqlDbType = MySqlDbType.Int32, Value = MBarang.jumlah });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@harga_beli", MySqlDbType = MySqlDbType.Decimal, Value = MBarang.harga_beli });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@harga_jual", MySqlDbType = MySqlDbType.Decimal, Value = MBarang.harga_jual });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@diskon", MySqlDbType = MySqlDbType.Int32, Value = MBarang.diskon });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@id_satuan_barang", MySqlDbType = MySqlDbType.Int32, Value = MBarang.id_satuan_barang });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@id_kategori_barang", MySqlDbType = MySqlDbType.Int32, Value = MBarang.id_kategori_barang });
            String SQLQuery =
                "INSERT INTO m_barang (kode, nama, jumlah, harga_beli, harga_jual, diskon, id_satuan_barang, id_kategori_barang) " +
                "VALUES (@kode, @nama, @jumlah, @harga_beli, @harga_jual, @diskon, @id_satuan_barang, @id_kategori_barang); ";
            obj = h.InsertQuery(SQLQuery, sqlParam);
            return obj;
        }
        public OBJSQL UpdateBarang(MBarang MBarang, string kode)
        {
            OBJSQL obj = null;
            List<MySqlParameter> sqlParam = new List<MySqlParameter>();
            sqlParam.Add(new MySqlParameter() { ParameterName = "@kode", MySqlDbType = MySqlDbType.VarChar, Value = MBarang.kode });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@nama", MySqlDbType = MySqlDbType.VarChar, Value = MBarang.nama });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@jumlah", MySqlDbType = MySqlDbType.Int32, Value = MBarang.jumlah });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@harga_beli", MySqlDbType = MySqlDbType.Decimal, Value = MBarang.harga_beli });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@harga_jual", MySqlDbType = MySqlDbType.Decimal, Value = MBarang.harga_jual });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@diskon", MySqlDbType = MySqlDbType.Int32, Value = MBarang.diskon });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@id_satuan_barang", MySqlDbType = MySqlDbType.Int32, Value = MBarang.id_satuan_barang });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@id_kategori_barang", MySqlDbType = MySqlDbType.Int32, Value = MBarang.id_kategori_barang });

            string SQLQuery = "UPDATE m_barang set kode=@kode, nama=@nama, jumlah=@jumlah, harga_beli=@harga_beli, harga_jual=@harga_jual, diskon=@diskon, id_satuan_barang=@id_satuan_barang, id_kategori_barang=@id_kategori_barang where kode= " + kode;
            obj = h.InsertQuery(SQLQuery, sqlParam);
            return obj;
        }
        #endregion
        /* ============================================================= */

        /* TABEL Supplier */
        #region Tabel Supplier
        public OBJSQL SaveNewSupplier(MSupplier MSupplier)
        {
            OBJSQL obj = null;
            List<MySqlParameter> sqlParam = new List<MySqlParameter>();
            sqlParam.Add(new MySqlParameter() { ParameterName = "@kode", MySqlDbType = MySqlDbType.VarChar, Value = MSupplier.kode });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@nama", MySqlDbType = MySqlDbType.VarChar, Value = MSupplier.nama });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@alamat", MySqlDbType = MySqlDbType.VarChar, Value = MSupplier.alamat });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@tlp", MySqlDbType = MySqlDbType.VarChar, Value = MSupplier.tlp });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@email", MySqlDbType = MySqlDbType.VarChar, Value = MSupplier.email });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@kontak", MySqlDbType = MySqlDbType.VarChar, Value = MSupplier.kontak });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@keterangan", MySqlDbType = MySqlDbType.VarChar, Value = MSupplier.keterangan });
            String SQLQuery =
                "INSERT INTO m_supplier (kode, nama, alamat, tlp, email, kontak, keterangan) " +
                "VALUES (@kode, @nama, @alamat, @tlp, @email, @kontak, @keterangan); ";
            obj = h.InsertQuery(SQLQuery, sqlParam);
            return obj;
        }
        public OBJSQL UpdateSupplier(MSupplier MSupplier, string kode)
        {
            OBJSQL obj = null;
            List<MySqlParameter> sqlParam = new List<MySqlParameter>();
            sqlParam.Add(new MySqlParameter() { ParameterName = "@kode", MySqlDbType = MySqlDbType.VarChar, Value = MSupplier.kode });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@nama", MySqlDbType = MySqlDbType.VarChar, Value = MSupplier.nama });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@alamat", MySqlDbType = MySqlDbType.VarChar, Value = MSupplier.alamat });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@tlp", MySqlDbType = MySqlDbType.VarChar, Value = MSupplier.tlp });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@email", MySqlDbType = MySqlDbType.VarChar, Value = MSupplier.email });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@kontak", MySqlDbType = MySqlDbType.VarChar, Value = MSupplier.kontak });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@keterangan", MySqlDbType = MySqlDbType.VarChar, Value = MSupplier.keterangan });

            string SQLQuery = "UPDATE m_supplier set kode=@kode, nama=@nama, alamat=@alamat, tlp=@tlp, email=@email, kontak=@kontak, keterangan=@keterangan where kode= " + kode;
            obj = h.InsertQuery(SQLQuery, sqlParam);
            return obj;
        }
        #endregion
        /* ============================================================= */

        /* TABEL Pelanggan */
        #region Tabel Pelanggan
        public OBJSQL SaveNewPelanggan(MPelanggan MPelanggan)
        {
            OBJSQL obj = null;
            List<MySqlParameter> sqlParam = new List<MySqlParameter>();
            sqlParam.Add(new MySqlParameter() { ParameterName = "@kode", MySqlDbType = MySqlDbType.VarChar, Value = MPelanggan.kode });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@nama", MySqlDbType = MySqlDbType.VarChar, Value = MPelanggan.nama });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@alamat", MySqlDbType = MySqlDbType.VarChar, Value = MPelanggan.alamat });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@tlp", MySqlDbType = MySqlDbType.VarChar, Value = MPelanggan.tlp });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@email", MySqlDbType = MySqlDbType.VarChar, Value = MPelanggan.email });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@keterangan", MySqlDbType = MySqlDbType.VarChar, Value = MPelanggan.keterangan });
            String SQLQuery =
                "INSERT INTO m_pelanggan (kode, nama, alamat, tlp, email, keterangan) " +
                "VALUES (@kode, @nama, @alamat, @tlp, @email, @keterangan); ";
            obj = h.InsertQuery(SQLQuery, sqlParam);
            return obj;
        }
        public OBJSQL UpdatePelanggan(MPelanggan MPelanggan, string kode)
        {
            OBJSQL obj = null;
            List<MySqlParameter> sqlParam = new List<MySqlParameter>();
            sqlParam.Add(new MySqlParameter() { ParameterName = "@kode", MySqlDbType = MySqlDbType.VarChar, Value = MPelanggan.kode });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@nama", MySqlDbType = MySqlDbType.VarChar, Value = MPelanggan.nama });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@alamat", MySqlDbType = MySqlDbType.VarChar, Value = MPelanggan.alamat });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@tlp", MySqlDbType = MySqlDbType.VarChar, Value = MPelanggan.tlp });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@email", MySqlDbType = MySqlDbType.VarChar, Value = MPelanggan.email });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@keterangan", MySqlDbType = MySqlDbType.VarChar, Value = MPelanggan.keterangan });

            string SQLQuery = "UPDATE m_pelanggan set kode=@kode, nama=@nama, alamat=@alamat, tlp=@tlp, email=@email, keterangan=@keterangan where kode= " + kode;
            obj = h.InsertQuery(SQLQuery, sqlParam);
            return obj;
        }
        #endregion
        /* ============================================================= */

        /* TABEL Pembelian */
        #region Tabel Pembelian
        public OBJSQL SaveNewPembelian(MPembelian MPembelian, GridView _gridview)
        {
            OBJSQL obj = null;
            List<MySqlParameter> sqlParam = new List<MySqlParameter>();
            sqlParam.Add(new MySqlParameter() { ParameterName = "@faktur", MySqlDbType = MySqlDbType.VarChar, Value = MPembelian.faktur });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@tanggal", MySqlDbType = MySqlDbType.DateTime, Value = MPembelian.tanggal.Date});
            sqlParam.Add(new MySqlParameter() { ParameterName = "@id_kredit_pembelian", MySqlDbType = MySqlDbType.Int32, Value = MPembelian.id_kredit_pembelian });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@jatuhtempo", MySqlDbType = MySqlDbType.DateTime, Value = MPembelian.jatuhtempo?.Date });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@id_supplier_pembelian", MySqlDbType = MySqlDbType.Int32, Value = MPembelian.id_supplier_pembelian });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@subtotal", MySqlDbType = MySqlDbType.Double, Value = MPembelian.subtotal });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@diskon", MySqlDbType = MySqlDbType.Int32, Value = MPembelian.diskon });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@grandtotal", MySqlDbType = MySqlDbType.Double, Value = MPembelian.grandtotal });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@tunai", MySqlDbType = MySqlDbType.Double, Value = MPembelian.tunai });
            sqlParam.Add(new MySqlParameter() { ParameterName = "@kembali", MySqlDbType = MySqlDbType.Double, Value = MPembelian.kembali });
            String SQLQuery = "INSERT INTO pembelian (faktur, tanggal, id_kredit_pembelian, jatuhtempo, id_supplier_pembelian, subtotal, diskon, grandtotal, tunai, kembali) " +
                                "VALUES (@faktur, @tanggal, @id_kredit_pembelian, @jatuhtempo, @id_supplier_pembelian, @subtotal, @diskon, @grandtotal, @tunai, @kembali); " +

                          
                            "SET @NEWID = LAST_INSERT_ID();";
            //"DECLARE @NEWID int;" +
            //"SET @NEWID = @@IDENTITY;";
            
            //  String SQLQuery = "";
            for (int i = 0; i < _gridview.RowCount; i++)
            {
                string brg = _gridview.GetRowCellValue(i, "id_barang_pembelian").ToString();
                string jum = _gridview.GetRowCellValue(i, "Jumlah").ToString();
                string sat = _gridview.GetRowCellValue(i, "id_satuan_pembelian").ToString();
                string bel = _gridview.GetRowCellValue(i, "HargaBeli").ToString();
                string dis = _gridview.GetRowCellValue(i, "Diskon").ToString();
                string ber = _gridview.GetRowCellValue(i, "HargaBersih").ToString();
                string tot = _gridview.GetRowCellValue(i, "Total").ToString();
                SQLQuery += "INSERT INTO detail_pembelian (id_pembelian_detail, id_barang_detail, jumlah, id_satuan_detail, hargabeli, diskon, hargabersih, total) " +
                            "VALUES (@NEWID, " +
                            "'" + _gridview.GetRowCellValue(i, "id_barang_pembelian").ToString() + "'," +
                            "'" + _gridview.GetRowCellValue(i, "Jumlah").ToString() + "'," +
                            "'" + _gridview.GetRowCellValue(i, "id_satuan_pembelian").ToString() + "'," +
                            "'" + _gridview.GetRowCellValue(i, "HargaBeli").ToString() + "'," +
                            "'" + _gridview.GetRowCellValue(i, "Diskon").ToString() + "'," +
                            "'" + _gridview.GetRowCellValue(i, "HargaBersih").ToString() + "'," +
                            "'" + _gridview.GetRowCellValue(i, "Total").ToString() + "'" +
                            ");";
            }
            obj = h.InsertQuery(SQLQuery, sqlParam);
            return obj;
        }
        #endregion
        /* ============================================================= */
    }
}
    