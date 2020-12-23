using System;

namespace Projeto_de_Produtos.classes
{
    public class Login
    {
        public bool Logado {get; set;}


        public Login(){
            Usuario user = new Usuario();
            Logar(user);
        }
            if(Logado){
                GerarMenu();
        }
        public void GerarMenu(){

            string opcao;

            do{
                 Console.WriteLine("Escolha uma opção:");
                        Console.WriteLine("1- Cadastrar produto");
                               Console.WriteLine("2- Listar produto");
                                      Console.WriteLine("3- Deletar produto");
                                             Console.WriteLine("4- Cadastrar Marca");
                                                    Console.WriteLine("5- Listar Marca");
                                                           Console.WriteLine("6- Deletar Marca");
                                                                  Console.WriteLine("0- Sair");
                                                                  
                                                                  opcao = Console.ReadLine();

                                                                  switch(opcao){

                                                                      case 1: produto.Cadastrar();
                                                                      break;

                                                                      case 2:
                                                                            produto.Listar();
                                                                      break;

                                                                      case 3:
                                                                        Console.WriteLine("Digite um codigo para excluir");
                                                                        int cod = int.Parse(Console.ReadLine());
                                                                        produto.Deletar(cod);
                                                                      break;

                                                                      case 4:
                                                                        marca.CadastrarMarca();
                                                                      break;

                                                                      case 5:
                                                                      marca.Listar();
                                                                      break;

                                                                      case 6:
                                                                      Console.WriteLine("Digite um código para excluir");
                                                                      int codMarca = int.Parse(Console.ReadLine());
                                                                      marca.Deletar(codMarca);
                                                                      break;

                                                                      default:
                                                                      break;
                                                                  }

            }while(opcao !="0");
           

        }

        public void Logar(Usuario usuario){
             Console.WriteLine("Digite um email: ");
             string emailLogin = Console.ReadLine();

            Console.WriteLine("Digite sua senha: ");
            string senhaLogin = Console.ReadLine();

            if(emailLogin == usuario.Email && senhaLogin == usuario.Senha){
                Logado = true;
                  Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Logado com sucesso");
                Console.ResetColor();
            }else{
                  Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Falha ao logar na aplicação");
            }

        }
        public void Deslogar(Usuario usuario){

        }
    }
