using Edzoterem_adatbazis;

namespace Project
{
    public partial class LoginAblak : Form
    {
        public LoginAblak()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public async Task<bool> IgazBejelentkezes(string username, string password)
        {
          
            pictureBox1.Visible = true;
            await System.Threading.Tasks.Task.Delay(1000);
            bool igaz = false;
            if (username.Equals("Admin") && password.Equals("Admin"))
            {
                igaz = true;
            }
                return igaz;
        }
        private async void LOGIN_button_Click(object sender, EventArgs e)
        {
            string username = USERNAME_TextBox.Text;
            string password = PASSWORD_TextBox.Text;
            bool igazsag = await  IgazBejelentkezes(username, password);
            pictureBox1.Visible = false;
            if (igazsag==true)
            {
                LOGIN_panel.Controls.Clear();
                FoKepernyo frm = new FoKepernyo();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                LOGIN_panel.Controls.Add(frm);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Helytelen jelszo kerlek probald meg ujra!");
            }
        }
    }
}