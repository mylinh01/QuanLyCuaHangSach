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
    public class HoaDonBUS
    {
        DAL_QLCuaHangSach db;
        public HoaDonBUS()
        {
            db = new DAL_QLCuaHangSach();
        }

        public DataSet getHoaDon()
        {
            return db.ExecuteQueryDataSet("spGetHoaDon", CommandType.StoredProcedure);
        }
        public DataSet getLastRowInHoaDon()
        {
            return db.ExecuteQueryDataSet("spGetLastRowInHoaDon", CommandType.StoredProcedure);
        }
        public DataSet findMonthOnHoaDon()
        {
            return db.ExecuteQueryDataSet("select * from findMonthOnHoaDon()", CommandType.Text);
        }
        public DataSet countTotalbyMonth()
        {
            return db.ExecuteQueryDataSet("spCountTotalbyMonth", CommandType.StoredProcedure);
        }

        public bool insertHoaDon(ref string err,
            long ID_NV,
            long ID_TV,
            long ID_GG,
            DateTime NgayMua,
            long ThanhTien,
            DateTime NgayTao,
            DateTime NgayUpdate)
        {
            return db.MyExecuteNonQuery("spInsertHoaDon", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID_NV", ID_NV),
                new SqlParameter("@ID_TV", ID_TV),
                new SqlParameter("@ID_GG", ID_GG),
                new SqlParameter("@NgayMua", NgayMua),
                new SqlParameter("@ThanhTien", ThanhTien),
              
                new SqlParameter("@NgayTao", NgayTao),
                new SqlParameter("@NgayUpdate", NgayUpdate));
        }
        public bool deleteHoaDon(ref string err,
            long ID)
        {
            return db.MyExecuteNonQuery("spDeleteHoaDon", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID", ID));
        }
        public bool updateHoaDon(ref string err,
            long ID,
            long ID_NV,
            long ID_TV,
            long ID_GG,
            DateTime NgayMua,
            long ThanhTien,
         
            DateTime NgayTao,
            DateTime NgayUpdate)
        {
            return db.MyExecuteNonQuery("spUpdateHoaDon", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID", ID),
                new SqlParameter("@ID_NV", ID_NV),
                new SqlParameter("@ID_TV", ID_TV),
                new SqlParameter("@ID_GG", ID_GG),
                new SqlParameter("@NgayMua", NgayMua),
                new SqlParameter("@ThanhTien", ThanhTien),
              
                new SqlParameter("@NgayTao", NgayTao),
                new SqlParameter("@NgayUpdate", NgayUpdate));
        }
    }
}
