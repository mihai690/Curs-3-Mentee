using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Curs_3_C_Mentee
{
    class Exercitiu2
    /*Scrieti un program care afiseaza minimul, 
     * respectiv maximul dintr-un array de lungime 10.
     */
    {
        static void Main(String[] args)
        {
            int[] array = new int[10] {2,4,5,6,15,8,9,10,11,12};
           
            Console.WriteLine("Maximul din array este: " + array.Max());
            Console.WriteLine("Minimul din array este: " + array.Min());

        }
    }
}
