using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Projeto
{
    public partial class TelaRelatorioSaida : UserControl
    {
        public TelaRelatorioSaida()
        {
            InitializeComponent();
        }

        private void AtualizarLista()
        {
            try
            {
                var conectarBD = "server=localhost;uid=root;database=projetoacai;ConvertZeroDatetime=true";
                var conexao = new MySqlConnection(conectarBD);
                conexao.Open();
                string SQL;

                //SQL = "SELECT venda.id, venda.valor, venda.data_venda, venda.lista_produtos FROM venda";
                SQL = "SELECT venda.id, venda.valor, venda.data_venda, venda.lista_produtos FROM venda WHERE DATE(venda.data_venda) BETWEEN DATE('" + dataIncio.Text + "') AND  DATE('" + dataFim.Text + "')";

                MySqlCommand Comando = new MySqlCommand(SQL, conexao);
                MySqlDataReader executa = Comando.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(executa);
                dtGridSaida.DataSource = dt;
                dtGridSaida.Columns[0].Width = 40;
                dtGridSaida.Columns[1].Width = 50;
                dtGridSaida.Columns[3].Width = 797;
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro no Relatorio de Saída: " + erro.Message);
            }
        }


        private void TelaRelatorioSaida_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }
    }
}
