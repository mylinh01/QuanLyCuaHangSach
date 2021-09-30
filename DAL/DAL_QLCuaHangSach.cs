﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_QLCuaHangSach
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adp;

        string strConnection = "Data Source=(local);Initial Catalog=QuanLyCuaHangSach;Integrated Security=True";

        public DAL_QLCuaHangSach()
        {
            conn = new SqlConnection(strConnection);
            cmd = conn.CreateCommand();
        }
        //select query
        public DataSet ExcuteQueryDataSet(string strSql, CommandType ct, params SqlParameter[] p)
        {
            cmd.CommandText = strSql;
            cmd.CommandType = ct;
            adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
        public string ExcuteQueryXML(string strSql, CommandType ct, params SqlParameter[] p)
        {
            cmd.CommandText = strSql;
            cmd.CommandType = ct;
            adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds.GetXml();
        }
        // action query
        public bool MyExcuteNonQuery(string strSql, CommandType ct, ref string error, params SqlParameter[] param)
        {
            bool check = false;
            conn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = strSql;
            cmd.CommandType = ct;
            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);
            try
            {
                cmd.ExecuteNonQuery();
                check = true;
            }
            catch (SqlException mess)
            {
                error = mess.Message;
            }
            finally
            {
                conn.Close();
            }
            return check;
        }
    }
}
