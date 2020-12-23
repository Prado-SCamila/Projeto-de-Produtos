using System;
using System.Collections.Generic;
namespace Projeto_de_Produtos.classes
{
    public class Produto
    {
        public int Codigo {get; set;}

        public string NomeProduto {get;set;}

        public Marca Marca {get;set;}

        public float Preco {get;set;}

        public Usuario CadastradoPor {get;set;}

        public DateTime DataCadastro {get;set;}

        public List<Produto> ListaDeProdutos {get;set;}

        public void Cadastrar(){
            Produto novoProduto = new Produto();
            Console.WriteLine("Digite o Código do Produto");
            Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do produto");
            NomeProduto = Console.ReadLine();

            Console.WriteLine("Digite o Preço do Produto");
            Preco = float.Parse(Console.ReadLine());

            DataCadastro = DateTime.UtcNow;

            novoProduto.Marca = Marca.CadastrarMarca();

            novoProduto.CadastradoPor = new Usuario();

            ListaDeProdutos.Add(novoProduto);

        }

        public void Listar(){
            Console.ForegroundColor = ConsoleColor.Green;
            foreach(var item in ListaDeProdutos){
                Console.WriteLine($"Codigo {item.Codigo}");
                   Console.WriteLine($"Produto: {item.NomeProduto}");
                      Console.WriteLine($"Preço : {item.Preco}");
                         Console.WriteLine($"Data de Cadastro : {item.DataCadastro}");
                            Console.WriteLine($"Marca : {item.Marca.NomeMarca}");
                               Console.WriteLine($"Cadastrado Por : {item.CadastradoPor}");
                               Console.WriteLine();
            }
            Console.ResetColor();
        }
        public void Deletar(int cod){
            Produto prodDelete = ListaDeProdutos.Find(p => p.Codigo == cod);
            ListaDeProdutos.Remove(prodDelete);

        }

    }
}