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
    public partial class Tag_torles : Form
    {
        public Tag_torles()
        {
            InitializeComponent();
        }

        private void Tag_torles_button_Click(object sender, EventArgs e)
        {
            var dataBase = new EdzoTeremDBService();
            int id=0;
            try
            {
                id = int.Parse(TagsagTorles_TagID_textBox.Text);
            }catch(System.FormatException) {
                MessageBox.Show("Kerlek toltsd ki a TextBox-t");
            }
            var tag=dataBase.GetTag(id);
            if (tag != null)
            {
                dataBase.deletTag(id);
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
                MessageBox.Show("Nem jo ID-t adott meg!", "Nincs ilyen ID");
            }
        }

        private void TagsagTorles_TagID_textBox_KeyPress(object sender, KeyPressEventArgs e)
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
