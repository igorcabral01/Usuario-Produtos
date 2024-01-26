using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Usuario.Products;

namespace Usuario.models
{
    public  class CadastroUsuarios : AdicionarProdutos
    {
        List<string>AddUsuario = new List<string> ();

        public CadastroUsuarios(int lapis, int papel, int caneta) : base(lapis, papel, caneta)
        {
        }

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
            Console.WriteLine("Login Efetuado Com Sucesso! \n Lista Disponivel");
            bool exibir = true;
            while (exibir)
            {
                Console.Clear();
                Console.WriteLine("Bem Vindo ao Mercado Online! ");
                Console.WriteLine("Digite Abaixo Sua Opção ");
                Console.WriteLine("");
                Console.WriteLine("1 Itens Disponiveis");
                Console.WriteLine("2 Adicionar no Carrinho");
                Console.WriteLine("3 Finalizar Compra");
                Console.WriteLine("4 Sair");
                
                switch (Console.ReadLine())
                {
                    case "1":
                    Console.WriteLine("Lapis");
                    lapis();
                    Console.WriteLine($"Caneta");
                    caneta();
                    Console.WriteLine("Papel");
                    papel();

                     break;
                    case "2":

                     break;

                    case "3":

                    break;

                     case "8":
                     exibir = false;
                     break;
                     
                    
                    
                    
                    default:
                    Console.WriteLine("opcao invalida");
                    break;
                }
            }
        }else
        {
           while (LoginUsu != Usuario && LoginSen != Senha)
           {
             Console.WriteLine("Usuario ou senha incorretos");
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