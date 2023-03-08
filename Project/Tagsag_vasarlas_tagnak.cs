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
    public partial class Tagsag_vasarlas_tagnak : Form
    {
        public Tagsag_vasarlas_tagnak()
        {
            InitializeComponent();
        }

        private void Tagsag_vasarlas_button_Click(object sender, EventArgs e)
        {

            var dataBase = new EdzoTeremDBService();
            string valasztas = "";
            try
            {
                valasztas = listBox1.SelectedItem.ToString();
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Kerlek valasz ki egyet a ComboBox-bol");
            }
            int Tagsagid = 0;
            if (valasztas.Equals("Sima"))
            {
                Tagsagid = 1;
            }
            else if(valasztas.Equals("Edzos"))
            {
                Tagsagid = 2;
            }
            int Tagid = int.Parse(TagsagVasarlas_TagId_textBox.Text);
            var tmp=dataBase.GetTag(Tagid);
            if (tmp != null)
            {
                dataBase.updateTagsag(Tagid, Tagsagid);
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

        private void TagsagVasarlas_TagId_textBox_KeyPress(object sender, KeyPressEventArgs e)
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
