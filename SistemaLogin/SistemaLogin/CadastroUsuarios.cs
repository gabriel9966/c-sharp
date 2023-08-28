using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    internal static class CadastroUsuarios
    {
        private static Usuario[] usuarios =
            {
            new Usuario(){Nome = "Gabriel",Senha = "abc123"},//Usando Chaves {} para Inicializador de Objetos:
//Ao usar chaves {} para criar e inicializar um objeto, você está usando um inicializador de objetos. Isso é útil quando você quer definir os valores das propriedades do objeto durante sua criação, de forma mais concisa e direta.
            new Usuario(){Nome = "Lucas" , Senha = "abc321"},
            new Usuario(){Nome = "Vitor" , Senha = "123abc"}
            };
        private static Usuario _userLogado = null;

        public static Usuario UsuarioLogado
        {
            get { return _userLogado; } 
            private set {  _userLogado = value; }
        }

        public static bool Login(string nome , string senha)
        {
            foreach (Usuario usuario in usuarios)
            {
                if(usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }

            }

            return false;
        }
    }
}
