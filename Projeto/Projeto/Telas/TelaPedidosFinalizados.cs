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
    public partial class TelaPedidosFinalizados : UserControl
    {
        public TelaPedidosFinalizados()
        {
            InitializeComponent();
            PedidoFinalizado();
        }

        protected void PedidoFinalizado()
        {
            
                var conectarBD = "server=localhost;uid=root;database=projetoacai";
                var conexao = new MySqlConnection(conectarBD);
                conexao.Open();
                string SQL;

            //SQL = "SELECT venda.id, venda.valor, venda.lista_produtos, venda.data_venda, venda.status, venda.nomeCliente FROM venda WHERE venda.status = 'finalizado'";

            SQL = "SELECT venda.id, venda.valor, venda.lista_produtos, venda.data_venda, venda.status, venda.nomeCliente FROM venda WHERE venda.status = 'finalizado' AND DATE(venda.data_venda) BETWEEN DATE('" + dataIncio.Text + "') AND DATE('" + dataFim.Text + "')";

                MySqlCommand Comando = new MySqlCommand(SQL, conexao);
                MySqlDataReader executa = Comando.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(executa);
                dtGridPedidosFinalizados.DataSource = dt;
                dtGridPedidosFinalizados.Columns[0].Width = 40;
                dtGridPedidosFinalizados.Columns[1].Width = 50;
                dtGridPedidosFinalizados.Columns[2].Width = 599;
                dtGridPedidosFinalizados.Columns[3].Width = 120;
                dtGridPedidosFinalizados.Columns[4].Width = 80;
                conexao.Close();
        }

        private void TelaPedidosFinalizados_Load(object sender, EventArgs e)
        {
            PedidoFinalizado();
        }

        private void dtGridPedidosFinalizados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botaoAtualizar_Click(object sender, EventArgs e)
        {
            PedidoFinalizado();
        }
    }
}
