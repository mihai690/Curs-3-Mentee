using System;

namespace Curs_3_C_Mentee
{
    class Exercitiu1
        /*Scrieti un program care stocheaza intr-un vector 3 variabile de tip double declarate 
         * de voi si le afiseaza parcurgand vectorul.
         */
    {
        static void Main(String[] args)
        {
            double[] vector = new double[3];
            vector[0] = 2.5;
            vector[1] = 4.5;
            vector[2] = 6.5;

            for (int i = 0; i < vector.Length; i++)
                Console.WriteLine("Element at index " + i + " : " + vector[i]);

        }
    }
}
