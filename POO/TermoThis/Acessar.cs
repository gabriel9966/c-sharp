using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{
    internal class Acessar
    {
        String senha = "abc123";
        //Em C#, a palavra-chave this é usada para se referir ao próprio objeto
        //atual dentro do contexto de uma classe. Ela permite acessar membros
        //(métodos, propriedades e campos) da própria instância da classe em que
        //o código está sendo executado.
        public bool Login(String senha)
        {
            return this.senha == senha;
           
        }
    }
}
