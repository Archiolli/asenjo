using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace BANCO
{
    internal class ContaBLL
    {
        public static void conecta()
        {
            UsuarioDAL.conecta();
        }

        public static void desconecta()
        {
            UsuarioDAL.desconecta();
        }

        public static void login(Usuario user)
        {
            Erro.setErro(false);
            if (user.getCpf().Equals(""))
            {
                Erro.setMsg("O cpf é de preenchimento obrigatório!");
                return;
            }
            if (user.getSenha().Equals(""))
            {
                Erro.setMsg("A senha é de preenchimento obrigatório!");
                return;
            }
            UsuarioDAL.verificaCpf(user);
        }


    }
}
