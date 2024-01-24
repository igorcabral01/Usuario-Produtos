using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Usuario.models
{
    public class PaginaLogin : CadastroUsuarios
    {
        public string UsuarioLogin { get; set; }
        public string SenhaLogin { get; set; }
        public string EmailLogin { get; set; }

        public void ConferirLogin()
        {
            Console.WriteLine("Digite Usuario e Senha Para Efetuar o Login");
            Console.WriteLine("USUARIO:");
            UsuarioLogin = Console.ReadLine();
            Console.WriteLine("SENHA:");
            SenhaLogin = Console.ReadLine();

            
        }
        
        
      
    }
}