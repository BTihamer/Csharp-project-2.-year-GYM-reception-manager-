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
    public partial class Uj_Tagcs : Form
    {
        public Uj_Tagcs()
        {
            InitializeComponent();
        }

        private void Uj_tag_letrehoz_button_Click(object sender, EventArgs e)
        {
            string tag_neve = "";
            int tag_magassag = 0;
            int tag_tomeg = 0;
            int tag_eletkor = 0;
            try
            {
                tag_neve = UJ_tag_NEV_textBox.Text;
                tag_magassag = int.Parse(UJ_tag_Magassag_textBox2.Text);
                tag_tomeg = int.Parse(Uj_tag_Tomeg_textBox.Text);
                tag_eletkor = int.Parse(Uj_tag_Eletkor_textbox.Text);
            }catch(System.FormatException) {
                MessageBox.Show("Kerlek toltsd ki az osszes TextBox-t");
            }
            string combo_box_valasztas="";
            try
            {
                combo_box_valasztas = Uj_tag_tagsag_comboBox.SelectedItem.ToString();
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Kerlek valasz egyet a ComboBox-bol");
            }
            DateTime dateTime=DateTime.Now;
            DateTime toSend = new DateTime();
            int tagsag=0;
            if (combo_box_valasztas.Equals("Nincs"))
            {
                toSend=DateTime.MinValue;
                tagsag = 3;
            }
            else if(combo_box_valasztas.Equals("Edzos"))
            {
                toSend=dateTime.AddMonths(1);
                tagsag = 2;
            }
            else if (combo_box_valasztas.Equals("Sima"))
            {
                toSend=dateTime.AddMonths(1);
                tagsag = 1;
            }
            var dataBase = new EdzoTeremDBService();
            
                Tagok tmp = new Tagok
                {
                    TagsagID = tagsag,
                    TagNev = tag_neve,
                    TagMagassag = tag_magassag,
                    MagandedzoID = 0,
                    Tag_lejarati_datum = toSend,
                    Tag_SzekrenySzam = 0
                };
            dataBase.AddUjTag(tmp);
            FoKepernyo_valtozo_panel.Controls.Clear();
            Ures frm = new Ures();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            FoKepernyo_valtozo_panel.Controls.Add(frm);
            frm.Show();
        }

        private void UJ_tag_Magassag_textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)   //This statement accepts dot key. 
            {
                e.Handled = true;
                //MessageBox.Show("Only accept digital character or letter.");
            }
        }

        private void Uj_tag_Tomeg_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)   //This statement accepts dot key. 
            {
                e.Handled = true;
                //MessageBox.Show("Only accept digital character or letter.");
            }
        }

        private void Uj_tag_Eletkor_textbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Uj_tag_Eletkor_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)   //This statement accepts dot key. 
            {
                e.Handled = true;
                //MessageBox.Show("Only accept digital character or letter.");
            }
        }
    }
}
