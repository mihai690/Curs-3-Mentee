using System;
using System.Collections.Generic;
using System.Text;

namespace Curs_3_C_Mentee
{
    class Exercitiu6
    /*Avand un vector de numere intregi, 
     *adunati un nr double la valorile stocate si pastrati rezultatul in alt vector corespunzator.
*/
    {
        static void Main(String[] args)
        {
            int[] numereIntregi = new int[3] { 2, 4, 6 };
            for (int i = 0; i < numereIntregi.Length; i++) {
                Console.WriteLine("Vectorul initial: " + numereIntregi[i]);
            }

            double[] numereDouble = new Double[3];

            numereDouble[1] = 2.5;

            for (int i = 0; i < numereDouble.Length; i++) {
                Console.WriteLine("Vectorul double: " + numereDouble[i]);
            }

            for (int i = 0; i < numereIntregi.Length && i < numereDouble.Length; i++)
            {
                numereDouble[i] = numereDouble[i] + numereIntregi[i];

                Console.WriteLine("Vectorul dupa adunare: " + numereDouble[i]);
            }

        }
    }
}
