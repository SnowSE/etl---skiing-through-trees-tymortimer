using System;

namespace Skiing_Amongst_Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            int hits = 0;
            int slopeX;
            int slopeY;
            int positionX = 0;
            int positionY = 0;
            string fileName;


            Console.WriteLine("Your job is to skii through the trees!\n Please enter the slope that you will skii down the trees with!");
            Console.WriteLine("Enter the x slope amount");
            slopeX = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the y slope amount");
            slopeY = Int32.Parse(Console.ReadLine());

            //read in map
            fileName = "TreeMap.txt";
            string[] map = System.IO.File.ReadAllLines(fileName);

            //travel until the bottom
            while (positionY + slopeY < map.Length)
            {
                Travel();
            }

            Console.WriteLine("You had " + hits + " hits!");

            //travel method, iterates through the array, and the goes to the position in the string
            void Travel()
            {
                positionY = positionY + slopeY;
                positionX = positionX + slopeX;
                AddStrings();
                if (map[positionY].Substring(positionX, 1) == "#")
                {
                    hits++;
                }
            }

            //adds repeating trees until the a correct length can be handled
            void AddStrings()
            {
                if (positionX > map[positionY].Length)
                {
                    map[positionY] += map[positionY];
                    AddStrings();
                }
            }

        }
    }
}
