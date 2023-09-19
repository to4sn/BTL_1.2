using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class Ketnoi
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-CGDMGH31\\MSSQLSERVER2023;Initial Catalog=QL_THU_VIEN;Integrated Security=True");
        public DataTable Load(string sql)
        {
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dt.AcceptChanges();
            return dt;
        }
        public void Excecute(string sql)
        {
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dt.AcceptChanges();
            ad.Update(dt);
        }
    }
}
