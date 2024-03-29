﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraAlgorithm
{

    class ArrayObject
    {
        public int x { get; set; }
        public int y { get; set; }
        public int value { get; set; }
    }




    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[4,4]
            {
                { 0,5,0,0 },
                { 0,2,7,0,},
                { 0,3,9,0 },
                { 0,0,4,1 }
            };


            int currentx = 0, currenty = 0;
            while(currentx != 4 && currenty != 4)
            {
                var edges = SearchForEdges(array, currentx, currenty);
                var lowestValue = edges.OrderBy(x => x.value).First();

                currentx = lowestValue.x;
                currenty = lowestValue.y;
            }

            





            Console.ReadLine();
        }



        private static ArrayObject[] SearchForEdges(int[,] array, int x, int y)
        {

            var holder = new List<ArrayObject>();

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {

                    if( ((i != 0) && (j != 0)) &&
                        (x + i) >= 0 && (x + i) <= (array.GetLength(0) - 1) && 
                        (y + j) >= 0 && (y + j) <= (array.GetLength(1) - 1) &&                  
                        array[x + i, y + j] != 0)
                    {


                        

                        Console.Write(array[x + i, y + j]);
                        holder.Add(new ArrayObject() { x = (x + i), y = (y + j), value = array[x + i, y + j] });
                    }

                }

            }


            Console.WriteLine();
            return holder.ToArray();
        }


    }
}
