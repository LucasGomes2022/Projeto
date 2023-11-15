using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Projeto
{
    internal class Empresa
    {
        public string NEmpresa { protected set; get; }
        public string Endereco { protected set; get; }
        public string Telefone { protected set; get; }
        public Image Logo { protected set; get; }


        public void NomeEmpresa(string nome)
        {
            this.NEmpresa = nome; 
        }
        public void EnderecoEmpresa(string nome)
        {
            this.Endereco = nome; 
        }
        public void TelefoneEmpresa(string nome)
        {
            this.Telefone = nome; 
        }
        public void LogoEmpresa(Image imagem)
        {
            this.Logo = imagem; 
        }
    }
}
