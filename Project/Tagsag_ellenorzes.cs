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
    public partial class Tagsag_ellenorzes : Form
    {
        public Tagsag_ellenorzes()
        {
            InitializeComponent();
        }

        private void TagId_label_Click(object sender, EventArgs e)
        {

        }

        private void Edzo_fogadas_tagnak_button_Click(object sender, EventArgs e)
        {
            var dataBase = new EdzoTeremDBService();
            int id = 0;
            try
            {
                id = int.Parse(TagsagEllenorzes_TagID_textBox.Text);
            }catch(System.FormatException) {
                MessageBox.Show("Kerlek toltsd ki a TextBox-ot");
            }
            var tag= dataBase.GetTag(id);
            if (tag != null)
            {
                if (tag.Tag_lejarati_datum.CompareTo(DateTime.Now) < 0)
                {
                    MessageBox.Show("Le van jarva a berles vagy nincs is!", "Nem mehet be!");
                }
                else if (DateTime.Now.CompareTo(tag.Tag_lejarati_datum) < 0)
                {
                    MessageBox.Show("Bemehet, van aktiv abonament!", "Bemehet");
                }
                FoKepernyo_valtozo_panel.Controls.Clear();
                Ures frm = new Ures();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                FoKepernyo_valtozo_panel.Controls.Add(frm);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Nem adott meg jo ID-t!", "Nem jo az ID!");
            }
        }

        private void TagsagEllenorzes_TagID_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)   //This statement accepts dot key. 
            {
                e.Handled = true;
                //MessageBox.Show("Only accept digital character or letter.");
            }
        }

        private void TagsagEllenorzes_TagID_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
