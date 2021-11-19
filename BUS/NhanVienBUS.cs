using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net.Mime;

namespace BUS
{
    public class NhanVienBUS
    {
        DAL_QLCuaHangSach db;
        public NhanVienBUS()
        {
            db = new DAL_QLCuaHangSach();
        }

        public DataSet getNhanVienByUsernameAndPassword(string username, string password)
        {
            try
            {
                return db.ExecuteQueryDataSet("spFindNhanVien",
                CommandType.StoredProcedure,
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password));
            } 
            catch
            {
                return null;
            }
        }

        public DataSet getNhanVienByID(int ID)
        {
            try
            {
                return db.ExecuteQueryDataSet("spFindNhanVienByID",
                    CommandType.StoredProcedure,
                    new SqlParameter("@ID", ID));
            }
            catch
            {
                return null;
            }
        }

        public DataSet getViewLuong()
        {
            return db.ExecuteQueryDataSet("spGetViewNhanVien", CommandType.StoredProcedure);
        }
        public DataSet getNhanVien()
        {
            return db.ExecuteQueryDataSet("spGetNhanVien", CommandType.StoredProcedure);
        }
        public DataSet getMaNV()
        {
            return db.ExecuteQueryDataSet("spGetMaNV", CommandType.StoredProcedure);
        }
        public DataSet getQuyen()
        {
            return db.ExecuteQueryDataSet("spGetQuyen", CommandType.StoredProcedure);
        }
        public DataTable getPassword(ref string err, string ID)
        {
            return db.ExecuteQueryDataTable("SELECT * FROM dbo.f_getPassword(@ID)", new SqlParameter("@ID", ID));
        }
        public DataTable searchTenNV(ref string err, string hoten)
        {
            return db.ExecuteQueryDataTable("SELECT * FROM dbo.f_TimKiemTenNV(@HoTen)", new SqlParameter("@HoTen", hoten));
        }

        public bool updateLuongNhanVien(ref string err, long id, long luong)
        {
            return db.MyExecuteNonQuery("spUpdateViewNhanVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID", id),
                new SqlParameter("@Luong", luong));
        }

        public bool updatePassword(ref string err, long id, string password, string newpassword)
        {
            return db.MyExecuteNonQuery("spUpdateMatKhau", CommandType.StoredProcedure, ref err, new SqlParameter("@ID", id), new SqlParameter("@Password", password), new SqlParameter("@NewPassword", newpassword));
        }

        public DataTable searchIDNV(ref string err, string ID)
        {
            return db.ExecuteQueryDataTable("SELECT * FROM dbo.f_TimKiemIDNV(@ID)", new SqlParameter("@ID", ID));
        }
        public DataTable searchUserNameNV(ref string err, string UserName)
        {
            return db.ExecuteQueryDataTable("SELECT * FROM dbo.f_TimKiemUserNameNV(@UserName)", new SqlParameter("@UserName", UserName));
        }

        public DataSet isExistNhanVien()
        {
            return db.ExecuteQueryDataSet("spIsExistNhanVien", CommandType.StoredProcedure);
        }

        public DataSet getNameAndIdNhanVien()
        {
            return db.ExecuteQueryDataSet("spGetNameAndIdNhanVien", CommandType.StoredProcedure);
        }

        public bool insertNhanVien(ref string err,
            string username,
            string quyen,
            string password,
            string hoten,
            string diachi,
            string sdt,
            long luong,
            Image hinhAnh,
            DateTime ngaytao,
            DateTime ngayupdate)
        {
            return db.MyExecuteNonQuery("spInsertNhanVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@Username", username),
                new SqlParameter("@Quyen", quyen),
                new SqlParameter("@Password", password),
                new SqlParameter("@HoTen", hoten),
                new SqlParameter("@DiaChi", diachi),
                new SqlParameter("@SDT", sdt),
                new SqlParameter("@Luong", luong),
                new SqlParameter("@HinhAnh", ImageToByteArray(hinhAnh)),
                new SqlParameter("@NgayTao", ngaytao),
                new SqlParameter("@NgayUpdate", ngayupdate));
        }

        public bool deleteNhanVien(
            ref string err,
            string id)
        {
            return db.MyExecuteNonQuery("spDeleteNhanVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID", id));
        }

        public bool updateNhanVien(ref string err,
            long id,
            string quyen,
            string username,
            string password,
            string hoten,
            string diachi,
            string sdt,
            long luong,
            Image hinhAnh,
            DateTime ngayupdate)
        {
            return db.MyExecuteNonQuery("spUpdateNhanVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID", id),
                new SqlParameter("@Quyen", quyen),
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password),
                new SqlParameter("@HoTen", hoten),
                new SqlParameter("@DiaChi", diachi),
                new SqlParameter("@SDT", sdt),
                new SqlParameter("@Luong", luong),
                new SqlParameter("@HinhAnh", ImageToByteArray(hinhAnh)),
                new SqlParameter("@NgayUpdate", ngayupdate));
        }

        private byte[] ImageToByteArray(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }
    }
}
