using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace AtivSem01
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variaveis de Controle para continuar ou sair do sistema (do while)//

            char opcao;
            bool sair;

            do
            {
                //Inicio do programa

                Funcoes funcoes = new Funcoes();
                Clientes clientes = new Clientes();
                Pedidos pedidos = new Pedidos();

                int menu;
                Console.Clear();
                Console.WriteLine("Menu para Chamar as Funções: " +
                                  "\n 1- Somar Valores da Matriz" +
                                  "\n 2- Verificar o Maior Número: " +
                                  "\n 3- Instanciar um usuario: ");

                menu = Convert.ToInt32(Console.ReadLine());


                try
                //Verificação de Erro para todas as Funções
                {
                    switch (menu)
                    {

                        case 1: //Chamada para a função que Soma a Matriz

                            funcoes.matrizSomatoria();
                            break;

                        case 2: //Chama a Função que retorna o maior númerico
                            funcoes.MaiorNumero();
                            break;

                        case 3:
                            Console.WriteLine("Informe o nome do usuario: ");
                            clientes.nome = Console.ReadLine();
                            Console.WriteLine("Informe o Id do usuario ");
                            clientes.id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Informe o e-mail do usuario do usuario: ");
                            clientes.email = Console.ReadLine();
                            Console.WriteLine("Informe Nome do pedido: ");
                            pedidos.infoProduto = Console.ReadLine();
                            Console.WriteLine("Informe o Numero do Pedido ");
                            pedidos.idPedido = Convert.ToInt32(Console.ReadLine());

                            //Preenchendo a String de conexão
                            pedidos.Conexao = "strCon";
                            clientes.Conexao = "strCon";

                            Console.WriteLine("Cliente e Pedidos Salvos Com Sucesso ! ");
                            break;

                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ex: " + ex.Message);
                }

                //Verificar se o usuário deeja continuar no sistema
                Console.WriteLine("\nDeseja Sair do programa ?\n'S' para sim e 'N' para não");
                opcao = Convert.ToChar(Console.ReadLine());
                if (opcao == 'n' || opcao == 'N')
                {
                    sair = true;
                }
                else
                {
                    sair = false;
                }

            } while (sair != false);


            Console.WriteLine("\nPrograma finalizado com sucesso. Obrigado!");

        }
    }

}