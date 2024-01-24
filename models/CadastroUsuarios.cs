using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Usuario.models
{
    public  class CadastroUsuarios
    {
        List<string> ListUsuario = new List<string>();
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }

        public void CadastraUsuario()
        {
            ListUsuario.Add(Usuario);
            ListUsuario.Add(Senha);
            ListUsuario.Add(Email);
            Console.WriteLine("\n");
        }

    

        
    }
}