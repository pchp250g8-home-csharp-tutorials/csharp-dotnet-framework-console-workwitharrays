using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Input a count of elements in array");
            Int64.TryParse(Console.ReadLine(), out var nElems);
            var iArray = new int[nElems];
            for (int i = 0; i < nElems; i++)
            {
                Console.WriteLine("Input an element N {0}", i + 1);
                int.TryParse(Console.ReadLine(), out iArray[i]);
            }
            Console.WriteLine("Inputed array:");
            for (int i = 0; i < nElems; i++)
            {
                Console.Write(iArray[i] + " ");
            }
            Console.Read();
        }
    }
}