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
    public class PhieuNhapBUS
    {

        DAL_QLCuaHangSach db;

        public PhieuNhapBUS()
        {
            db = new DAL_QLCuaHangSach();
        }

        public bool insertPhieuNhap(
            ref string err,
            long ID_NV,
            long ID_NXB,
            DateTime NgayNhap,
            long ThanhTien,
            DateTime ngaytao,
            DateTime ngayupdate)
        {
            return db.MyExecuteNonQuery("spInsertPhieuNhap", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID_NV", ID_NV),
                new SqlParameter("@ID_NXB", ID_NXB),
                new SqlParameter("@NgayNhap", NgayNhap),
                new SqlParameter("@ThanhTien", ThanhTien),
                new SqlParameter("@NgayTao", ngaytao),
                new SqlParameter("@NgayUpdate", ngayupdate));
        }

        public bool deletePhieuNhap(
            ref string err,
            string id)
        {
            return db.MyExecuteNonQuery("spDeletePhieuNhap", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID", id));
        }

        public bool updatePhieuNhap(ref string err,
            long id,
            long ID_NV,
            long ID_NXB,
            DateTime NgayNhap,
            long ThanhTien,
            DateTime ngayupdate)
        {
            return db.MyExecuteNonQuery("spUpdatePhieuNhap", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID", id),
                new SqlParameter("@ID_NV", ID_NV),
                new SqlParameter("@ID_NXB", ID_NXB),
                new SqlParameter("@NgayNhap", NgayNhap),
                new SqlParameter("@ThanhTien", ThanhTien),
                new SqlParameter("@NgayUpdate", ngayupdate));
        }

        public DataSet getPhieuNhap()
        {
            return db.ExecuteQueryDataSet("spGetPhieuNhap", CommandType.StoredProcedure);
        }

        public DataSet getLastRowInPhieuNhap()
        {
            return db.ExecuteQueryDataSet("spGetLastRowInPhieuNhap", CommandType.StoredProcedure);
        }

        public DataSet findPhieuNhap(DateTime NgayNhap)
        {
            return db.ExecuteQueryDataSet("spFindPhieuNhap", CommandType.StoredProcedure,
                new SqlParameter("@NgayNhap", NgayNhap));
        }
    }
}
