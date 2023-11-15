using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    internal class Produto : Empresa
    {
        public string Produtos { get; protected set; }
        public string Ingrediente { get; protected set; }
        public string Adicinal { set; get; }
        public double Quantidade { get; protected set; }
        public string Valor { get; protected set; }
        public string DescricaoProduto { get; protected set; }
        public string Data { get; protected set; }
        public string NomeCliente { get; protected set; }


        public void NProduto(string produto)
        {
           this.Produtos = produto;
        }
        public void Ingredientes(string ingredientes)
        {
            this.Ingrediente = ingredientes; 
        }
        public void Adicionais(string adicionais)
        {
            this.Adicinal = adicionais;
        }
        public void Quantidades(double quantidades)
        {
            this.Quantidade = quantidades;
        }
        public void Valores(string valores)
        {
            this.Valor = valores; 
        }
        public void Descricao(string descricao)
        {
            this.DescricaoProduto = descricao;
        }
        public void Datas(string datas)
        {
            this.Data = datas;
        }
        public void NomeClientes(string nome)
        {
            this.NomeCliente = nome;
        }
    }
}
