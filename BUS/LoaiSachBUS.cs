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
    public class LoaiSachBUS
    {
        DAL_QLCuaHangSach db;
        public LoaiSachBUS()
        {
            db = new DAL_QLCuaHangSach();
        }
        public DataSet getLoaiSach()
        {
            return db.ExecuteQueryDataSet("spGetLoaiSach", CommandType.StoredProcedure);
        }
        public DataSet findLoaiSachByIDAndName()
        {
            return db.ExecuteQueryDataSet("spFindLoaiSachByIDAndName", CommandType.StoredProcedure);
        }
        public bool insertLoaiSach(ref string err,
            String TenLoaiSach,
            DateTime NgayTao,
            DateTime NgayUpdate)
        {
            return db.MyExecuteNonQuery("spInsertLoaiSach", CommandType.StoredProcedure, ref err,
                new SqlParameter("@TenLoaiSach", TenLoaiSach),
                new SqlParameter("@NgayTao", NgayTao),
                new SqlParameter("@NgayUpdate", NgayUpdate));
        }
        public bool deleteLoaiSach(ref string err,
            long ID)
        {
            return db.MyExecuteNonQuery("spDeleteLoaiSach", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID", ID));
        }
        public bool updateLoaiSach(ref string err,
            long ID,
            String TenLoaiSach,
            DateTime NgayTao,
            DateTime NgayUpdate)
        {
            return db.MyExecuteNonQuery("spUpdateLoaiSach", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID", ID),
                new SqlParameter("@TenLoaiSach", TenLoaiSach),
                new SqlParameter("@NgayTao", NgayTao),
           
                new SqlParameter("@NgayUpdate", NgayUpdate));
        }
     
    }
}
