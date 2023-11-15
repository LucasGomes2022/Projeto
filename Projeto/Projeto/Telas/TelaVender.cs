using Projeto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;
using System.Net;
using Org.BouncyCastle.Ocsp;

namespace Projeto
{
    public partial class TelaVender : UserControl
    {
        public TelaVender()
        {
            InitializeComponent();
        }

        private string localImagem = @"C:\Users\DTI\Desktop\CursoSenai\Projeto\img\logo1.png";

        Conta conta = new Conta();
        Produto produto = new Produto();

        private string acai200, acai300, acai400, acai500, acai1000, adLeiteEmPo, adChocoBall, adPacoca, adJujuba, adGranulado, inLeiteEmPo, inChocoBall, inPacoca, inJujuba, inGranulado;
        private string descricaoAcai200, descricaoAcai300, descricaoAcai400, descricaoAcai500, descricaoAcai1000, descricaoAdLeiteEmPo, descricaoAdChocoBall, descricaoAdPacoca, descricaoAdJujuba, descricaoAdGranulado, descricaoInLeiteEmPo, descricaoInChocoBall, descricaoInPacoca, descricaoInJujuba, descricaoInGranulado;

        //private string resultadoAcai200, resultadoAcai300, resultadoAcai400, resultadoAcai500, resultadoAcai1000, resultadoAdLeiteEmPo, resultadoAdChocoBall, resultadoAdPacoca, resultadoAdJujuba, resultadoAdGranulado, resultadoInLeiteEmPo, resultadoInChocoBall, resultadoInPacoca, resultadoInJujuba, resultadoInGranulado;

        private void showDialog(string mensagem, Color bgColor)
        {
            Alerta alerta = new Alerta(mensagem, bgColor);
            alerta.Show();
        }

        private void ZerarEscrita()
        {
            acai200 = ""; acai300 = ""; acai400 = ""; acai500 = ""; acai1000 = ""; adChocoBall = ""; adJujuba = ""; adLeiteEmPo = ""; adPacoca = ""; adGranulado = ""; inChocoBall = ""; inGranulado = ""; inJujuba = ""; inLeiteEmPo = ""; inPacoca = "";
            descricaoAcai200 = ""; descricaoAcai300 = ""; descricaoAcai400 = ""; descricaoAcai500 = ""; descricaoAcai1000 = ""; descricaoAdChocoBall = ""; descricaoAdGranulado = ""; descricaoAdJujuba = ""; descricaoAdLeiteEmPo = ""; descricaoAdPacoca = ""; descricaoInChocoBall = ""; descricaoInGranulado = ""; descricaoInJujuba = ""; descricaoInLeiteEmPo = ""; descricaoInPacoca = "";
        }

        private void botaoDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                //Ver se tem alguma linha selecionado no Grid
                if (dtGridListaProdutos.SelectedRows.Count == 0)
                {
                    // Se entrar aqui é porque  não tem linha selecionado no grid
                    showDialog("Nenhuma linha selecionada para excluir!", Color.Red);
                }
                else
                {
                    // Se cair no else é porque tem uma linha selecionada no grid
                    // Removendo a linha selecionada  
                    dtGridListaProdutos.Rows.RemoveAt(dtGridListaProdutos.CurrentRow.Index);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro em Deletar: " + erro);
            }    
        }

        private void botaoInserir_Click(object sender, EventArgs e)
        {
            try
            {
                string produtos = acai200 + acai300 + acai400 + acai500 + acai1000 + adGranulado + adJujuba + adLeiteEmPo + adChocoBall + adPacoca + inChocoBall + inGranulado + inJujuba + inLeiteEmPo + inPacoca;
                string desProdutos = descricaoAcai200 + descricaoAcai300 + descricaoAcai400 + descricaoAcai500 + descricaoAcai1000 + descricaoAdChocoBall + descricaoAdGranulado + descricaoAdJujuba + descricaoAdLeiteEmPo + descricaoAdPacoca + descricaoInChocoBall + descricaoInGranulado + descricaoInJujuba + descricaoInLeiteEmPo + descricaoInPacoca;
                produto.NomeClientes(txtNomeCliente.Text);
                produto.NProduto(produtos);
                produto.Descricao(desProdutos);
                produto.Valores(conta.SaldoCliente.ToString());
                Imprimir p = new Imprimir();
                p.NProduto(produto.Produtos);
                p.Descricao(produto.DescricaoProduto);
                p.NomeClientes(produto.NomeCliente);
                if (produto.Produtos == "" && produto.DescricaoProduto == "")
                {
                    showDialog("Insira Produto na lista !!!", Color.Yellow);
                }
                else
                {
                    dtGridListaProdutos.Rows.Add(produto.Produtos, produto.DescricaoProduto);
                }

                ZerarEscrita();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro em Inserir: " + erro.Message);
            }
        }

        private void botaoFinalizar_Click(object sender, EventArgs e)
        {
                      //Colocar os dados do Datagrid em uma linha só
            string resultadoFor = "";
            DataGridViewCell celula = null;
            // percorrer as linhas
            for (int i = 0; i < dtGridListaProdutos.RowCount; i++)
            {
                // vamos percorrer as colunas de cada linha
                for (int x = 0; x < dtGridListaProdutos.ColumnCount; x++)
                {
                    // obtém a célula na coluna x e linha i
                    celula = dtGridListaProdutos[x, i];

                    if (celula.Value != null)
                        resultadoFor += celula.Value.ToString();
                    else
                        resultadoFor += "";
                }

                resultadoFor += "";
            }
            
            if (conta.SaldoCliente == 0 || txtNomeCliente.Text == "")
            {
                showDialog("O campo nome ou saldo estão vazios", Color.Yellow);
            }
            else
            {
                conta.AcrescentarPrincipal(conta.SaldoCliente);
                saldoCliente.Text = Convert.ToString(conta.SaldoCliente);
                
                try
                {
                                                //IMPRIMIR\\
                    System.Drawing.Image imagem = System.Drawing.Image.FromFile(localImagem);
                    Imprimir p = new Imprimir();

                    for (int i = 0; i < dtGridListaProdutos.Rows.Count; i++)
                    {

                        produto = new Produto();
                        produto.NProduto(Convert.ToString(dtGridListaProdutos.Rows[i].Cells[0].Value));
                        produto.Descricao(Convert.ToString(dtGridListaProdutos.Rows[i].Cells[1].Value));
                        p.listaProdutos.Add(produto);

                        p.NomeClientes(txtNomeCliente.Text);
                        p.Valores(conta.SaldoCliente.ToString());
                        p.LogoEmpresa(imagem);
                        p.Datas(dataVenda.Value.ToString());
                        p.NomeEmpresa("Açaí Dos Silva");
                        p.EnderecoEmpresa("Endereço: Conjunto XX Lote XX 2");
                        p.TelefoneEmpresa("(61) 9 - 95204361");
                    }
                    p.ImprimirTicket(p);


                    string status = "pendente";
                    string strConexao = @"server=localhost;uid=root;database=projetoacai";
                    var conexao = new MySqlConnection(strConexao);
                    string SQL;
                    SQL = "INSERT INTO venda(valor, valortotal, lista_produtos, data_venda, status, nomeCliente) VALUES(@VALOR,@VALORTOTAL, @LISTA_PRODUTOS, @DATA_VENDA, @STATUS, @NOMECLIENTE)";

                    MySqlCommand comando = new MySqlCommand(SQL, conexao);
                    conexao.Open();

                    comando.Parameters.AddWithValue("@VALOR", conta.SaldoCliente);
                    comando.Parameters.AddWithValue("@LISTA_PRODUTOS", resultadoFor);
                    comando.Parameters.AddWithValue("@VALORTOTAL", conta.SaldoPrincipal);
                    comando.Parameters.AddWithValue("@DATA_VENDA", dataVenda.Value);
                    comando.Parameters.AddWithValue("@STATUS", status);
                    comando.Parameters.AddWithValue("@NOMECLIENTE", txtNomeCliente.Text);

                    comando.ExecuteNonQuery();
                    conexao.Close();
                }
                    
                catch (Exception erro)
                {
                    MessageBox.Show("Erro em Finalizar o Pedido: " + erro.Message);
                }
                finally
                {
                    conta.ZerarConta(conta.SaldoCliente);
                    dtGridListaProdutos.Rows.Clear();
                    saldoCliente.Clear();
                    txtNomeCliente.Clear();
                    showDialog("Pedido Finalizado com Suscesso", Color.Green);
                }
            }
        }
                            //Botões Adicionais

        private void botaoAdGranulado_Click(object sender, EventArgs e)
        {
            double valor = 1;
            adGranulado = "Adicional ";
            descricaoAdGranulado = "Granulado ";
            //resultadoAdGranulado = adGranulado + descricaoAdGranulado;
            conta.AcrescentarCliente(valor);
            saldoCliente.Text = Convert.ToString(conta.SaldoCliente);
        }

        private void botaoAdJujuba_Click(object sender, EventArgs e)
        {
            double valor = 1;
            adJujuba = "Adicional ";
            descricaoAdJujuba = "Jujuba ";
            //resultadoAdJujuba = adJujuba + descricaoAdJujuba;
            conta.AcrescentarCliente(valor);
            saldoCliente.Text = Convert.ToString(conta.SaldoCliente);
        }

        private void botaoAdPacoca_Click(object sender, EventArgs e)
        {
            double valor = 1;
            adPacoca = "Adicional ";
            descricaoAdPacoca = "Paçoca ";
            //resultadoAdPacoca = adPacoca + descricaoAdPacoca;
            conta.AcrescentarCliente(valor);
            saldoCliente.Text = Convert.ToString(conta.SaldoCliente);
        }

        private void botaoAdChocoBall_Click(object sender, EventArgs e)
        {
            double valor = 1;
            adChocoBall = "Adicional ";
            descricaoAdChocoBall = "Chocoball ";
            //resultadoAdChocoBall = adChocoBall + descricaoAdChocoBall;
            conta.AcrescentarCliente(valor);
            saldoCliente.Text = Convert.ToString(conta.SaldoCliente);
        }

        private void botaoAdLeiteEmPo_Click(object sender, EventArgs e)
        {
            double valor = 1;
            adLeiteEmPo = "Adicional ";
            descricaoAdLeiteEmPo = "Leite em Pó ";
            //resultadoAdLeiteEmPo = adLeiteEmPo + descricaoAdLeiteEmPo;
            conta.AcrescentarCliente(valor);
            saldoCliente.Text = Convert.ToString(conta.SaldoCliente);
        }

                         //Botões Ingredientes

        private void botaoInGranulado_Click(object sender, EventArgs e)
        {
            inGranulado = "Ingrediente ";
            descricaoInGranulado = "Granulado ";
            //resultadoInGranulado = inGranulado + descricaoInGranulado;
        }

        private void botaoInJujuba_Click(object sender, EventArgs e)
        {
            inJujuba = "Ingrediente ";
            descricaoInJujuba = "Jujuba ";
            //resultadoInJujuba = inJujuba + resultadoInJujuba;
        }

        private void botaoInPacoca_Click_1(object sender, EventArgs e)
        {
            inPacoca = "Ingrediente ";
            descricaoInPacoca = "Paçoca ";
            //resultadoInPacoca = inPacoca + descricaoInPacoca;
        }

        private void botaoInChocoBall_Click(object sender, EventArgs e)
        {
            inChocoBall = "Ingrediente ";
            descricaoInChocoBall = "Choco Ball ";
            //resultadoInChocoBall = inChocoBall + descricaoInChocoBall;
        }

        private void botaoInLeiteEmPo_Click_1(object sender, EventArgs e)
        {
            inLeiteEmPo = "Ingrediente ";
            descricaoInLeiteEmPo = "Leite em Pó ";
            //resultadoInLeiteEmPo = inLeiteEmPo + descricaoInLeiteEmPo;
        }

                              //Botões Potes//

        private void botaoMil_Click(object sender, EventArgs e)
        {
            double valor = 15;
            acai1000 = "Açaí no Pote ";
            descricaoAcai1000 = "1000ML ";
            //resultadoAcai1000 = acai1000 + descricaoAcai1000;
            conta.AcrescentarCliente(valor);
            saldoCliente.Text = Convert.ToString(conta.SaldoCliente);
        }

        private void botaoQuinhetos_Click(object sender, EventArgs e)
        {
            double valor = 10;
            acai500 = "Açaí no Pote ";
            descricaoAcai500 = "500ML ";
            //resultadoAcai500 = acai500 + descricaoAcai500;
            conta.AcrescentarCliente(valor);
            saldoCliente.Text = Convert.ToString(conta.SaldoCliente);
        }

        private void botaoQuatrocentos_Click(object sender, EventArgs e)
        {
            double valor = 9;
            acai400 = "Açaí no Pote ";
            descricaoAcai400 = "400ML ";
            //resultadoAcai400 = acai400 + descricaoAcai400;
            conta.AcrescentarCliente(valor);
            saldoCliente.Text = Convert.ToString(conta.SaldoCliente);
        }

        private void botaoTrezentos_Click_1(object sender, EventArgs e)
        {
            double valor = 8;
            acai300 = "Açaí no Pote ";
            descricaoAcai300 = "300ML ";
            //resultadoAcai300 = acai300 + descricaoAcai300;
            conta.AcrescentarCliente(valor);
            saldoCliente.Text = Convert.ToString(conta.SaldoCliente);
        }

        private void botaoDuzentos_Click_1(object sender, EventArgs e)
        {
            double valor = 6.5;
            acai200 = "Açaí no Pote ";
            descricaoAcai200 = "200ML ";
            //resultadoAcai200 = acai200 + descricaoAcai200;
            conta.AcrescentarCliente(valor);
            saldoCliente.Text = Convert.ToString(conta.SaldoCliente);
        }
    }
}
