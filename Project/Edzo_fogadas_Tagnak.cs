using Edzoterem_adatbazis;
using Microsoft.EntityFrameworkCore.Storage;
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
    public partial class Edzo_fogadas_Tagnak : Form
    {
        public Edzo_fogadas_Tagnak()
        {
            InitializeComponent();
        }

        private void Edzo_fogadas_tagnak_button_Click(object sender, EventArgs e)
        {

            var dataBase = new EdzoTeremDBService();
            int TagId = 0;
            try
            {
                TagId = int.Parse(UJ_tag_NEV_textBox.Text);
            }catch(System.FormatException) { }
            int EdzoId = listBox1.SelectedIndex;
            Tagok tag=dataBase.GetTag(TagId);
            ++EdzoId;
            if (tag != null)
            {
                if (tag.TagsagID == 3 || tag.TagsagID == 1)
                {
                    MessageBox.Show("Nincs Edzos abonament,eloszor edzos abonamentet kell vasarolni!", "Nincs Edzos abonament");
                }
                else
                {
                    dataBase.updateEdzo(TagId, EdzoId);
                    Edzes_fogadas_tagnak_label.Controls.Clear();
                    Ures frm = new Ures();
                    frm.TopLevel = false;
                    frm.Dock = DockStyle.Fill;
                    frm.FormBorderStyle = FormBorderStyle.None;
                    Edzes_fogadas_tagnak_label.Controls.Add(frm);
                    frm.Show();
                }
            }
            else 
            {
                MessageBox.Show("Nem adott meg jo ID-t!", "Nincs megadva jo ID");
                Edzes_fogadas_tagnak_label.Controls.Clear();
                Ures frm = new Ures();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                Edzes_fogadas_tagnak_label.Controls.Add(frm);
                frm.Show();
            }
        }

        private void UJ_tag_NEV_textBox_KeyPress(object sender, KeyPressEventArgs e)
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
