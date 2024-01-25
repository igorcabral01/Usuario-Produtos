using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Usuario.models;

namespace Usuario.Products
{
    public class AdicionarProdutos : CadastroUsuarios
    {
        List<string> Produtos = new List<string>();
        public string AdicionarProdutosNaTabela { get; private set; }

        public void AdcProdut()
        {
            Console.WriteLine("Gestor Adicione Produtos Disponiveis ");
           Produtos.Add("Lapis");
           Produtos.Add("papel");
           Produtos.Add("borracha");
           Produtos.Add("caneta");
           Console.WriteLine($"Aqui Estao os produtos disponiveis para compra");
           for (int i = 0; i < Produtos.Count; i++)
             {
            Console.WriteLine($"{i}-{Produtos[i]}");
           }
        }
    }
}