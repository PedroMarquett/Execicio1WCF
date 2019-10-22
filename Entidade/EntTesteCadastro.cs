using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidade
{
    public class EntTesteCadastro
    {
        #region Atributo
        private string _nome;
        private int _qtdfunc;
        private string _endereco;
        #endregion

        #region Propriedade
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }
        public int Qtdfunc
        {
            get
            {
                return _qtdfunc;
            }
            set
            {
                _qtdfunc = value;
            }
        }
        public string Endereco
        {
            get
            {
                return _endereco;
            }
            set
            {
                _endereco = value;
            }
        }
        #endregion
    }
}
