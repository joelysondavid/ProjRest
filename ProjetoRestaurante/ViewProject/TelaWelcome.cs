using ModelProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewProject
{
    public partial class TelaWelcome : Form
    {
        Usuario user;
        public TelaWelcome(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.5;
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString();
            if (circularProgressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
                TelaHome home = new TelaHome(); // instancia a tela home
                home.Show(); // abre a tela home
            }
        }

        private void TelaWelcome_Load(object sender, EventArgs e)
        {
            lblNome.Text = this.user.Nome;
            this.Opacity = 0.0;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Maximum = 0;
            circularProgressBar1.Maximum = 100;
            timer1.Start();
        }
    }
}
