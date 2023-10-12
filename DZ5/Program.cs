using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первая матрица : ");
            int[,] args1 = new int[2, 2];
            Random random = new Random();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    args1[i, j] = random.Next(-100, 100);
                    Console.Write("{0}\t", args1[i, j]);

                }
                Console.WriteLine();
            }
            Console.WriteLine("Вторая матрица : ");
            int[,] args2 = new int[2, 2];
            for (int g = 0; g < 2; g++)
            {
                for (int h = 0; h < 2; h++)
                {
                    args2[g, h] = random.Next(-100, 100);
                    Console.Write("{0}\t", args2[g, h]);
                }
                Console.WriteLine();

            }

            int elem1 = (args1[0, 0] * args2[0, 0]) + (args1[0, 1] * args2[1, 0]);
            int elem2 = (args1[0, 0] * args2[0, 1]) + (args1[0, 1] * args2[1, 1]);
            int elem3 = (args1[1, 0] * args2[0, 0]) + (args1[1, 1] * args2[1, 0]);
            int elem4 = (args1[1, 0] * args2[0, 1]) + (args1[1, 1] * args2[1, 1]);
            Console.WriteLine("Результат умножения первой матрицы на вторую : ");
            int[,] args3 = new int[2, 2];
            