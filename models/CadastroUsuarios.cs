using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Usuario.models
{
    public  class CadastroUsuarios
    {
        List<string>AddUsuario = new List<string> ();
        public string Usuario { get; private set; }
        public string Senha { get;private  set; }
        public string Email { get; private set; }
       
       public void CadastraUsuarios()
       {
        Console.WriteLine("Digite seu Usuario e Senha para Cadastro");
        Console.Write("USUARIO : ");
        Usuario = Console.ReadLine();
        Console.Write("SENHA : ");
        Senha = Console.ReadLine();
        Console.Write("EMAIL : ");
        Email = Console.ReadLine();
        AddUsuario.Add(Usuario);
        AddUsuario.Add(Senha);
        AddUsuario.Add(Email);
       }
       
       public string LoginUsu { get;private set; }
       public string LoginSen { get; private set; }
       public void Login()
       {
        Console.WriteLine("Bem Vindo A pagina de Login \n Digite Seu Usuario E Senha ");
         Console.Write("USUARIO : ");
          LoginUsu = Console.ReadLine();
          Console.Write("SENHA : ");
        LoginSen = Console.ReadLine();
       }

       public void AutenticarUsuario()
       {
        if( LoginUsu == Usuario && LoginSen == Senha)
        {
            Console.WriteLine("Login Efetuado Com Sucesso!");
        }else
        {
            Console.WriteLine("Usuario Ou Senha Incorretos!");
            while (false)
            {
                break;
            }
        }
       }
       public void ListarUsuario()
        {
            for (int i = 0; i < AddUsuario.Count; i++)
            {
                Console.WriteLine($"{i} - {AddUsuario[i]}");
            }
        }
       
       
       
        

    

        
    }
}