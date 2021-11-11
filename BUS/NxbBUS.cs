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
    public class NxbBUS
    {
        DAL_QLCuaHangSach db;
        public NxbBUS()
        {
            db = new DAL_QLCuaHangSach();
        }

        public DataSet getNXB()
        {
            return db.ExecuteQueryDataSet("spGetNXB", CommandType.StoredProcedure);
        }
        public bool insertNXB(ref string err,
            string tennxb,
            string diachi,
            string sdt,
            DateTime ngaytao,
            DateTime ngayupdate)
        {
            return db.MyExecuteNonQuery("spInsertNXB", CommandType.StoredProcedure, ref err,
                new SqlParameter("@TenNXB", tennxb),
                new SqlParameter("@DiaChi", diachi),
                new SqlParameter("@SDT", sdt),
                new SqlParameter("@NgayTao", ngaytao),
                new SqlParameter("@NgayUpdate", ngayupdate));
        }
        public bool deleteNXB(ref string err,
            long id)
        {
            return db.MyExecuteNonQuery("spDeleteNXB", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID", id));
        }
        public bool updateNXB(ref string err,
            long id,
            string tennxb,
            string diachi,
            string sdt,
            DateTime ngayupdate)
        {
            return db.MyExecuteNonQuery("spUpdateNXB", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID", id),
                new SqlParameter("@TenNXB", tennxb),
                new SqlParameter("@DiaChi", diachi),
                new SqlParameter("@SDT", sdt),
                new SqlParameter("@NgayUpdate", ngayupdate));
        }
    }
}

