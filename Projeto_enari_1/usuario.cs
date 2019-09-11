using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLogin_ProjetoEnari
{
    class usuario
    {
        private string nome, email, senha;
        private int cpf;

        //SET's
        public void setNome(string nome_digitado)
        {
            nome = nome_digitado;
        }

        public void setEmail(string email_digitado)
        {
             email = email_digitado;
        }
        public void setSenha(string senha_digitada)
        {
            senha = senha_digitada;
        }
        public void setCPF(int cpf_digitado)
        {
            cpf = cpf_digitado;
        }

        //GET's
        public string getNome()
        {
            return nome;
        }
        
        public string getEmail()
        {
            return email;
        }

        public string getSenha()
        {
            return senha;
        }

        public int getCPF()
        {
            return cpf;
        }
    }
}
