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
     public class ChiTietHoaDonBUS
    {
        DAL_QLCuaHangSach db;
        public ChiTietHoaDonBUS()
        {
            db = new DAL_QLCuaHangSach();
        }
        public DataSet getChiTietHoaDon()
        {
            return db.ExecuteQueryDataSet("spGetChiTietHoaDon", CommandType.StoredProcedure);
        }

        public bool insertChiTietHoaDon(ref string err,
           long ID_HD,
           long ID_Sach,
           int soluong,
           DateTime NgayTao,
           DateTime NgayUpdate)
        {
            return db.MyExecuteNonQuery("spInsertChiTietHoaDon", CommandType.StoredProcedure, ref err,
                 new SqlParameter("@ID_HD", ID_HD),
                new SqlParameter("@ID_Sach", ID_Sach),
                new SqlParameter("@SoLuong", soluong),
                new SqlParameter("@NgayTao", NgayTao),
                new SqlParameter("@NgayUpdate", NgayUpdate));
        }
        public bool deleteChiTietHoaDon(ref string err,
            long ID)
        {
            return db.MyExecuteNonQuery("spDeleteChiTietHoaDon", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID", ID));
        }
        public bool updateChiTietHoaDon(ref string err,
           long ID_HD,
           long ID_Sach,
           int soluong,
           DateTime NgayTao,
           DateTime NgayUpdate)
        {
            return db.MyExecuteNonQuery("spUpdateChiTietHoaDon", CommandType.StoredProcedure, ref err,
                 new SqlParameter("@ID_HD", ID_HD),
                new SqlParameter("@ID_Sach", ID_Sach),
                new SqlParameter("@SoLuong", soluong),
                new SqlParameter("@NgayTao", NgayTao),
                new SqlParameter("@NgayUpdate", NgayUpdate));
        }
    }
}
