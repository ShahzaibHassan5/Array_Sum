using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Array Size :");
            int size = int.Parse(Console.ReadLine());
            int[] myArray = new int[size];
            Console.WriteLine("Enter Array Elements ");
            for(int i=0;i<myArray.Length;i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }
            int arraySum = 0;
            for(int i=0;i<myArray.Length;i++)
            {
                arraySum += myArray[i];
            }
            Console.WriteLine("Sum of Array is :" + arraySum);
            Console.ReadLine();

        }
    }
}
