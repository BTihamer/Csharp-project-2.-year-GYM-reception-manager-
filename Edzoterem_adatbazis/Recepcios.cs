using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edzoterem_adatbazis
{
    public class Recepcios
    {
        public int RecepciosID { get; set; }
        public string RecepciosNev { get; set; } = string.Empty;
        public int RecepciosNorma { get; set; }
        public string RecepciosProgram { get; set; }= string.Empty;
    }
}
