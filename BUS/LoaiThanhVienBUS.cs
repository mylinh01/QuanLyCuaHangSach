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
    public class LoaiThanhVienBUS
    {
        DAL_QLCuaHangSach db;
        public LoaiThanhVienBUS()
        {
            db = new DAL_QLCuaHangSach();
        }

        public DataSet getLoaiThanhVien()
        {
            return null;
        }

        public bool insertLoaiThanhVien(ref string err,
            string tenloaiTV,
            float mucuudai,
            DateTime ngaytao,
            DateTime ngayupdate)
        {
            return db.MyExecuteNonQuery("spInsertLoaiThanhVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@TenLoaiTV", tenloaiTV),
                new SqlParameter("@MucUuDai", mucuudai),
                new SqlParameter("@NgayTao", ngaytao),
                new SqlParameter("@NgayUpdate", ngayupdate));
        }
        public bool deleteLoaiThanhVien(ref string err,
            string id)
        {
            return db.MyExecuteNonQuery("spDeleteLoaiThanhVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID", id));
        }
        public bool updateLoaiThanhVien(ref string err,
            long id,
            string tenloaiTV,
            float mucuudai,
            DateTime ngaytao,
            DateTime ngayupdate)
        {
            return db.MyExecuteNonQuery("spUpdateLoaiThanhVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID", id),
                new SqlParameter("@TenLoaiTV", tenloaiTV),
                new SqlParameter("@MucUuDai", mucuudai),
                new SqlParameter("@NgayTao", ngaytao),
                new SqlParameter("@NgayUpdate", ngayupdate));
        }
    }
}
