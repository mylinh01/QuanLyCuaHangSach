using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
     public class SachBUS
    {
        DAL_QLCuaHangSach db;
        public SachBUS()
        {
            db = new DAL_QLCuaHangSach();
        }
        public DataSet getSach()
        {
            return db.ExecuteQueryDataSet("spGetSach", CommandType.StoredProcedure);
        }
        public DataSet getSachForSearch()
        {
            return db.ExecuteQueryDataSet("spGetSachForSearch", CommandType.StoredProcedure);
        }
    }
}
