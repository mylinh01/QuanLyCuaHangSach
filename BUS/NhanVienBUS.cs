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
    public class NhanVienBUS
    {
        DAL_QLCuaHangSach db;
        public NhanVienBUS()
        {
            db = new DAL_QLCuaHangSach();
        }

        public DataSet getNhanVien()
        {
            return db.ExecuteQueryDataSet("spGetNhanVien", CommandType.StoredProcedure);
  
        }
        public DataSet getNameAndIdNhanVien()
        {
            return db.ExecuteQueryDataSet("spGetNameAndIdNhanVien", CommandType.StoredProcedure);
        }
        public bool insertNhanVien(ref string err, 
            string username, 
            string password, 
            string hoten, 
            string diachi, 
            string sdt, 
            long luong, 
            DateTime ngaytao, 
            DateTime ngayupdate)
        {
            return db.MyExecuteNonQuery("spInsertNhanVien", CommandType.StoredProcedure, ref err, 
                new SqlParameter("@Username", username), 
                new SqlParameter("@Password", password), 
                new SqlParameter("@HoTen", hoten),
                new SqlParameter("@DiaChi", diachi),
                new SqlParameter("@SDT", sdt),
                new SqlParameter("@Luong", luong),
                new SqlParameter("@NgayTao", ngaytao),
                new SqlParameter("@NgayUpdate", ngayupdate));
        }
        public bool deleteNhanVien(ref string err, 
            string id)
        {
            return db.MyExecuteNonQuery("spDeleteNhanVien", CommandType.StoredProcedure, ref err, 
                new SqlParameter("@ID", id));
        }
        public bool updateNhanVien(ref string err, 
            long id, 
            string username, 
            string password, 
            string hoten, 
            string diachi, 
            string sdt, 
            long luong, 
            DateTime ngaytao, 
            DateTime ngayupdate)
        {
            return db.MyExecuteNonQuery("spUpdateNhanVien", CommandType.StoredProcedure, ref err,
                 new SqlParameter("@ID", id),
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password),
                new SqlParameter("@HoTen", hoten),
                new SqlParameter("@DiaChi", diachi),
                new SqlParameter("@SDT", sdt),
                new SqlParameter("@Luong", luong),
                new SqlParameter("@NgayTao", ngaytao),
                new SqlParameter("@NgayUpdate", ngayupdate));
        }
       
    }
}
