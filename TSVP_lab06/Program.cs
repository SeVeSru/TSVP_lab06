using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSVP_lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int INF = int.MaxValue; // "Бесконечность"

            // Матрица смежности графа
            int[,] graph = {
            {0, 5, INF, 10},
            {INF, 0, 3, INF},
            {INF, INF, 0, 1},
            {INF, INF, INF, 0}
        };

            int n = graph.GetLength(0);

            // Инициализация матрицы кратчайших расстояний
            int[,] dist = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dist[i, j] = graph[i, j];
                }
            }

            // Алгоритм Флойда
            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (dist[i, k] != INF && dist[k, j] != INF && dist[i, k] + dist[k, j] < dist[i, j])
                        {
                            dist[i, j] = dist[i, k] + dist[k, j];
                        }
                    }
                }
            }

            // Вывод матрицы кратчайших расстояний
            Console.WriteLine("Матрица кратчайших расстояний:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (dist[i, j] == INF)
                    {
                        Console.Write("INF".PadLeft(5));
                    }
                    else
                    {
                        Console.Write(dist[i, j].ToString().PadLeft(5));
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
