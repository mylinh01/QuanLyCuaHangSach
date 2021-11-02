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
      
        
        public DataSet findSachByName(string name)
        {
            // return db.ExecuteQueryDataSet("SELECT TenSach,GiaBan, SoLuongTonKho FROM Sach WHERE TenSach LIKE N'%" + name + "%'", CommandType.Text);
            return db.ExecuteQueryDataSet("spFindSachByName", CommandType.StoredProcedure, new SqlParameter("@TenSach", name));
        }

        public DataSet getSoSachTonKho(string name)
        {
            //return db.ExecuteQueryDataSet("SELECT SoLuongTonKho FROM Sach WHERE TenSach = N'" + name + "'", CommandType.Text);
            return db.ExecuteQueryDataSet("spGetSoSachTonKho", CommandType.StoredProcedure, new SqlParameter("@TenSach", name));
        }
        public DataSet getGiaBanByName(string name)
        {
            //return db.ExecuteQueryDataSet("SELECT SoLuongTonKho FROM Sach WHERE TenSach = N'" + name + "'", CommandType.Text);
            return db.ExecuteQueryDataSet("spGetGiaBanByName", CommandType.StoredProcedure, new SqlParameter("@TenSach", name));
        }
        public DataSet getIDSachByName(string name)
        {
            return db.ExecuteQueryDataSet("spGetIDSachByName", CommandType.StoredProcedure, new SqlParameter("@TenSach", name));
        }
    }
}
