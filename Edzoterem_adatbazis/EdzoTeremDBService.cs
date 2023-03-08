
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Edzoterem_adatbazis
{
    public class EdzoTeremDBService
    {
        public int getJovedelem()
        {
            int eredmeny = 0;
            var dataBase = new EdzoTeremDBService();
            List<Tagok> tagok = dataBase.getTagok();
            for (int i = 0; i < tagok.Count; ++i)
            {
                Tagok tmp = tagok[i];
                if (tmp.TagsagID == 1)
                {
                    eredmeny = eredmeny + 150;
                }
                else if (tmp.TagsagID == 2) {
                    eredmeny = eredmeny + 300;
                }
                else
                {
                }
            }
                return eredmeny;
        }
        public int getKiadasok()
        {
            var dataBase = new EdzoTeremDBService();
            int eredmeny = 0;
            List<Recepcios> receipciosok = dataBase.getRecepciosok();
            List<Maganedzo> maganedzok = dataBase.getMaganedzok();
            List<Takarito> takaritok = dataBase.getTakarito();
            for(int i = 0; i < receipciosok.Count; ++i)
            {
                Recepcios tmp = receipciosok[i];
                if (tmp.RecepciosNorma.Equals("Nappali"))
                {
                    eredmeny = eredmeny + 500;
                }
                else if (tmp.RecepciosNorma.Equals("Esti")){
                    eredmeny = eredmeny + 500;
                }
                else
                {
                    eredmeny = eredmeny + 1000;
                }
            }
            for (int i = 0; i < maganedzok.Count; ++i)
            {
                Maganedzo tmp = maganedzok[i];
                if (tmp.MaganedzoEdzesProgram.Equals("Nappali"))
                {
                    eredmeny = eredmeny + 750;
                }
                else if (tmp.MaganedzoEdzesProgram.Equals("Esti"))
                {
                    eredmeny = eredmeny +750;
                }
                else
                {
                    eredmeny = eredmeny + 1500;
                }
            }
            for (int i = 0; i < takaritok.Count; ++i)
            {
                Takarito tmp = takaritok[i];
                if (tmp.TakaritoNorma.Equals("Nappali"))
                {
                    eredmeny = eredmeny + 350;
                }
                else if (tmp.TakaritoNorma.Equals("Esti"))
                {
                    eredmeny = eredmeny + 350;
                }
                else
                {
                    eredmeny = eredmeny + 700;
                }
            }
            return eredmeny;
        }
        public bool deletTag(int id)
        {
            using (var dataBase = new Edzoterem_adatbazisDBContext())
            {
                var data = (from u1 in dataBase.Tagok where u1.TagID == id select u1).FirstOrDefault();
                if (data != null)
                {
                    dataBase.Tagok.Remove(data);
                    dataBase.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        public void updateEdzo(int id, int EdzoID)
        {
            using (var dataBase = new Edzoterem_adatbazisDBContext())
            {
                var data = (from u1 in dataBase.Tagok where u1.TagID == id select u1).FirstOrDefault();
                if (data != null)
                {
                    data.MagandedzoID = EdzoID;
                    dataBase.SaveChanges();
                }
            }
        }
        public bool updateTagsag(int Tagid,int TagsagId)
        {
            using (var dataBase = new Edzoterem_adatbazisDBContext())
            {
                DateTime most = DateTime.Now;
                DateTime egyhonap = DateTime.MinValue;
                egyhonap= most.AddMonths(1);
                var data = (from u1 in dataBase.Tagok where u1.TagID == Tagid select u1).FirstOrDefault();
                if(data != null){
                    data.TagsagID = TagsagId;
                    dataBase.SaveChanges();
                    var data2 = (from u1 in dataBase.Tagok where u1.TagID == Tagid select u1).FirstOrDefault();
                    data2.Tag_lejarati_datum = egyhonap;
                    dataBase.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public void updateTagsagIdo(int Tagid, int hosszabitas)
        {
            using (var dataBase = new Edzoterem_adatbazisDBContext())
            {
                var data = (from u1 in dataBase.Tagok where u1.TagID == Tagid select u1).FirstOrDefault();
                DateTime toSend = DateTime.Now;
                DateTime toSend2=DateTime.MinValue;
                if (hosszabitas == 1)
                {
                    toSend2= toSend.AddMonths(1);
                }
                else if (hosszabitas == 2)
                {
                    toSend2= toSend.AddMonths(2);
                }
                else if(hosszabitas == 3)
                {
                    toSend2= toSend.AddMonths(3);
                }
                data.Tag_lejarati_datum = toSend2;
                dataBase.SaveChanges();
            }
        }
        public void AddUjTag(Tagok ujtag)
        {
            using (var dataBase = new Edzoterem_adatbazisDBContext())
            {
                dataBase.Tagok.Add(ujtag);
                dataBase.SaveChanges();
            }
        }
        public void AddUjMaganedzo(Maganedzo ujmaganedzo)
        {
            using (var dataBase = new Edzoterem_adatbazisDBContext())
            {
                dataBase.Maganedzok.Add(ujmaganedzo);
                dataBase.SaveChanges();
            }
        }
        public void AddUjTagsag(Tagsag ujtagsag)
        {
            using (var dataBase = new Edzoterem_adatbazisDBContext())
            {
                dataBase.Tagsagok.Add(ujtagsag);
                dataBase.SaveChanges();
            }
        }
        public void AddUjRecepcios(Recepcios ujrecepcios)
        {
            using (var dataBase = new Edzoterem_adatbazisDBContext())
            {
                dataBase.Recepciosok.Add(ujrecepcios);
                dataBase.SaveChanges();
            }
        }
        public void AddUjTakarito(Takarito ujtakarito)
        {
            using (var dataBase = new Edzoterem_adatbazisDBContext())
            {
                dataBase.Takaritok.Add(ujtakarito);
                dataBase.SaveChanges();
            }
        }
        public List<Tagok> getTagok()
        {
            using (var dataBase = new Edzoterem_adatbazisDBContext())
            {
                var values = (from u1 in dataBase.Tagok where u1.TagID > 0 select u1);
                List<Tagok> tagoklista = new List<Tagok>(); ;
                foreach (var item in values)
                {
                    tagoklista.Add(new Tagok
                    {
                        TagID = item.TagID,
                        TagNev = item.TagNev,
                        TagMagassag = item.TagMagassag,
                        MagandedzoID = item.MagandedzoID,
                        TagsagID = item.TagsagID,
                        Tag_SzekrenySzam = item.Tag_SzekrenySzam,
                        Tag_lejarati_datum = item.Tag_lejarati_datum
                    }); ;
                }
                return tagoklista;
            }
        }
            public List<Maganedzo> getMaganedzok()
            {
                using (var dataBase = new Edzoterem_adatbazisDBContext())
                {
                    var values =
                    from u in dataBase.Maganedzok
                    where u.MaganedzoID > 0
                    select new
                    {
                        MaganedzoNev = u.MaganedzoNev,
                        MaganedzoTagok_Szama = u.MaganedzoTagok_Szama,
                        MaganedzoEdzesProgram = u.MaganedzoEdzesProgram
                    };
                    List<Maganedzo> maganedzoklista = new List<Maganedzo>(); ;
                    foreach (var item in values)
                    {
                        maganedzoklista.Add(new Maganedzo
                        {
                            MaganedzoNev = item.MaganedzoNev,
                            MaganedzoTagok_Szama = item.MaganedzoTagok_Szama,
                            MaganedzoEdzesProgram = item.MaganedzoEdzesProgram
                        }); ;
                    }
                    return maganedzoklista;
                }
            }
        public List<Takarito> getTakarito()
        {
            using (var dataBase = new Edzoterem_adatbazisDBContext())
            {
                var values =
                from u in dataBase.Takaritok
                where u.TakaritoID > 0
                select new
                {
                    TakaritoNev = u.TakaritoNev,
                    TakaritoNorma = u.TakaritoNorma,
                    TakaritoProgram = u.TakaritoProgram,
                };
                List<Takarito> Takaritoklista = new List<Takarito>(); ;
                foreach (var item in values)
                {
                    Takaritoklista.Add(new Takarito
                    {
                        TakaritoNev = item.TakaritoNev,
                        TakaritoNorma = item.TakaritoNorma,
                        TakaritoProgram = item.TakaritoProgram,
                    }); ;
                }
                return Takaritoklista;
            }
        }

            public List<Recepcios> getRecepciosok()
            {
                using (var dataBase = new Edzoterem_adatbazisDBContext())
                {
                    var values =
                    from u in dataBase.Recepciosok
                    where u.RecepciosID > 0
                    select new
                    {
                        RecepciosNev = u.RecepciosNev,
                        RecepciosNorma = u.RecepciosNorma,
                        RecepciosProgram = u.RecepciosProgram
                    };
                    List<Recepcios> Recepciosoklista = new List<Recepcios>(); ;
                    foreach (var item in values)
                    {
                        Recepciosoklista.Add(new Recepcios
                        {
                            RecepciosNev = item.RecepciosNev,
                            RecepciosNorma = item.RecepciosNorma,
                            RecepciosProgram = item.RecepciosProgram
                        }); ;
                    }
                    return Recepciosoklista;
                }
            }
        public void DeleteTag(int id)
        {
            using (var dataBase = new Edzoterem_adatbazisDBContext())
            {
                var user = (from u1 in dataBase.Tagok where u1.TagID == id select u1).FirstOrDefault();
                if (user != null)
                {
                    dataBase.Tagok.Remove(user);
                    dataBase.SaveChanges();
                }
            }
        }

        public Tagsag GetTagsag(int id)
        {
            using (var dataBase = new Edzoterem_adatbazisDBContext())
            {
                return dataBase.Tagsagok
                       .Where(u => u.TagsagID == id)
                       .Select(u => new Tagsag
                       {
                           TagsagTipus= u.TagsagTipus
                       }).First();
            }
        }
        public Tagok GetTag(int id)
        {
            try
            {
                using (var dataBase = new Edzoterem_adatbazisDBContext())
                {
                    return dataBase.Tagok
                           .Where(item => item.TagID == id)
                           .Select(item => new Tagok
                           {
                               TagNev = item.TagNev,
                               TagMagassag = item.TagMagassag,
                               MagandedzoID = item.MagandedzoID,
                               TagsagID = item.TagsagID,
                               Tag_SzekrenySzam = item.Tag_SzekrenySzam,
                               Tag_lejarati_datum = item.Tag_lejarati_datum
                           }).First();
                }
            }
            catch (System.InvalidOperationException)
            {
                return null;
            }
        }
        public Maganedzo GetMaganedzo(int id)
        {
            using (var dataBase = new Edzoterem_adatbazisDBContext())
            {
                return (from u1 in dataBase.Maganedzok where u1.MaganedzoID == id select u1).FirstOrDefault();
            }
        }
    }
} 