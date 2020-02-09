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

            double valoareDouble = 1.5;

            for (int i = 0; i < numereIntregi.Length; i++) {
                numereIntregi[i] = numereIntregi[i] + (int)valoareDouble;
            }

            for (int i = 0; i < numereIntregi.Length; i++)
            {
                Console.WriteLine("Vectorul dupa adunare: " + numereIntregi[i]);
            }

        }
    }
}
