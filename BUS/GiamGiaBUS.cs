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
    public class GiamGiaBUS
    {

        DAL_QLCuaHangSach db;
        public GiamGiaBUS()
        {
            db = new DAL_QLCuaHangSach();
        }

        public DataSet getGiamGia()
        {
            return db.ExecuteQueryDataSet("spGetGiamGia", CommandType.StoredProcedure);
        }
        public DataSet getGiamGiaByNgay(DateTime ngay)
        {
            //return db.ExecuteQueryDataSet("spGetGiamGiaByNgay", CommandType.StoredProcedure, new SqlParameter("@ngay", ngay));
            return db.ExecuteQueryDataSet("SELECT ID, NgayBatDau, NgayKetThuc, PhanTramGG" +
                " FROM  GiamGia WHERE NgayBatDau <= '" + ngay + "' AND  '" + ngay + "' <= NgayKetThuc", CommandType.Text);
        }
        public bool insertGiamGia(ref string err,
            DateTime NgayBatDau,
            DateTime NgayKetThuc,
            float PhanTramGG,
            DateTime NgayTao)
        {
            return db.MyExecuteNonQuery("spInsertGiamGia", CommandType.StoredProcedure, ref err,
                new SqlParameter("@NgayBatDau", NgayBatDau),
                new SqlParameter("@NgayKetThuc", NgayKetThuc),
                new SqlParameter("@PhanTramGG", PhanTramGG),
                new SqlParameter("@NgayTao", NgayTao));
        }
        public bool deleteGiamGia(ref string err,
            long ID)
        {
            return db.MyExecuteNonQuery("spDeleteGiamGia", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID", ID));
        }
        public bool updateLoaiThanhVien(ref string err,
            long ID,
            DateTime NgayBatDau,
            DateTime NgayKetThuc,
            float PhanTramGG,
            DateTime NgayUpdate)
        {
            return db.MyExecuteNonQuery("spUpdateGiamGia", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID", ID),
                new SqlParameter("@NgayBatDau", NgayBatDau),
                new SqlParameter("@NgayKetThuc", NgayKetThuc),
                new SqlParameter("@PhanTramGG", PhanTramGG),
                new SqlParameter("@NgayUpdate", NgayUpdate));
        }
    }
}
