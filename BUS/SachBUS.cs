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
        
        public DataSet findSachByName(string name)
        {
            return db.ExecuteQueryDataSet("SELECT TenSach,GiaBan, SoLuongTonKho FROM Sach WHERE TenSach LIKE N'%" + name + "%'", CommandType.Text);
        }
        public DataSet getSoSachTonKho(string name)
        {
            return db.ExecuteQueryDataSet("SELECT SoLuongTonKho FROM Sach WHERE TenSach = N'" + name + "'", CommandType.Text);
        }
    }
}
