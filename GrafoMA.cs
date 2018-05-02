using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoDeGrafos
{
    class GrafoMA
    {

        private Dictionary<int, List<int>> grafo;

        //Intancia um dictonary com um determinado número de vértices
        public GrafoMA(int vertices)
        {
            grafo = new Dictionary<int, List<int>>();
            for (int i = 0; i < vertices; i++)
                grafo.Add(i, new List<int>());
        }



        //Retorna a odem do grafo, ou seja, seu número de vértices
        public int Ordem()
        {
            return grafo.Count;
        }


        //Insere uma aresta no grafo
        public bool InsereAresta(int v1, int v2)
        {
            if (grafo.ContainsKey(v1) && grafo.ContainsKey(v2) && !grafo[v1].Contains(v2) && !grafo[v2].Contains(v1))
            {
                grafo[v1].Add(v2);
                grafo[v2].Add(v1);
                return true;
            }
            else
                return false;
        }

        //retira uma aresta já inserida no grafo
        public bool RetiraAresta(int v1, int v2)
        {
            if (grafo.ContainsKey(v1) && grafo.ContainsKey(v2) && grafo[v1].Contains(v2) && grafo[v2].Contains(v1))
            {
                grafo[v2].Remove(v1);
                grafo[v1].Remove(v2);
                return true;
            }
            else
                return false;
        }


        //Retorna o grau do vértice passado como parâmetro
        public int Grau(int v)
        {
            int grauVertice = 0;

            if (grafo.ContainsKey(v))
            {
                foreach (KeyValuePair<int, List<int>> i in grafo)
                    if (v == i.Key)
                        foreach (int a in (List<int>)i.Value)
                            grauVertice++;
                return grauVertice;
            }
            return -1;
        }

        //Retorna se o grafo é completo
        public bool Completo()
        {
            foreach (KeyValuePair<int, List<int>> i in grafo)
                if (Grau(i.Key) != (grafo.Count - 1))
                    return false;
            return true;
        }

        //Retorna se o grafo é Regular
        public bool Regular()
        {
            List<int> sequencia = new List<int>();
            foreach (KeyValuePair<int, List<int>> i in grafo)
                sequencia.Add(Grau(i.Key));

            int grau = sequencia[0];

            foreach (int i in sequencia)
                if (grau != i)
                    return false;

            return true;
        }

        //Passa os dados do dicionário para uma matriz e imprime a matriz de adjacência
        public void ShowMA(int[,] matrizAdjacencia)
        {
            foreach (KeyValuePair<int, List<int>> i in grafo)
            {
                foreach (int a in (List<int>)i.Value)
                    matrizAdjacencia[i.Key, a] = 1;
            }

            //imprimindo a matriz de adjacência
            Console.Write(" ");
            for (int i = 0; i < matrizAdjacencia.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(" " + i);
            }
            Console.WriteLine();

            for (int i = 0; i < matrizAdjacencia.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(i);
                for (int j = 0; j < matrizAdjacencia.GetLength(1); j++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" " + matrizAdjacencia[i, j]);
                }
                Console.WriteLine();
            }
        }

        //Mostra/imprime a lista de adjacência no console
        public void ShowLA()
        {
            foreach (KeyValuePair<int, List<int>> i in grafo)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\n" + i.Key + "\t");

                Console.ForegroundColor = ConsoleColor.White;
                foreach (int a in (List<int>)i.Value)
                {
                    
                    Console.Write(" " + a);
                }
            }
        }

        //Lista a sequência de graus do grafo
        public void SequenciaGraus()
        {
            List<int> sequencia = new List<int>();
            foreach (KeyValuePair<int, List<int>> i in grafo)
                sequencia.Add(Grau(i.Key));
            sequencia.Sort();

            foreach (int grau in sequencia)
                Console.Write(" " + grau);
        }

        //lista as arestas adjacentes à um determinado vértice
        public void VerticesAdjacentes(int v)
        {
            if (grafo.ContainsKey(v))
            {
                foreach (KeyValuePair<int, List<int>> i in grafo)
                    if (v == i.Key)
                    {
                        Console.Write("\n" + i.Key + "\t");
                        foreach (int a in (List<int>)i.Value)
                            Console.Write(" " + a);
                    }
            }
            else
                Console.Write("\nVértice não encontrado.");
        }


        //Verifica se existe vértices isolados no grafo
        public bool Isolado(int v)
        {
            if (Grau(v) == 0)
                return true;
            else
                return false;
        }

        //Verifica se o vértice passado como parâmetro é par, ou seja, possui um grau par
        public bool Par(int v)
        {
            if (Grau(v) % 2 == 0 && Grau(v) != 0)
                return true;
            else
                return false;
        }

        //Verifica se o vértice passado como parâmetro é impar, ou seja, possui um grau impar
        public bool Impar(int v)
        {
            if (Grau(v) % 2 == 0)
                return false;
            else
                return true;
        }

        //Verifica a existência de uma aresta no grafo
        public bool Adjacentes(int v1, int v2)
        {
            if (grafo.ContainsKey(v1) && grafo[v1].Contains(v2) || grafo.ContainsKey(v2) && grafo[v2].Contains(v1))
                return true;
            else
                return false;
        }
    }
}
