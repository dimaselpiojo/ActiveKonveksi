using ActiveKonveksi.Helper;
using ActiveKonveksi.Model;
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
    }
}
    