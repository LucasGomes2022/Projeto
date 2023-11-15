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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            painelSelecionado.Height = botaoAdProduto.Height;
            painelSelecionado.Top = botaoVender.Top;
            telaVender1.BringToFront();
        }

        private void botaoAdProduto_Click(object sender, EventArgs e)
        {
            painelSelecionado.Height = botaoAdProduto.Height;
            painelSelecionado.Top = botaoAdProduto.Top;
            telaAdicionar1.BringToFront();
        }

        private void botaoVender_Click(object sender, EventArgs e)
        {
            painelSelecionado.Height = botaoAdProduto.Height;
            painelSelecionado.Top = botaoVender.Top;
            telaVender1.BringToFront();
        }

        private void botaoPdPendentes_Click(object sender, EventArgs e)
        {
            painelSelecionado.Height = botaoPdPendentes.Height;
            painelSelecionado.Top = botaoPdPendentes.Top;
            telaPedidosPendentes1.BringToFront();
        }

        private void botaoPdFinalizados_Click(object sender, EventArgs e)
        {
            painelSelecionado.Height = botaoPdFinalizados.Height;
            painelSelecionado.Top = botaoPdFinalizados.Top;
            telaPedidosFinalizados1.BringToFront();
        }

        private void botaoReEntrada_Click(object sender, EventArgs e)
        {
            painelSelecionado.Height = botaoReEntrada.Height;
            painelSelecionado.Top = botaoReEntrada.Top;
            telaRelatorioEntrada1.BringToFront();
        }

        private void botaoReSaida_Click(object sender, EventArgs e)
        {
            painelSelecionado.Height = botaoReSaida.Height;
            painelSelecionado.Top = botaoReSaida.Top;
            telaRelatorioSaida1.BringToFront();
        }

        private void botaoResumo_Click(object sender, EventArgs e)
        {
            painelSelecionado.Height = botaoResumo.Height;
            painelSelecionado.Top = botaoResumo.Top;
            telaResumo1.BringToFront();
            
        }

        private void botaoSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEJA SAIR ??", "SAIR", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
                this.Close();
            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
