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
    public partial class Ures : Form
    {
        public Ures()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Clock_label.Text = DateTime.Now.ToString("T");
        }

        private void Ures_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
