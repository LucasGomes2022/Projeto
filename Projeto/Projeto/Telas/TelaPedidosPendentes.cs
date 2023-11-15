using MySql.Data.MySqlClient;
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
    public partial class TelaPedidosPendentes : UserControl
    {
        public TelaPedidosPendentes()
        {
            InitializeComponent();
            CarregarPedidos();
        }

        private void showDialog(string mensagem, Color bgColor)
        {
            Alerta alerta = new Alerta(mensagem, bgColor);
            alerta.Show();
        }

        private void CarregarPedidos()
        {
            try
            {
                var conectarBD = "server=localhost;uid=root;database=projetoacai";
                var conexao = new MySqlConnection(conectarBD);
                string SQL;

                SQL = "SELECT venda.id, venda.valor, venda.lista_produtos, venda.data_venda, venda.status, venda.nomeCliente FROM venda WHERE venda.status = 'pendente'";
                conexao.Open();
                MySqlCommand Comando = new MySqlCommand(SQL, conexao);
                MySqlDataReader executa = Comando.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(executa);
                dtGridPendentes.DataSource = dt;
                dtGridPendentes.Columns[0].Width = 85;
                dtGridPendentes.Columns[1].Width = 40;
                dtGridPendentes.Columns[2].Width = 50;
                dtGridPendentes.Columns[3].Width = 528;
                dtGridPendentes.Columns[4].Width = 110;
                dtGridPendentes.Columns[5].Width = 75;
                conexao.Close();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro no metodo de Pedidos pendentes: " + erro);
            }
            
        }

        private void botaoFinalizarPedido_Click(object sender, EventArgs e)
        {

        }

        private void dtGridPendentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Deseja Finalizar o pedido ?", "Finalizar Pedido", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    var intem = dtGridPendentes.Rows[e.RowIndex].Cells[1].Value;

                    var conectarBD = "server=localhost;uid=root;database=projetoacai";
                    var conexao = new MySqlConnection(conectarBD);
                    conexao.Open();
                    string SQL;

                    SQL = "UPDATE venda SET venda.status = @STATUS WHERE venda.id =" + intem;
                    string resultado = "finalizado";
                    MySqlCommand Comando = new MySqlCommand(SQL, conexao);
                    Comando.Parameters.AddWithValue("@STATUS", resultado);
                    Comando.ExecuteNonQuery();
                    conexao.Close();
                    
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro em Pedidos Pendentes: " + erro.Message);
                }
                finally
                {
                    showDialog("Pedido Finalizado com Suscesso", Color.Green);
                    CarregarPedidos();
                }
            }
        }

        private void TelaPedidosPendentes_Load(object sender, EventArgs e)
        {
            CarregarPedidos();
        }

        private void botaoAtualizar_Click(object sender, EventArgs e)
        {
            CarregarPedidos();
        }
    }
}
