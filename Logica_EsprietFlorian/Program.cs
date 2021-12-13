using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_EsprietFlorian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Left = new int[] { 1, 3, 2, 6, 9 };
            int[] Right = new int[] { 0, 0, 0, 0, 0 };

            ////Left Array
            //for (int i = 0; i < Left.Length; i++)
            //{
            //    Console.Write(Left[i] + " ");
            //}
            //Console.WriteLine();
            ////Right Array
            //for (int i = 0; i < Right.Length; i++)
            //{
            //    Console.Write(Right[i] + " ");
            //}
            //Console.WriteLine();
            ////************* Left array value in Right array***********//
            //Array.Copy(Left, Right, Left.Length);
            //for (int i = 0; i < Right.Length; i++)
            //{
            //    Console.Write(Right[i] + " ");
            //}
            //Console.WriteLine();
            ////*************** Right array value in Left array**************//
            //Array.Clear(Right, 0, Left.Length);
            //Array.Copy(Right, Left, Left.Length);
            //for (int i = 0; i < Left.Length; i++)
            //{
            //    Console.Write(Left[i] + " ");
            //}   
           //Left Array
            for (int i = 0; i < Left.Length; i++)
            {
                Console.Write(Left[i] + " ");
            }
            Console.WriteLine();
            //Right Array
            for (int i = 0; i < Right.Length; i++)
            {
                Console.Write(Right[i] + " ");
            }
            Console.WriteLine();
            //Left Array => Right Array
            Console.WriteLine();
            for (int i = 0; i < Left.Length; i++)
            {
                Left[i] = Right[i];
                Console.Write(Left[i]+ " ");
            }
            Left = new int[] { 1, 3, 2, 6, 9 };
            Console.WriteLine();      
            for (int i = 0; i < Right.Length; i++)
            {
                Right[i] = Left[i];
                Console.Write(Right[i] + " ");
            }
            
        }
    }
}
