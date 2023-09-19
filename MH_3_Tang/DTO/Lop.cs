using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Lop
    {
        public string malop
        {
            get; set;
        }
        public string tenlop
        {
            get; set;
        }
        public Lop() { }

        public Lop(string malop, string tenlop)
        {
            this.malop = malop;
            this.tenlop = tenlop;
        }
    }
}
