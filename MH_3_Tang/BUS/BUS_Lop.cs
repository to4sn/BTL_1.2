using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using DTO;
namespace BUS
{
    public class BUS_Lop
    {
        DAL_Lop lop = new DAL_Lop();
        public DataTable Load()
        {
            return lop.Load();
        }
        public void Insert(Lop ob) {
            lop.Insert(ob);
        }   
    }
}
