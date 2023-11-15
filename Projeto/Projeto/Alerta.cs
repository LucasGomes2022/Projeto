using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Alerta : Form
    {

        public Alerta(string mensagem, Color bgColor)
        {
            InitializeComponent();

            BackColor = bgColor;
            lbl_mensagem.Text = mensagem;

            if (bgColor == Color.Red)
            {
                icone.Image = imageList1.Images[2];
            }
            if (bgColor == Color.Yellow)
            {
                icone.Image = imageList1.Images[1];
            }
            if (bgColor == Color.Green)
            {
                icone.Image = imageList1.Images[0];
            }
        }

        private void AlertaErro()
        {

        }

        private void Alerta_Load(object sender, EventArgs e)
        {
            Top = 20;
            Left = Screen.PrimaryScreen.Bounds.Width - Width - 20;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            int intervalo = 0;
            if (this.Top < 60)
            {
                this.Top += intervalo;
                intervalo += 2;
            }
            else
            {
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.10;
            }
            else
            {
                this.Close();
            }
        }

        public enum AlertType
        {
            suscesso, erro
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
