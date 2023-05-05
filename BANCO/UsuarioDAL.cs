using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace BANCO
{
    internal class UsuarioDAL
    {
        private static String strConexao = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BDCaixa.mdb";
        private static OleDbConnection conn = new OleDbConnection(strConexao);
        private static OleDbCommand strSQL;
        private static OleDbDataReader result;

        public static void conecta()
        {
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                Erro.setMsg("Problemas ao se conectar ao Banco de Dados");
            }

        }

        public static void desconecta()
        {
            conn.Close();
        }

        public static void inseriUmaPessoa(Usuario umapessoa)
        {
            String aux = "insert into TabUsuario(nome,cpf,senha) values (@nome,@cpf,@senha)";
            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.Add("@nome", OleDbType.VarChar).Value = umapessoa.getNome();
            strSQL.Parameters.Add("@cpf", OleDbType.VarChar).Value = umapessoa.getCpf();
            strSQL.Parameters.Add("@senha", OleDbType.VarChar).Value = umapessoa.getSenha();

            strSQL.ExecuteNonQuery();
        }

        public static void verificaCpf(Usuario user)
        {
            string senha;
            String aux = "select senha from TabUsuario where cpf = @cpf";
            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.Add("@cpf", OleDbType.VarChar).Value = user.getCpf();
            result = strSQL.ExecuteReader();
            Erro.setErro(false);
            if (result.Read())
            {
                senha = result.GetString(0);
                if (senha != user.getSenha())
                {
                    Erro.setMsg("senha invalida!");
                }

            }
            else
                Erro.setMsg("cpf não encontrado!");
        }
        
    }
}