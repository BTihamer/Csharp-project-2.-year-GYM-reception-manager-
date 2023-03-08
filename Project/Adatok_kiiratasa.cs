using Edzoterem_adatbazis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Adatok_kiiratasa : Form
    {
        public Adatok_kiiratasa()
        {
            InitializeComponent();
        }

        private void Home_button2_Click(object sender, EventArgs e)
        {
            FoKepernyo_valtozo_panel.Controls.Clear();
            Ures frm = new Ures();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            FoKepernyo_valtozo_panel.Controls.Add(frm);
            frm.Show();
        }

        private void Tagok_kiiratasa_Click(object sender, EventArgs e)
        {
            var dataBase=new EdzoTeremDBService();
            dataGridView1.Rows.Clear();
            List<Tagok> tagok = dataBase.getTagok();
            for(int i = 0; i < tagok.Count; ++i)
            {
                Tagok tag = tagok[i];
                int id = tag.TagID;
                string nev = tag.TagNev;
                string tagsag=" ";
                int tagsagid = tag.getTagsagID();
                if (tagsagid == 1)
                {
                    tagsag = "Sima";
                }else if(tagsagid == 2)
                {
                    tagsag = "Edzos";
                }
                else
                {
                    tagsag = "Nincs";
                }
                Maganedzo tmp=new Maganedzo
                {
                };
                string edzoneve =" ";
                int edzoid = tag.MagandedzoID;
                if (edzoid == 0)
                {
                    edzoneve = "Nincs";
                }else
                {
                    tmp = dataBase.GetMaganedzo(edzoid);
                    edzoneve = tmp.MaganedzoNev;
                }
                string datum;
                if (tag.Tag_lejarati_datum == DateTime.MinValue)
                {
                    datum = "-";
                }
                else
                {
                    datum = tag.Tag_lejarati_datum.ToString();
                }
                dataGridView1.Rows.Add(id,nev,tagsag,datum,edzoneve);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public async Task<int> KiadasokEredmeny()
        {
            var DataBase = new EdzoTeremDBService();
            int eredmeny=DataBase.getKiadasok();
            return eredmeny;
        }
        public async Task<int> TermelesEredmeny()
        {
            var DataBase = new EdzoTeremDBService();
            int eredmeny = DataBase.getJovedelem();
            return eredmeny;
        }
        public async Task<int> JovedelemEredmeny()
        {
            var DataBase = new EdzoTeremDBService();
            int eredmeny = DataBase.getJovedelem()-DataBase.getKiadasok();
            return eredmeny;
        }


        private async void Kiadasok_gomb_Click(object sender, EventArgs e)
        {
            int eredmeny = await KiadasokEredmeny();
            MessageBox.Show("A kiadasok:" + eredmeny, "KIADASOK");
        }

        private async void Jovedelem_Click(object sender, EventArgs e)
        {
            int eredmeny = await JovedelemEredmeny();
            MessageBox.Show("A jovedelem:" + eredmeny, "JOVEDELEM");
        }

        private async void Termeles_button_Click(object sender, EventArgs e)
        {
            int eredmeny = await TermelesEredmeny();
            MessageBox.Show("A termeles:" + eredmeny, "TERMELES");
        }
    }
}
