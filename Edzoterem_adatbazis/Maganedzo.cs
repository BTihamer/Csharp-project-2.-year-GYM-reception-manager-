using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edzoterem_adatbazis
{
    public class Maganedzo
    {
        [Key]
        public int MaganedzoID { get; set; }
        public string MaganedzoNev { get; set; } = string.Empty;
        public int MaganedzoTagok_Szama { get; set; }
        public string MaganedzoEdzesProgram { get; set; } = string.Empty;
    }
}
