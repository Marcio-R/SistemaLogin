using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    static class CadastroUsuarios
    {
        private static Usuario[] usuarios =
        {
            new Usuario(){ Nome = "Marcio",Senha = "abc123"},
            new Usuario(){Nome = "Danny",Senha = "123abc"},
            new Usuario(){Nome = "Ronaldo",Senha = "143abc"}
        };

        private static Usuario userLogado = null;

        public static Usuario UsurioLogado
        {
            get { return userLogado; }
            private set { userLogado = value; }
        }

        public static bool Login(string nome, string senha)
        {
            foreach (Usuario usuario in usuarios)
            {
                if(usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsurioLogado = usuario;
                    return true;
                }    
            }
            return false;
        }
    }
}
