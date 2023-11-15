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
    public partial class TelaRelatorioEntrada : UserControl
    {
        public TelaRelatorioEntrada()
        {
            InitializeComponent();
        }

        private void dtGridEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AtualizarLista()
        {
            try
            {
                var conectarBD = "server=localhost;uid=root;database=projetoacai;ConvertZeroDatetime=true";
                var conexao = new MySqlConnection(conectarBD);
                conexao.Open();
                string SQL;

                //SQL = "SELECT adicionar.id, adicionar.produto, adicionar.quantidade, adicionar.valor, adicionar.datahora FROM adicionar";
                SQL = "SELECT adicionar.id, adicionar.produto, adicionar.quantidade, adicionar.valor, adicionar.datahora FROM adicionar WHERE DATE(adicionar.datahora) BETWEEN DATE('" + dataIncio.Text+ "') AND DATE('" + dataFim.Text + "')";

                MySqlCommand Comando = new MySqlCommand(SQL, conexao);
                MySqlDataReader executa = Comando.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(executa);
                dtGridEntrada.DataSource = dt;
                dtGridEntrada.Columns[1].Width = 589;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro no Relatório de Entrada: " + erro.Message);
            }
        }

        private void TelaRelatorioEntrada_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }
    }
}
