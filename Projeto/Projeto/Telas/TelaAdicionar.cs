
using MySql.Data.MySqlClient;
using Projeto;
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
    public partial class TelaAdicionar : UserControl
    {
        Conta Produto = new Conta();
        public TelaAdicionar()
        {
            InitializeComponent();
        }
        private void showDialog(string mensagem, Color bgColor)
        {
            Alerta alerta = new Alerta(mensagem, bgColor);
            alerta.Show();
            
        }
        private void botaoAdicionar_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text == "" && txtQuantidade.Text == "" && txtValor.Text == "")
            {
                showDialog("Preencha todos Campos", Color.Yellow);
            }
            else
            {
                try
                {
                    var conectarBD = "server=localhost;uid=root;database=projetoacai";
                    var conexao = new MySqlConnection(conectarBD);
                    string SQL;
                    SQL = "INSERT INTO adicionar(produto, quantidade, valor, datahora) VALUES(@PRODUTO,@QUANTIDADE,@VALOR, @DATAHORA)";
                    MySqlCommand comando = new MySqlCommand(SQL, conexao);
                    conexao.Open();
                    comando.Parameters.AddWithValue("@PRODUTO", txtProduto.Text);
                    comando.Parameters.AddWithValue("@QUANTIDADE", txtQuantidade.Text);
                    comando.Parameters.AddWithValue("@VALOR", txtValor.Text);
                    comando.Parameters.AddWithValue("@DATAHORA", dataEntrada.Value);

                    comando.ExecuteNonQuery();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro em Adicionar: " + erro.Message);
                }
                finally
                {
                    var conexao = new MySqlConnection();
                    conexao.Close();
                    Produto.ZerarConta(Produto.SaldoCliente);
                    showDialog("Produto Adicionado com suscesso", Color.Green);
                    txtProduto.Clear();
                    txtQuantidade.Clear();
                    txtValor.Clear();
                }
            }
        }
    }
}
