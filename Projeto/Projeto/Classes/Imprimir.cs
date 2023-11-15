using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Projeto;

namespace Projeto
{
    internal class Imprimir : Produto
    {
        public List<Produto> listaProdutos = new List<Produto>();
        

        private PrintDocument doc = new PrintDocument();
        private PrintPreviewDialog vista = new PrintPreviewDialog();
        
        public void imiprirTicket(object sender, PrintPageEventArgs e)
        {
            Produto produto = new Produto();
            Conta conta = new Conta();
            int posX = 50, posY = 10;
            
            try
            {
               e.Graphics.DrawImage(Logo, 55, 0, 90, 90);
                posX += 30;
                Font fonte = new Font("arial", 4, FontStyle.Bold);
                e.Graphics.DrawString(Data, fonte, Brushes.Black, posY, posX);
                posX += 10;
                fonte = new Font("arial", 6, FontStyle.Bold);

                /*                                                   80mm
                e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------", fonte, Brushes.Black, posY, posX);
                posX += 15;
                e.Graphics.DrawString("Produto                                                    Descrição                                                      ", fonte, Brushes.Black, posY, posX);
                posX += 15;
                
                e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------", fonte, Brushes.Black, posY, posX);
                //posY += 100;*/

                //                                                   58mm
                e.Graphics.DrawString("------------------------------------------------------------", fonte, Brushes.Black, posY, posX);
                posX += 15;
                e.Graphics.DrawString("Produto                             Descrição                               ", fonte, Brushes.Black, posY, posX);
                posX += 15;
                e.Graphics.DrawString("------------------------------------------------------------", fonte, Brushes.Black, posY, posX);
                //posY += 100;

                posX += 15;
                fonte = new Font("arial", 5, FontStyle.Regular);
                e.Graphics.DrawString(produto.Produtos, fonte, Brushes.Black, posY, posX);
                
                e.Graphics.DrawString(produto.DescricaoProduto, fonte, Brushes.Black, posY, posX);
                
                for (int i = 0; i < listaProdutos.Count; i++)
                {
                    //                                             58mm
                    e.Graphics.DrawString(Convert.ToString(listaProdutos[i].Produtos) + espaco(listaProdutos[i].Produtos.ToString().Length, 45) + Convert.ToString(listaProdutos[i].DescricaoProduto), fonte, Brushes.Black, posY, posX);
                    posX += 15;
                    /*                                             80mm
                    e.Graphics.DrawString(Convert.ToString(listaProdutos[i].Produtos) + espaco(listaProdutos[i].Produtos.ToString().Length, 65) + Convert.ToString(listaProdutos[i].DescricaoProdutos), fonte, Brushes.Black, posY, posX);
                    posX += 15;
                    */
                }

                fonte = new Font("arial", 6, FontStyle.Bold);
                e.Graphics.DrawString("------------------------------------------------------------", fonte, Brushes.Black, posY, posX);

                posX += 15;
                fonte = new Font("arial", 5, FontStyle.Bold);
                e.Graphics.DrawString("Valor Total: " + Valor + "\n" + "Nome Cliente: " + NomeCliente, fonte, Brushes.Black, posY, posX);

                fonte = new Font("arial", 6, FontStyle.Bold);
                posX += 20;
                e.Graphics.DrawString("------------------------------------------------------------", fonte, Brushes.Black, posY, posX);

                fonte = new Font("arial", 5, FontStyle.Regular);
                posX += 12;
                e.Graphics.DrawString("                  Obrigado Pela Preferencia !!!", fonte, Brushes.Black, posY, posX);
                //posY += 100;
                posX += 25;
                e.Graphics.DrawString("                               " + NEmpresa, fonte, Brushes.Black, posY, posX);
                //posY += 100;
                posX += 8;  
                e.Graphics.DrawString("                " + Endereco, fonte, Brushes.Black, posY, posX);
                //posY += 100;
                posX += 8;
                e.Graphics.DrawString("                             " + Telefone, fonte, Brushes.Black, posY, posX);
                //posY -= 5;
                //posX += 25;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ImprimirTicket(Imprimir p)
        {
            doc.PrinterSettings.PrinterName = doc.DefaultPageSettings.PrinterSettings.PrinterName;
            doc.PrintPage += new PrintPageEventHandler(imiprirTicket);
            vista.Document = doc;
            vista.Show();
        }

        public string espaco(int tamanho, int valor)
        {
            string espaco = "";
            int subvalor = 0;
            subvalor = valor - tamanho;

            for (int i = 0; i < subvalor; i++)
            {
                espaco = espaco + " ";
            }
            return espaco;
        }
    }
}
