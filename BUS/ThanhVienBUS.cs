using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class ThanhVienBUS
    {
        DAL_QLCuaHangSach db;
        public ThanhVienBUS()
        {
            db = new DAL_QLCuaHangSach();
        }
        public DataSet getThanhVien()
        {
            return db.ExecuteQueryDataSet("spGetThanhVien", CommandType.StoredProcedure);
        }
        public DataSet getNameAndIdThanhVien()
        {
            return db.ExecuteQueryDataSet("spGetNameAndIdThanhVien", CommandType.StoredProcedure);
        }
        public DataSet getGiamGiaByTenThanhVien(string hoten)
        {
            return db.ExecuteQueryDataSet("spGetGiamGiaByTenThanhVien", CommandType.StoredProcedure,
                new SqlParameter("@HoTen", hoten));
        }
        public DataSet getGiamGiaByIDThanhVien(int id)
        {
            return db.ExecuteQueryDataSet("spGetGiamGiaByIDThanhVien", CommandType.StoredProcedure,
                new SqlParameter("@ID", id));
        }
        public bool insertThanhVien(ref string err,
            string hoten,
            string diachi,
            string sdt,
            long id_loaitv,
            DateTime ngaytao,
            DateTime ngayupdate)
        {
            return db.MyExecuteNonQuery("spInsertThanhVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@HoTen", hoten),
                new SqlParameter("@DiaChi", diachi),
                new SqlParameter("@SDT", sdt),
                new SqlParameter("@ID_LoaiTV", id_loaitv),
                new SqlParameter("@NgayTao", ngaytao),
                new SqlParameter("@NgayUpdate", ngayupdate));
        }
        public bool deleteThanhVien(ref string err,
            string id)
        {
            return db.MyExecuteNonQuery("spDeleteThanhVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID", id));
        }
        public bool updateThanhVien(ref string err,
            long id,
            string hoten,
            string diachi,
            string sdt,
            long id_loaitv,
            DateTime ngaytao,
            DateTime ngayupdate)
        {
            return db.MyExecuteNonQuery("spUpdateThanhVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID", id),
                new SqlParameter("@HoTen", hoten),
                new SqlParameter("@DiaChi", diachi),
                new SqlParameter("@SDT", sdt),
                new SqlParameter("@ID_LoaiTV", id_loaitv),
                new SqlParameter("@NgayTao", ngaytao),
                new SqlParameter("@NgayUpdate", ngayupdate));
        }
    }
}
