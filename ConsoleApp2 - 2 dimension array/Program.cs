using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2___2_dimension_array
{
    internal class Program
    {
        static void Main(string[] args)
        {Console.WriteLine("Enter the number of rows and columns of the array");
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            int[ ,] array = new int[rows,columns];
            Console.WriteLine("Enter the elements of the array");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i , j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The elements of the array are");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i , j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine(); 
        }
    }
}
