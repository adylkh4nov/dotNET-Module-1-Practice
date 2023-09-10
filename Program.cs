using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_Module_2_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 ob = new Class1();
            int[] arr = new int[6] { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = new int[6] { 3, 4, 5, 6, 7, 8 };
            /*foreach (int num in ob.example18(6,18))
            {
                Console.WriteLine(num);
            }*/

            foreach (var item in ob.example20(ref arr,ref arr2))
            {
                Console.WriteLine(item);
            }
        }
    }
}
