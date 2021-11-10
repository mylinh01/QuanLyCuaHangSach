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
    public class ChiTietPhieuNhapBUS
    {
        DAL_QLCuaHangSach db;
        public ChiTietPhieuNhapBUS()
        {
            db = new DAL_QLCuaHangSach();
        }
        public DataSet getChiTietPhieuNhap()
        {
            return db.ExecuteQueryDataSet("spGetChiTietPhieuNhap", CommandType.StoredProcedure);
        }

        public bool insertChiTietPhieuNhap(ref string err,
            long id_pn,
            long id_sach,
            int soluong,
            long gianhap,
            DateTime ngaytao,
            DateTime ngayupdate)
        {
            return db.MyExecuteNonQuery("spInsertChiTietPhieuNhap", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID_PN", id_pn),
                new SqlParameter("@ID_Sach", id_sach),
                new SqlParameter("@SoLuong", soluong),
                new SqlParameter("@GiaNhap", gianhap ),
                new SqlParameter("@NgayTao", ngaytao),
                new SqlParameter("@NgayUpdate", ngayupdate));
        }
        public bool deleteChiTietPhieuNhap(ref string err,
            string id)
        {
            return db.MyExecuteNonQuery("spDeleteChiTietPhieuNhap", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID", id));
        }
        public bool updateChiTietPhieuNhap(ref string err,
            long id_pn,
            long id_sach,
            int soluong,
            long giatong,
            DateTime ngayupdate)
        {
            return db.MyExecuteNonQuery("spUpdateChiTietPhieuNhap", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID_PN", id_pn),
                new SqlParameter("@ID_Sach", id_sach),
                new SqlParameter("@SoLuong", soluong),
                new SqlParameter("@GiaNhap", giatong),
                new SqlParameter("@NgayUpdate", ngayupdate));
        }
        public DataSet xemCTPN(long ID)
        {
            return db.ExecuteQueryDataSet("spXemChiTietPhieuNhap", CommandType.StoredProcedure,
                new SqlParameter("@ID", ID));
        }

        /*
        public DataSet xemCTHD(long ID_HD)
        {
            return db.ExecuteQueryDataSet("select * from dbo.funXemChiTietPhieuNhap(@ID)", CommandType.StoredProcedure,
                new SqlParameter("@ID", ID_HD));
        }
       
        */
    }
}
