using System;
using System.Collections.Generic;
using System.Text;

namespace Curs_3_C_Mentee
{
    class Exercitiu3
    /*Scrieti o clasa ce declara un array de tip int cu o singura valoare negativa 
     * si restul pozitive. Afisati pozitia valorii negative din array.
 */
    {
        static void Main(String[] args)
        {
            int[] array = new int[3];

            array[0] = 1;
            array[1] = -2;
            array[2] = 4;

            for (int i = 0; i < array.Length; i++) {
                if (array[i] < 0) {
                    Console.WriteLine("Valoara negativa se afla la pozitia: " + i);
                }
            }

           

        }
    }
}
