using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[4,4]
            {
                { 0,5,0,0 },
                { 0,1,7,0,},
                { 0,3,9,0 },
                { 0,0,0,0 }
            };



            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    SearchForEdges(array, i, j);

                }

            }

           


            Console.ReadLine();
        }



        private static void SearchForEdges(int[,] array, int x, int y)
        {

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {

                    if((x + i) >= 0 && (x + i) <= (array.GetLength(0) - 1) && 
                        (y + j) >= 0 && (y + j) <= (array.GetLength(1) - 1))
                    {
                        Console.Write(array[x + i, y + j]);
                    }

                }

            }

            Console.WriteLine();

        }


    }
}
