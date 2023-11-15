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
    public partial class TelaResumo : UserControl
    {
        public TelaResumo()
        {
            InitializeComponent();
            
        }

        private void Adicionar()
        {
                try
                {
                    var conectarBD = "server=localhost;uid=root;database=projetoacai";
                    var conexao = new MySqlConnection(conectarBD);
                    conexao.Open();
                    string SQL;

                    //SQL = "SELECT SUM(venda.valortotal) FROM venda";

                    SQL = "SELECT IFNULL(SUM(adicionar.valor), 0) FROM adicionar WHERE DATE(adicionar.datahora) BETWEEN DATE('" + dataInicio.Text + "') AND  DATE('" + dataFim.Text + "')";

                    MySqlCommand Comando = new MySqlCommand(SQL, conexao);
                    MySqlDataReader executa = Comando.ExecuteReader();
                    executa.Read();
                    txtTotalEntrada.Text = executa.GetString(0);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro no resumo do valor de saída: " + erro.Message);
                }
        }
        private void Vender()
        {
            
                try
                {
                    var conectarBD = "server=localhost;uid=root;database=projetoacai";
                    var conexao = new MySqlConnection(conectarBD);
                    conexao.Open();
                    string SQL;

                    //SQL = "SELECT SUM(adicionar.valor) FROM adicionar";

                    SQL = "SELECT IFNULL(SUM(venda.valortotal), 0) FROM venda WHERE DATE(venda.data_venda) BETWEEN DATE('" + dataInicio.Text + "') AND DATE('" + dataFim.Text + "')";

                    MySqlCommand Comando = new MySqlCommand(SQL, conexao);
                    MySqlDataReader executa = Comando.ExecuteReader();
                    executa.Read();
                    txtTotalVenda.Text = executa.GetString(0);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro no resumo do valor de entrada: " + erro.Message);
                }
        }


        private void TelaResumo_Load(object sender, EventArgs e)
        {
            Adicionar();
            Vender();
        }

        private void botaoAtualizar_Click(object sender, EventArgs e)
        {
            DateTime primeiroDia = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            
            DateTime dataI = Convert.ToDateTime(dataInicio.Text);
            DateTime dataF = Convert.ToDateTime(dataFim.Text);
            if (dataI <= dataF)
            {
                Adicionar();
                Vender();
            }
            else
            {
                MessageBox.Show("Erro, Coloque uma data inicial menor que a do fim");
            }
        }
    }
}
