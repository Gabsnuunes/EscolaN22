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
    public partial class TelaCadastraAluno : Form
    {
        
        private List<Aluno> _alunos;
        private Professor _userLogado;
        private List<Usuario> _usuarios;
        private Aluno _alunoSelecionado;
        public TelaCadastraAluno (Usuario userLogado)
        {
            InitializeComponent();

            _userLogado = (Professor)userLogado;

            try
            {
                _alunos = Usuario.BuscarUsuarios().ConvertAll(u => (Aluno)u);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                          "Erro",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
            }
        }

        //Método de formulário que irá configurar o DgvUsuarios
        private void ConfiguraDgvUsuarios()
        {
            //Criações das colunas no DgvUsuarios
            DgvUsuarios.Columns.Add("Id","Matrícula");
            DgvUsuarios.Columns.Add("Nome", "Nome");
            DgvUsuarios.Columns.Add("DtNascimento", "Data Nascimento");
            DgvUsuarios.Columns.Add("DtMatricula", "Data Matrícula");
            DgvUsuarios.Columns.Add("Email", "E-mail");
            DgvUsuarios.Columns.Add("Ativo", "Ativo");
            //---------

            //Configuração dos alinhamentos de cada coluna do DgvUsuarios
            DgvUsuarios.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DgvUsuarios.Columns["DtNascimento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["DtMatricula"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Ativo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //--------------

            DgvUsuarios.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvUsuarios.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvUsuarios.Columns["DtNascimento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvUsuarios.Columns["DtMatricula"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvUsuarios.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvUsuarios.Columns["Ativo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            //------------
            //Configurar tamanho em altura de coluna e linhas
            DgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvUsuarios.ColumnHeadersHeight = 35;
            DgvUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //-------------
            //Definindo cor para intercalar linhas
            DgvUsuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;


        }


        //Método para carregar o DvgUsuarios com os dados da lista.
        private void CarregaDgvUsuarios(List<Aluno> alunos = null)
        { 
         
            DgvUsuarios.Rows.Clear();

            foreach (Aluno aluno in alunos == null? _alunos: alunos)
            {

                DgvUsuarios.Rows.Add(aluno.Id, aluno.Nome, aluno.DtNascimento.ToString("dd/MM/yyyy"),aluno.DtMatricula, aluno.Email, aluno.Ativo);

                if (!aluno.Ativo)
                {
                    DgvUsuarios.Rows[DgvUsuarios.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }


        
        }

        //Metodo que limpa os campos da tela

        private void LimpaCampos()
        {
            LblId.Text = "";
            TxtNome.Clear();
            TxtEmail.Clear();
            DtpDtNascimento.Value = new DateTime(1990,1,1);
            DtpDtMatricula.Value =  DateTime.Now;
            CkbAtivo.Checked = true;
            DgvUsuarios.ClearSelection();
            BtnCadastrar.Enabled = true;
            BtnAlterar.Enabled = false;
        }


        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (_userLogado.NivelAcesso == 1)
            {


                try
                {
                    Aluno aluno = new Aluno(0,
                                            TxtNome.Text,
                                            DtpDtNascimento.Value,
                                            DtpDtMatricula.Value,
                                            TxtEmail.Text,
                                            "123",
                                            true);

                    aluno.Cadastrar(_alunos);
                    CarregaDgvUsuarios();
                    LimpaCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                                    "Erro",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Você não tem permissão para cadastrar Aluno",
                                        "Erro de Permissão",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);

            }   return; //Mata o método (encerra)
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void TelaCadastraAluno_Load(object sender, EventArgs e)
        {
            try
            {
                ConfiguraDgvUsuarios();
                CarregaDgvUsuarios();
                LimpaCampos();

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message,
                                   "Erro",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);


            }
            
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {

            LimpaCampos();

           

        }

        private void DgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {

            if (DgvUsuarios.Rows.Count < 1)
            
                return;
            
            else  if (DgvUsuarios.SelectedRows.Count < 1)
            
                return;
            
            

            try
            {

                 _alunoSelecionado = _alunos.Find(a => a.Id == (int)DgvUsuarios.SelectedRows[0].Cells[0].Value);
                LblId.Text = _alunoSelecionado.Id.ToString();
                TxtNome.Text = _alunoSelecionado.Nome;
                TxtEmail.Text = _alunoSelecionado.Email;
                DtpDtNascimento.Value = _alunoSelecionado.DtNascimento;
                DtpDtMatricula.Value = _alunoSelecionado.DtMatricula;
                CkbAtivo.Checked = _alunoSelecionado.Ativo;

                BtnCadastrar.Enabled = false;
                BtnAlterar.Enabled = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                                   "Erro",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                throw;
            }
            
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {

                _alunoSelecionado.Nome = TxtNome.Text;
                _alunoSelecionado.DtNascimento = DtpDtNascimento.Value;
                _alunoSelecionado.DtMatricula = DtpDtMatricula.Value;
                _alunoSelecionado.Email = TxtEmail.Text;

                _alunoSelecionado.Alterar();
                CarregaDgvUsuarios();

            } 
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                                  "Erro",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);

                throw;
            }
        }

        private void DgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

            try
            {
               DialogResult dr = MessageBox.Show($"Você realmente deseja remover {_alunoSelecionado.Nome}? "
                                , "Remove Aluno"
                                ,MessageBoxButtons.YesNo
                                , MessageBoxIcon.Question);

                if (dr == DialogResult.Yes) 
                {
                    _alunoSelecionado.Ativo = false;
                    _alunoSelecionado.Excluir();
                    CarregaDgvUsuarios();
                        
                    //Realizar o update do ativo para 0 de quem esta selecionado.
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                throw;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
          List<Aluno> ListaAlunosFiltrada =  Aluno.Buscar(_alunos, CbbBuscar.SelectedIndex, TxtBuscar.Text);
            CarregaDgvUsuarios(ListaAlunosFiltrada);
        }
    }
}
