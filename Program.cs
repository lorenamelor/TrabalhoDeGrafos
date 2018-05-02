/*
 AUTOR: Lorena Carla de Melo Rabelo e Amanda Brasil
 DESCRIÇÃO: Programa para criar um grafo não ponderado e não direcionado e verificar suas características.
 DATA: 01/05/2018
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoDeGrafos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = -1;
            do
            {
                menu:
                Console.Clear();
                Console.Write("MENU PRINCIPAL\n\n" +
                    "1. Criar um grafo e sua matriz de adjacência\n" +
                    "2. Criar um grafo e sua lista de adjacência\n" +
                    "0. Sair\n" +
                    "\nOpcão: ");
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Write("OPÇÃO INVÁLIDA!");
                }


                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("*************CONSTRUINDO UM GRAFO NÃO DIRECIONADO****************\n\n");
                        Console.Write("Digite a quantidade de vértices que terá o grafo: ");
                        int verticesMA = int.Parse(Console.ReadLine());
                        GrafoMA grafoMA = new GrafoMA(verticesMA);
                        int[,] matrizAdjacencia = new int[verticesMA, verticesMA];


                        do
                        {
                            Console.Clear();
                            Console.Write("MENU\n\n" +
                                "1. Ordem do grafo\n" +
                                "2. Inserir aresta\n" +
                                "3. Remover aresta\n" +
                                "4. Grau de um vértice\n" +
                                "5. Verificar se o grafo é completo\n" +
                                "6. Verificar se o grafo é regular\n" +
                                "7. Imprimir matriz de adjacência\n" +
                                "8. Imprimir lista de adjacência\n" +
                                "9. Sequência de graus\n" +
                                "10. Vértices adjacentes\n" +
                                "11. Verificar se há vértices isolados\n" +
                                "12. Verificar se um vértice é par\n" +
                                "13. Verificar se um vértice é impar\n" +
                                "14. Verificar a existência de uma aresta\n" +
                                "0. Voltar ao menu principal\n" +
                                "Opcão: ");
                            try
                            {
                                opcao = int.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.Write("OPÇÃO INVÁLIDA!");
                            }


                            switch (opcao)
                            {
                                
                                case 1:
                                    int continuar, v1, v2, v;
                                    Console.Clear();
                                    Console.Write("\nORDEM DO GRAFO\n");
                                    Console.Write("\nA ordem do grafo é: " + grafoMA.Ordem());
                                    Console.ReadKey();
                                    break;                              
                                case 2:
                                    Console.Clear();
                                    Console.Write("\nINSERINDO ARESTA\n");
                                    do
                                    {
                                        Console.Write("\nDigite o 1° vértice: ");
                                        v1 = int.Parse(Console.ReadLine());

                                        Console.Write("\nDigite o 2° vértice: ");
                                        v2 = int.Parse(Console.ReadLine());

                                        grafoMA.InsereAresta(v1, v2);
                                        Console.Write("\nDeseja inserir uma nova aresta? [1] Sim - [0] Não: ");
                                        continuar =
                                            int.Parse(Console.ReadLine());
                                    } while (continuar == 1);


                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.Write("\nEXCLUINDO UMA ARESTA\n");
                                    do
                                    {
                                        Console.Write("\nDigite o 1° vértice: ");
                                        v1 = int.Parse(Console.ReadLine());

                                        Console.Write("\nDigite o 2° vértice: ");
                                        v2 = int.Parse(Console.ReadLine());

                                        grafoMA.RetiraAresta(v1, v2);
                                        Console.Write("\nDeseja retirar outra aresta? [1] Sim - [0] Não: ");
                                        continuar = int.Parse(Console.ReadLine());
                                    } while (continuar == 1);

                                    break;
                                case 4:
                                    Console.Clear();
                                    Console.Write("\nVERIFICANDO O GRAU DE UM VÉRTICE\n");
                                    do
                                    {
                                        Console.Write("\nDigite o vértice: ");
                                        v1 = int.Parse(Console.ReadLine());

                                        Console.Write("\nO grau do vértice é: " + grafoMA.Grau(v1));
                                        Console.Write("\nDeseja verificar o grau de outro vértice? [1] Sim - [0] Não: ");
                                        continuar = int.Parse(Console.ReadLine());
                                    } while (continuar == 1);

                                    break;
                                case 5:
                                    Console.Clear();
                                    Console.Write("\nVERIFICANDO SE O GRAFO É COMPLETO\n");
                                    Console.Write("\nO grafo é completo?  " + grafoMA.Completo());
                                    Console.ReadKey();
                                    break;
                                case 6:
                                    Console.Clear();
                                    Console.Write("\nVERIFICANDO SE O GRAFO É REGULAR\n");
                                    Console.Write("\nO grafo é regular?  " + grafoMA.Regular());
                                    Console.ReadKey();
                                    break;
                                case 7:
                                    Console.Clear();
                                    Console.Write("\nMATRIZ DE ADJACÊNCIA\n\n");
                                    grafoMA.ShowMA(matrizAdjacencia);
                                    Console.ReadKey();
                                    break;
                                case 8:
                                    Console.Clear();
                                    Console.Write("\nLISTA DE ADJACÊNCIA\n\n");
                                    grafoMA.ShowLA();
                                    Console.ReadKey();
                                    break;
                                case 9:
                                    Console.Clear();
                                    Console.Write("\nSEQUÊNCIA DE GRAUS DO GRAFO\n");
                                    grafoMA.SequenciaGraus();
                                    Console.ReadKey();
                                    break;
                                case 10:
                                    Console.Clear();
                                    Console.Write("\nLISTANDO OS VÉRTICES ADJACENTES\n");
                                    Console.Write("\nDigite o vértice para listar o seus adjacentes: ");
                                    v = int.Parse(Console.ReadLine());
                                    grafoMA.VerticesAdjacentes(v);
                                    Console.ReadKey();
                                    break;
                                case 11:
                                    Console.Clear();
                                    Console.Write("\nVERIFICANDO A EXISTÊNCIA DE VÉRTICES ISOLADOS\n");
                                    Console.Write("\nDigite o vértice: ");
                                    v = int.Parse(Console.ReadLine());
                                    Console.Write("\nEste vértice é isolado?\nResposta: " + grafoMA.Isolado(v));
                                    Console.ReadKey();
                                    break;
                                case 12:
                                    Console.Clear();
                                    Console.Write("\nVERIFICANDO SE O VÉRTICE É PAR\n");
                                    Console.Write("\nDigite o vértice: ");
                                    v = int.Parse(Console.ReadLine());
                                    Console.Write("\nEste vértice é par?\nResposta: " + grafoMA.Par(v));
                                    Console.ReadKey();
                                    break;
                                case 13:
                                    Console.Clear();
                                    Console.Write("\nVERIFICANDO SE O VÉRTICE É IMPAR\n");
                                    Console.Write("\nDigite o vértice: ");
                                    v = int.Parse(Console.ReadLine());
                                    Console.Write("\nEste vértice é impar?\nResposta: " + grafoMA.Impar(v));
                                    Console.ReadKey();
                                    break;
                                case 14:
                                    Console.Clear();
                                    Console.Write("\nVERIFICANDO A EXISTÊNCIA DE UMA ARESTA\n");
                                    do
                                    {
                                        Console.Write("\nDigite o 1° vértice: ");
                                        v1 = int.Parse(Console.ReadLine());

                                        Console.Write("\nDigite o 2° vértice: ");
                                        v2 = int.Parse(Console.ReadLine());

                                        if (grafoMA.Adjacentes(v1, v2))
                                            Console.Write("\nAresta existente!");
                                        else
                                            Console.Write("\nAresta não existente!");
                                        Console.Write("\n\nDeseja buscar uma nova aresta? [1] Sim - [0] Não: ");
                                        continuar = int.Parse(Console.ReadLine());
                                    } while (continuar == 1);
                                    break;
                                
                                case 0:
                                    goto menu;
                                    break;
                                default:
                                    Console.Write("\n\nOpção inválida!");
                                    break;
                            }

                        } while (opcao != 0);

                        Console.ReadKey();

                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("*************CONSTRUINDO UM GRAFO NÃO DIRECIONADO****************\n\n");
                        Console.Write("Digite a quantidade de vértices que terá o grafo: ");
                        int verticesLA = int.Parse(Console.ReadLine());
                        GrafoLA grafo = new GrafoLA(verticesLA);

                        do
                        {
                            Console.Clear();
                            Console.Write("MENU\n\n" +
                                "1. Ordem do grafo\n" +
                                "2. Inserir vértice\n" +
                                "3. Remover vértice\n" +
                                "4. Inserir aresta\n" +
                                "5. Remover aresta\n" +
                                "6. Grau de um vértice\n" +
                                "7. Verificar se o grafo é completo\n" +
                                "8. Verificar se o grafo é regular\n" +
                                "9. Imprimir lista de adjacência\n" +
                                "10. Sequência de graus\n" +
                                "11. Vértices adjacentes\n" +
                                "12. Verificar se há vértices isolados\n" +
                                "13. Verificar se um vértice é par\n" +
                                "14. Verificar se um vértice é impar\n" +
                                "15. Verificar a existência de uma aresta\n" +
                                "0. Voltar ao menu principal\n" +
                                "Opcão: ");
                            try
                            {
                                opcao = int.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.Write("OPÇÃO INVÁLIDA!");
                            }


                            switch (opcao)
                            {
                                case 1:
                                    int continuar, v1, v2;
                                    Console.Clear();
                                    Console.Write("\nORDEM DO GRAFO\n");
                                    Console.Write("\nA ordem do grafo é: " + grafo.Ordem());
                                    Console.ReadKey();
                                    break;

                                case 2:
                                    Console.Clear();
                                    int v;
                                    Console.Write("\nINSERE VERTICE\n");
                                    do
                                    {
                                        Console.Write("\nDigite o novo vértice: ");
                                        v = int.Parse(Console.ReadLine());

                                        grafo.InsereVertice(v);
                                        Console.Write("\nDeseja inserir um novo vértice? [1] Sim - [0] Não: ");
                                        continuar = int.Parse(Console.ReadLine());
                                    } while (continuar == 1);

                                    break;

                                case 3:
                                    Console.Clear();
                                    Console.Write("\nEXCLUINDO UM VÉRTICE\n");
                                    do
                                    {
                                        Console.Write("\nDigite o vértice para excluir: ");
                                        v = int.Parse(Console.ReadLine());
                                        grafo.RetiraVertice(v);
                                        Console.Write("\nDeseja excluir outro vértice? [1] Sim - [0] Não: ");
                                        continuar = int.Parse(Console.ReadLine());
                                    } while (continuar == 1);



                                    break;
                                case 4:
                                    Console.Clear();
                                    Console.Write("\nINSERINDO ARESTA\n");
                                    do
                                    {
                                        Console.Write("\nDigite o 1° vértice: ");
                                        v1 = int.Parse(Console.ReadLine());

                                        Console.Write("\nDigite o 2° vértice: ");
                                        v2 = int.Parse(Console.ReadLine());

                                        grafo.InsereAresta(v1, v2);                                      
                                        Console.Write("\nDeseja inserir uma nova aresta? [1] Sim - [0] Não: ");
                                        continuar =
                                            int.Parse(Console.ReadLine());
                                    } while (continuar == 1);


                                    break;
                                case 5:
                                    Console.Clear();
                                    Console.Write("\nEXCLUINDO UMA ARESTA\n");
                                    do
                                    {
                                        Console.Write("\nDigite o 1° vértice: ");
                                        v1 = int.Parse(Console.ReadLine());

                                        Console.Write("\nDigite o 2° vértice: ");
                                        v2 = int.Parse(Console.ReadLine());

                                        grafo.RetiraAresta(v1, v2);
                                        Console.Write("\nDeseja retirar outra aresta? [1] Sim - [0] Não: ");
                                        continuar = int.Parse(Console.ReadLine());
                                    } while (continuar == 1);

                                    break;
                                case 6:
                                    Console.Clear();
                                    Console.Write("\nVERIFICANDO O GRAU DE UM VÉRTICE\n");
                                    do
                                    {
                                        Console.Write("\nDigite o vértice: ");
                                        v1 = int.Parse(Console.ReadLine());

                                        Console.Write("\nO grau do vértice é: " + grafo.Grau(v1));
                                        Console.Write("\nDeseja verificar o grau de outro vértice? [1] Sim - [0] Não: ");
                                        continuar = int.Parse(Console.ReadLine());
                                    } while (continuar == 1);

                                    break;
                                case 7:
                                    Console.Clear();
                                    Console.Write("\nVERIFICANDO SE O GRAFO É COMPLETO\n");
                                    Console.Write("\nO grafo é completo?  " + grafo.Completo());
                                    Console.ReadKey();
                                    break;
                                case 8:
                                    Console.Clear();
                                    Console.Write("\nVERIFICANDO SE O GRAFO É REGULAR\n");
                                    Console.Write("\nO grafo é regular?  " + grafo.Regular());
                                    Console.ReadKey();
                                    break;
                                case 9:
                                    Console.Clear();
                                    Console.Write("\nLISTA DE ADJACÊNCIA\n");
                                    grafo.ShowLA();
                                    Console.ReadKey();
                                    break;
                                case 10:
                                    Console.Clear();
                                    Console.Write("\nSEQUÊNCIA DE GRAUS DO GRAFO\n\n");
                                    grafo.SequenciaGraus();
                                    Console.ReadKey();
                                    break;
                                case 11:
                                    Console.Clear();
                                    Console.Write("\nLISTANDO OS VÉRTICES ADJACENTES\n");
                                    Console.Write("\nDigite o vértice para listar o seus adjacentes: ");
                                    v = int.Parse(Console.ReadLine());
                                    grafo.VerticesAdjacentes(v);
                                    Console.ReadKey();
                                    break;
                                case 12:
                                    Console.Clear();
                                    Console.Write("\nVERIFICANDO A EXISTÊNCIA DE VÉRTICES ISOLADOS\n");
                                    Console.Write("\nDigite o vértice: ");
                                    v = int.Parse(Console.ReadLine());
                                    Console.Write("\nEste vértice é isolado?\nResposta: " + grafo.Isolado(v));
                                    Console.ReadKey();
                                    break;
                                case 13:
                                    Console.Clear();
                                    Console.Write("\nVERIFICANDO SE O VÉRTICE É PAR\n");
                                    Console.Write("\nDigite o vértice: ");
                                    v = int.Parse(Console.ReadLine());
                                    Console.Write("\nEste vértice é par?\nResposta: " + grafo.Par(v));
                                    Console.ReadKey();
                                    break;
                                case 14:
                                    Console.Clear();
                                    Console.Write("\nVERIFICANDO SE O VÉRTICE É IMPAR\n");
                                    Console.Write("\nDigite o vértice: ");
                                    v = int.Parse(Console.ReadLine());
                                    Console.Write("\nEste vértice é impar?\nResposta: " + grafo.Impar(v));
                                    Console.ReadKey();
                                    break;
                                case 15:
                                    Console.Clear();
                                    Console.Write("\nVERIFICANDO A EXISTÊNCIA DE UMA ARESTA\n");
                                    do
                                    {
                                        Console.Write("\nDigite o 1° vértice: ");
                                        v1 = int.Parse(Console.ReadLine());

                                        Console.Write("\nDigite o 2° vértice: ");
                                        v2 = int.Parse(Console.ReadLine());

                                        if (grafo.Adjacentes(v1, v2))
                                            Console.Write("\nAresta existente!");
                                        else
                                            Console.Write("\nAresta não existente!");
                                        Console.Write("\n\nDeseja buscar uma nova aresta? [1] Sim - [0] Não: ");
                                        continuar = int.Parse(Console.ReadLine());
                                    } while (continuar == 1);
                                    break;                              
                                case 0:
                                    goto menu;
                                    break;
                                default:
                                    Console.Write("\n\nOpção inválida!");
                                    break;
                            }

                        } while (opcao != 0);

                        Console.ReadKey();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            } while (opcao != 0);


        }

    }
}

