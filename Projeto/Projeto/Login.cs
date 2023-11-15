using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtUsuario.Select();
        }

        private void showDialog(string mensagem, Color bgColor)
        {
            Alerta alerta = new Alerta(mensagem, bgColor);
            alerta.Show();
        }

        private void Admin()
        {
            if (txtUsuario.Text.Trim() == "" && txtSenha.Text.Trim() == "")
            {
                txtUsuario.Select();
                showDialog("Preencha os Campos", Color.Yellow);
            }
            else
            {
                try
                {
                    var conectarBD = "server=localhost;uid=root;database=projetoacai";
                    var conexao = new MySqlConnection(conectarBD);
                    conexao.Open();
                    string SQL;

                    SQL = "SELECT * FROM login WHERE login.usuario ='" + txtUsuario.Text + "'AND login.senha ='" + txtSenha.Text + "'AND login.tipo ='" + "admin" + "'";

                    MySqlCommand Comando = new MySqlCommand(SQL, conexao);
                    MySqlDataReader executa = Comando.ExecuteReader();
                    if (executa.Read())
                    {
                        Principal tela = new Principal();
                        tela.Show();
                        this.Hide();
                    }
                    else
                    {
                        txtUsuario.Select();
                        showDialog("Usuario ou Senha Incorretos", Color.Yellow);
                        //MessageBox.Show("Usuário ou senha estão incorretos");
                    }
                    executa.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro no Login: " + erro.Message);
                }
            }
        }
        
        private void botaoEntrar_Click(object sender, EventArgs e)
        {
            Admin();
        }

        private void botaoSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEJA SAIR ??", "SAIR", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
                this.Close();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
