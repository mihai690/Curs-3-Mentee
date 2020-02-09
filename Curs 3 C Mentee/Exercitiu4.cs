using System;
using System.Collections.Generic;
using System.Text;

namespace Curs_3_C_Mentee
{
    class Exercitiu4
    /*Scrieti o clasa ce transforma un String intr-un array de caractere.
 */
    {
        static void Main(String[] args)
        {

            String s1 = "Acesta este un string";
            char[] charArray = s1.ToCharArray();

            Console.WriteLine("String: " + s1);
            Console.WriteLine("CharArray: " + charArray);

            for (int i = 0; i < charArray.Length; i++)
                Console.WriteLine(" " + charArray[i]);

        }
    }
}
