using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SachBUS
    {

        DAL_QLCuaHangSach db;

        public SachBUS()
        {
            db = new DAL_QLCuaHangSach();
        }

        public DataSet getSach()
        {
            return db.ExecuteQueryDataSet("spGetSach", CommandType.StoredProcedure);
        }

        public bool insertSach(
            ref string err,
            string TenSach,
            long ID_LoaiSach,
            long ID_NXB,
            long ID_TacGia,
            long GiaBan,
            long SoLuongTonKho,
            DateTime ngaytao,
            DateTime ngayupdate)
        {
            return db.MyExecuteNonQuery("spInsertSach", CommandType.StoredProcedure, ref err,
                new SqlParameter("@TenSach", TenSach),
                new SqlParameter("@ID_LoaiSach", ID_LoaiSach),
                new SqlParameter("@ID_NXB", ID_NXB),
                new SqlParameter("@ID_TacGia", ID_TacGia),
                new SqlParameter("@GiaBan", GiaBan),
                new SqlParameter("@SoLuongTonKho", SoLuongTonKho),
                new SqlParameter("@NgayTao", ngaytao),
                new SqlParameter("@NgayUpdate", ngayupdate));
        }

        public bool deleteSach(
            ref string err,
            long id)
        {
            return db.MyExecuteNonQuery("spDeleteSach", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID", id));
        }

        public bool updateSach(
            ref string err,
            long id,
            string TenSach,
            long ID_LoaiSach,
            long ID_NXB,
            long ID_TacGia,
            long GiaBan,
            int SoLuongTonKho,
            DateTime ngayupdate)
        {
            return db.MyExecuteNonQuery("spUpdateSach", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID", id),
                new SqlParameter("@TenSach", TenSach),
                new SqlParameter("@ID_LoaiSach", ID_LoaiSach),
                new SqlParameter("@ID_NXB", ID_NXB),
                new SqlParameter("@ID_TacGia", ID_TacGia),
                new SqlParameter("@GiaBan", GiaBan),
                new SqlParameter("@SoLuongTonKho", SoLuongTonKho),
                new SqlParameter("@NgayUpdate", ngayupdate));
        }

        public DataSet findSach(string keyword)
        {
            return db.ExecuteQueryDataSet("spFindSach", CommandType.StoredProcedure,
                new SqlParameter("@TenSach", keyword),
                new SqlParameter("@TenLoaiSach", keyword),
                new SqlParameter("@TenTacGia", keyword),
                new SqlParameter("@TenNXB", keyword));
        }

        public DataSet findSachByLoaiSach(string name)
        {
            return db.ExecuteQueryDataSet("spFindSachByLoaiSach", CommandType.StoredProcedure,
                new SqlParameter("@TenLoaiSach", name));
        }

        public DataSet findSachByName(string name)
        {
            // return db.ExecuteQueryDataSet("SELECT TenSach,GiaBan, SoLuongTonKho FROM Sach WHERE TenSach LIKE N'%" + name + "%'", CommandType.Text);
            return db.ExecuteQueryDataSet("spFindSachByName", CommandType.StoredProcedure,
                new SqlParameter("@TenSach", name));
        }

        public DataSet getSoSachTonKho(string name)
        {
            //return db.ExecuteQueryDataSet("SELECT SoLuongTonKho FROM Sach WHERE TenSach = N'" + name + "'", CommandType.Text);
            return db.ExecuteQueryDataSet("spGetSoSachTonKho", CommandType.StoredProcedure,
                new SqlParameter("@TenSach", name));
        }

        public DataSet getGiaBanByName(string name)
        {
            //return db.ExecuteQueryDataSet("SELECT SoLuongTonKho FROM Sach WHERE TenSach = N'" + name + "'", CommandType.Text);
            return db.ExecuteQueryDataSet("spGetGiaBanByName", CommandType.StoredProcedure,
                new SqlParameter("@TenSach", name));
        }

        public DataSet getIDSachByName(string name)
        {
            return db.ExecuteQueryDataSet("spGetIDSachByName", CommandType.StoredProcedure,
                new SqlParameter("@TenSach", name));
        }

        public DataSet getSachByIDNXB(long idnxb)
        {
            return db.ExecuteQueryDataSet("spGetSachByIDNXB", CommandType.StoredProcedure,
                new SqlParameter("@ID_NXB", idnxb));
        }
    }
}
