using System;
using System.Collections.Generic;

namespace Projeto_de_Produtos.classes
{
    public class Marca
    {
        public int Codigo {get;set;}

        public string NomeMarca {get; set;}

        public DateTime DataCadastro {get; set;}

        List<Marca> Marcas {get;set;}

        public Marca CadastrarMarca(){

            Marca novaMarca = new Marca();

            Console.WriteLine("Digite o Código da Marca: ");
            novaMarca.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da Marca :");
            novaMarca.NomeMarca = Console.ReadLine();

            DataCadastro = DateTime.UtcNow;

            Marcas.Add(novaMarca);

            return novaMarca;
        }
        
        public void Listar(){
            Console.WriteLine("Marcas Cadastradas: ");
            foreach(Marca item in Marcas){
                Console.WriteLine($"Código:{item.Codigo}");
                 Console.WriteLine($"Código:{item.NomeMarca}");
                  Console.WriteLine($"Código:{item.DataCadastro}");
            }
        }
        public void Deletar(int cod){

            Marca marcaDelete = Marcas.Find(m =>m.Codigo ==cod);
            Marcas.Remove(marcaDelete);
        }

    }
}