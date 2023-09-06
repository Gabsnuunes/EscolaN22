using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola_POO_BASE.Classes
{
    public class Aluno : Usuario
    {
        #region Propriedades
        public DateTime DtMatricula { get; set; }
        #endregion

        #region Construtores
        public Aluno()
        {

        }

        public Aluno(int id, string nome, DateTime dtNascimento, DateTime dtMatricula, string email, string senha, bool ativo) : base(id, nome, dtNascimento, email, senha, ativo)
        {
            DtMatricula = dtMatricula;
        }
        #endregion

        #region Métodos
        public void Cadastrar(List<Aluno> alunos)
        {


            string query = string.Format($"Insert Into Aluno Values ('{Nome}', '{DtNascimento}', '{DtMatricula}', '{Email}','{Crypto.Sha256("123")}', 1)");
            query += "; Select Scope_Identity()";
            Conexao cn = new Conexao(query);


            try
            {
                cn.AbrirConexao();
                Id = Convert.ToInt32(cn.comando.ExecuteScalar());
                
            }
            catch (Exception)
            {
                throw;
            }
            finally 
            { 
            
                cn.FecharConexão();
            
            }
        }
        public void Alterar() 
        {
            string query = string.Format($"Update Aluno Nome = '{Nome}', DtNascimento, '{DtNascimento}', DtMatricula, '{DtMatricula}', Email, '{Email}', where Id {Id}");
            Conexao cn = new Conexao(query);



            try
            {
                cn.AbrirConexao();
                cn.comando.ExecuteNonQuery();
                
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

                cn.FecharConexão();

            }
        }
        public void Excluir() 
        {  
            string query = string.Format($"update Aluno set Ativo = 0  where id = {Id}");
            Conexao cn = new Conexao(query);

            try
            {
                cn.AbrirConexao();
                cn.comando.ExecuteNonQuery();
                

            }
            catch (Exception)
            {

                throw;
            }
            finally 
            {
               
                cn.FecharConexão();

            }
            
        }
        public static List<Aluno> Buscar(List<Aluno> alunos, int indexCbbBuscar, string texto)
        {

         switch (indexCbbBuscar) 
            {
                 case 0:
                    //Busca por Nome

                    return alunos.Where(a => a.Nome.ToUpper().Normalize(NormalizationForm.FormD).Contains(texto.ToUpper())).ToList();

                    // break; quando nao for return, é obrigatorio o uso do break.
                case 1:
                    //Busca por email

                    return alunos.Where (a => a.Email.Contains(texto)).ToList();

                //break; quando nao for return, é obrigatorio o uso do break.
                case 2:
                    //Busca por Matrícula (Id)
                    return alunos.Where(a => a.Id == Convert.ToInt32(texto)).ToList();

                // break; quando nao for return, é obrigatorio o uso do break.

                default:
                    //Retornar a lista sem filtro

                    return alunos;
                    // break;  quando nao for return, é obrigatorio o uso do break.

            }

        }
        #endregion
    }
}
