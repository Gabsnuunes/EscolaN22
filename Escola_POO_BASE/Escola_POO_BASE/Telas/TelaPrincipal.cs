using Escola_POO_BASE.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola_POO_BASE.Telas
{
    public partial class TelaPrincipal : Form
    {
        //Declaração do obj
        private Usuario _userLogado;
        private List<Usuario> _usuarios;
        public TelaPrincipal(Usuario usuarioLogado)
        {
            //Inicializa os componentes da tela
            InitializeComponent();
            //usuarioLogado sendo atribuído em _userLogado.
            _userLogado = usuarioLogado;
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            //If ternário.
            //Caso o obj _userLogado for do tipo Aluno, então armazenará na
            //propriedade Text a palavra "Aluno", senão, "Professor".
            //TslPerfilUserLogado.Text = _userLogado is Aluno ? "Aluno" : "Professor";
            if (_userLogado is Aluno)
            {
                TsiCadastros.Visible = false;
                TslPerfilUserLogado.Text = "Aluno";
            }
            else
            {
                TsiCadastros.Visible = true;
                TslPerfilUserLogado.Text = "Professor";
            }


            LblBoasVindas.Text = $"Bem-Vindo(a), {_userLogado.Nome}!";
            TslNomeUserLogado.Text = _userLogado.Nome;
            TslEmailUserLogado.Text = _userLogado.Email;       

            TslDataHora.Text = DateTime.Now.ToLongDateString() + " | " + DateTime.Now.ToLongTimeString();

        }

        private void TsiAlterarSenha_Click(object sender, EventArgs e)
        {
            TelaAlterarSenha tlAlterarSenha = new TelaAlterarSenha(_userLogado);
            tlAlterarSenha.ShowDialog();
        }

        private void TsiCadastraAluno_Click(object sender, EventArgs e)
        {
            TelaCadastraAluno tlCadAluno = new TelaCadastraAluno(_userLogado);
            tlCadAluno.ShowDialog();
        }
    }
}
