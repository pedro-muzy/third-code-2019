using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLogin_ProjetoEnari
{
    
    class ListadeUsuarios
    {
        usuario user = new usuario();

        private string[] userList = new string[100];
        string[] userItem = new string[4];

        public ListadeUsuarios()
        {

        }
        public void adicionar()
        {
            userItem[0] = user.getNome();
            userItem[1] = Convert.ToString(user.getCPF());
            userItem[2] = user.getEmail();
            userItem[3] = user.getSenha();
        }

    }
}
