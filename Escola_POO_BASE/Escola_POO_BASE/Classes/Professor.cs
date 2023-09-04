using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_POO_BASE.Classes
{
    public class Professor : Usuario
    {
        #region Propriedades
        public string CPF { get; set; }
        public int NivelAcesso { get; set; }
        #endregion

        #region Construtores
        public Professor()
        {
            
        }

        public Professor(int id, string nome, DateTime dtNascimento, string cPF, string email, string senha, int nivelAcesso, bool ativo) : base(id, nome, dtNascimento, email, senha, ativo)
        {
            CPF = cPF;
            NivelAcesso = nivelAcesso;
        }
        #endregion

        #region Métodos
       
        
        #endregion
    }
}
