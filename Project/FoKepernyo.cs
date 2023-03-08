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
    public partial class FoKepernyo : Form
    {
        public FoKepernyo()
        {
            InitializeComponent();
            FoKepernyo_valtozo_panel.Controls.Clear();
            Ures frm = new Ures();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            FoKepernyo_valtozo_panel.Controls.Add(frm);
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FoKepernyo_valtozo_panel.Controls.Clear();
            Tag_torles frm = new Tag_torles();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            FoKepernyo_valtozo_panel.Controls.Add(frm);
            frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FoKepernyo_valtozo_panel.Controls.Clear();
            Uj_Tagcs frm = new Uj_Tagcs();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            FoKepernyo_valtozo_panel.Controls.Add(frm);
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Uj_tag_letrehoz_button_Click(object sender, EventArgs e)
        {
        }
        private void button8_Click(object sender, EventArgs e)
        {
            FoKepernyo_valtozo_panel.Controls.Clear();
            Edzo_fogadas_Tagnak frm = new Edzo_fogadas_Tagnak();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            FoKepernyo_valtozo_panel.Controls.Add(frm);
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FoKepernyo_valtozo_panel.Controls.Clear();
            Ures frm = new Ures();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            FoKepernyo_valtozo_panel.Controls.Add(frm);
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FoKepernyo_valtozo_panel.Controls.Clear();
            Tagsag_hosszabitas frm = new Tagsag_hosszabitas();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            FoKepernyo_valtozo_panel.Controls.Add(frm);
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FoKepernyo_valtozo_panel.Controls.Clear();
            Adatok_kiiratasa frm = new Adatok_kiiratasa();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            FoKepernyo_valtozo_panel.Controls.Add(frm);
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FoKepernyo_valtozo_panel.Controls.Clear();
            Tagsag_vasarlas_tagnak frm = new Tagsag_vasarlas_tagnak();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            FoKepernyo_valtozo_panel.Controls.Add(frm);
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FoKepernyo_valtozo_panel.Controls.Clear();
            Tagsag_ellenorzes frm = new Tagsag_ellenorzes();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            FoKepernyo_valtozo_panel.Controls.Add(frm);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            FoKepernyo_valtozo_panel.Size = new Size(998, 521);
            FoKepernyo_valtozo_panel.Location = new Point(0, 0);
            FoKepernyo_valtozo_panel.Controls.Clear();
            LoginAblak frm = new LoginAblak();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            FoKepernyo_valtozo_panel.Controls.Add(frm);
            frm.Show();
        }
    }
}
