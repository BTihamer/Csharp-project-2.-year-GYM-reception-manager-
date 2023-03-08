using Edzoterem_adatbazis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Tagsag_hosszabitas : Form
    {
        public Tagsag_hosszabitas()
        {
            InitializeComponent();
        }

        private void Uj_tag_letrehoz_button_Click(object sender, EventArgs e)
        {
            var dataBase = new EdzoTeremDBService();
            int id=0;
            try
            {
                id = int.Parse(TagsagHosszabittas_TagID_textBox.Text);
            }catch(System.FormatException) {
                MessageBox.Show("Kerlek toltsd ki a TextBox-t");
            }
            int id2 = 0;
            var gyerek = dataBase.GetTag(id);
            if (gyerek != null)
            {
                int info = listBox1.SelectedIndex;
                if (info == 0)
                {
                    id2 = 1;
                }
                else if (info == 1)
                {
                    id2 = 2;
                }
                else if (info == 2)
                {
                    id2 = 3;
                }
                if (gyerek.TagsagID == 3)
                {
                    MessageBox.Show("Nincs Tagsag vasarolva nem lehet hosszabitani!", "Nincs tagsag");
                }
                else
                {
                    dataBase.updateTagsagIdo(id, id2);
                }
                FoKepernyo_valtozo_panel.Controls.Clear();
                Ures frm = new Ures();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                FoKepernyo_valtozo_panel.Controls.Add(frm);
                frm.Show();
            }
            else {
                MessageBox.Show("Nem adott meg jo ID-t", "Nincs ilyen ID-ju Tag");
            }
        }

        private void TagsagHosszabittas_TagID_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)   //This statement accepts dot key. 
            {
                e.Handled = true;
                //MessageBox.Show("Only accept digital character or letter.");
            }
        }

        private void FoKepernyo_valtozo_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
