using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using Microsoft.SqlServer.Server;

namespace DAL
{
    public class DAL_Lop : Ketnoi
    {
        public DataTable Load()
        {
            string sql = "select* from Lop";
            return Load(sql);
        }

        public void Insert(Lop lop)
        {
            string sql = "Insert into Lop values('" + lop.malop + "', '" + lop.tenlop + "')";
            Excecute(sql);
        }
    } 
}
