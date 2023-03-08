using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Edzoterem_adatbazis
{
    public class Tagok
    {
        [Key]
        public int TagID { get; set; }
        public string TagNev { get; set; } = string.Empty;
        public int TagMagassag { get; set; }

        [ForeignKey(nameof(TagsagID))]
        public int TagsagID { get; set; }
        public Tagsag Tagsagok { get; set; }

        public int MagandedzoID { get; set; }
        public int Tag_SzekrenySzam { get; set; }
        public DateTime Tag_lejarati_datum { get; set; }
        public int getTagsagID() { return TagsagID; }
        public int  getTagID() { return TagID; }
    }
}
