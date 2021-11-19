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
    public class TacGiaBUS
    {

        DAL_QLCuaHangSach db;

        public TacGiaBUS()
        {
            db = new DAL_QLCuaHangSach();
        }

        public DataSet getTacGia()
        {
            return db.ExecuteQueryDataSet("spGetTacGia", CommandType.StoredProcedure);
        }

        public bool insertTacGia(
            ref string err,
            string tentacgia,
            DateTime ngaytao,
            DateTime ngayupdate)
        {
            return db.MyExecuteNonQuery("spInsertTacGia", CommandType.StoredProcedure, ref err,
                new SqlParameter("@TenTacGia", tentacgia),
                new SqlParameter("@NgayTao", ngaytao),
                new SqlParameter("@NgayUpdate", ngayupdate));
        }

        public bool deleteTacGia(ref string err,
            long id)
        {
            return db.MyExecuteNonQuery("spDeleteTacGia", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID", id));
        }

        public bool updateTacGia(ref string err,
            long id,
            string tentacgia,
            DateTime ngayupdate)
        {
            return db.MyExecuteNonQuery("spUpdateTacGia", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID", id),
                new SqlParameter("@TenTacGia", tentacgia),
                new SqlParameter("@NgayUpdate", ngayupdate));
        }
    }
}
