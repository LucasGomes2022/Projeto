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
    public partial class Carregamento : Form
    {
        public Carregamento()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelCarregar.Width += 2;
            try
            {
                if (panelCarregar.Width >= 500)
                {
                    timer1.Stop();
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro no Carregamento: " + erro);
            }
            finally 
            {
                
            }
            

           
        }
    }
}
