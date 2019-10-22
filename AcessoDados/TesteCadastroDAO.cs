using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Entidade;

namespace AcessoDados
{
    public class TesteCadastroDAO
    {
        private BD bd = null;

        public List<EntTesteCadastro> BuscarCadastro(EntTesteCadastro cadastro)
        {
            if (cadastro != null)
            {
                bd = new BD();
                StringBuilder sql = new StringBuilder();
                DataSet ds = null;
                List<EntTesteCadastro> lstCadastro = new List<EntTesteCadastro>();

                SqlCommand scomand = new SqlCommand();

                scomand.CommandType = CommandType.StoredProcedure;
                scomand.CommandText = "dbo.EMPRESA_CONS_PROCEDURE";
                scomand.Parameters.Add(new SqlParameter("@NOME", cadastro.Nome));

                ds = bd.ExecutarProcedureConsulta(scomand);

                foreach (DataRow linha in ds.Tables[0].Rows)
                {

                   EntTesteCadastro a = new EntTesteCadastro();

                    a.Nome = linha["NOME"].ToString();
                    a.Qtdfunc = Convert.ToInt32(linha["QTDFUNC"]);
                    a.Endereco = linha["ENDERECO"].ToString();

                    lstCadastro.Add(a);
                }
                return lstCadastro;
            }
            else
            {
                return null;
            }
        }

    }
}
