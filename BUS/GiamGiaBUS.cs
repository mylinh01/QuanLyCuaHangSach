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
            return db.ExecuteQueryDataSet("spGetGiamGiaByNgay", CommandType.StoredProcedure,
                new SqlParameter("@ngay", ngay));
        }

        public bool insertGiamGia(
            string TieuDe,
            float PhanTramGG,
            DateTime NgayBatDau,
            DateTime NgayKetThuc,
            string GhiChu,
            DateTime NgayTao,
            DateTime NgayUpdate
            )
        {
            return db.MyExecuteNonQueryNotReturnErr("spInsertGiamGia", CommandType.StoredProcedure,
                new SqlParameter("@TieuDe", TieuDe),
                new SqlParameter("@PhanTramGG", PhanTramGG),
                new SqlParameter("@NgayBatDau", NgayBatDau),
                new SqlParameter("@NgayKetThuc", NgayKetThuc),
                new SqlParameter("@GhiChu", GhiChu),
                new SqlParameter("@NgayTao", NgayTao),
                new SqlParameter("@NgayUpdate", NgayUpdate));
        }

        public bool deleteGiamGia(
            ref string err,
            long ID)
        {
            return db.MyExecuteNonQuery("spDeleteGiamGia", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID", ID));
        }

        public bool updateGiamGia(
            long ID,
            string TieuDe,
            float PhanTramGG,
            DateTime NgayBatDau,
            DateTime NgayKetThuc,
            string GhiChu,
            DateTime NgayUpdate
            )
        {
            return db.MyExecuteNonQueryNotReturnErr("spUpdateGiamGia", CommandType.StoredProcedure,
                new SqlParameter("@ID", ID),
                new SqlParameter("@TieuDe", TieuDe),
                new SqlParameter("@PhanTramGG", PhanTramGG),
                new SqlParameter("@NgayBatDau", NgayBatDau),
                new SqlParameter("@NgayKetThuc", NgayKetThuc),
                new SqlParameter("@GhiChu", GhiChu),
                new SqlParameter("@NgayUpdate", NgayUpdate));
        }
    }
}
