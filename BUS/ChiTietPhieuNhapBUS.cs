﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;
namespace BUS
{
    public class ChiTietPhieuNhapBUS
    {
        DAL_QLCuaHangSach db;
        public ChiTietPhieuNhapBUS()
        {
            db = new DAL_QLCuaHangSach();
        }
        public DataSet getChiTietPhieuNhap()
        {
            return db.ExecuteQueryDataSet("spGetChiTietPhieuNhap", CommandType.StoredProcedure);
        }

        public bool insertChiTietPhieuNhap(ref string err,
            long id_pn,
            long id_sach,
            int soluong,
            long giatong,
            DateTime ngaytao,
            DateTime ngayupdate)
        {
            return db.MyExecuteNonQuery("spInsertChiTietPhieuNhap", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID_PN", id_pn),
                new SqlParameter("@ID_Sach", id_sach),
                new SqlParameter("@SoLuong", soluong),
                new SqlParameter("@GiaTong", giatong),
                new SqlParameter("@NgayTao", ngaytao),
                new SqlParameter("@NgayUpdate", ngayupdate));
        }
        public bool deleteChiTietPhieuNhap(ref string err,
            string id)
        {
            return db.MyExecuteNonQuery("spDeleteChiTietPhieuNhap", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID", id));
        }
        public bool updateChiTietPhieuNhap(ref string err,
            long id_pn,
            long id_sach,
            int soluong,
            long giatong,
            DateTime ngaytao,
            DateTime ngayupdate)
        {
            return db.MyExecuteNonQuery("spUpdateChiTietPhieuNhap", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID_PN", id_pn),
                new SqlParameter("@ID_Sach", id_sach),
                new SqlParameter("@SoLuong", soluong),
                new SqlParameter("@GiaTong", giatong),
                new SqlParameter("@NgayTao", ngaytao),
                new SqlParameter("@NgayUpdate", ngayupdate));
        }
    }
}
