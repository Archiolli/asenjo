using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANCO
{
    public class Usuario
    {
        private static String codigo;
        private String nome;
        private static String cpf;
        private String senha;
        private float saldo;

        public void setCodigo(String _codigo) { codigo = _codigo; }
        public void setNome(String _nome) { nome = _nome; }
        public void setCpf(String _cpf) { cpf = _cpf; }
        public void setSenha(String _senha) { senha = _senha; }
        public void setSaldo(float _saldo) { saldo = _saldo; }

        public String getCodigo() { return codigo; }
        public String getNome() { return nome; }
        public String getCpf() { return cpf; }
        public String getSenha() { return senha; }
        public float getSaldo() { return saldo; }
    }
}
