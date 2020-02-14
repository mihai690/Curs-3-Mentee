using System;
using System.Collections.Generic;
using System.Text;

namespace Curs_3_C_Mentee
{
    class Exercitiu5
    /*Transformati un sir de caractere astfel: fiecare litera de pe pozitie para sa fie uppercase.
*/
    {
        static void Main(String[] args)
        {

            String s1 = "hello world";
            char[] charArray = s1.ToCharArray();
            for (int i = 0; i < charArray.Length; i++) {

                if (i % 2 == 0)
                {

                    charArray[i] = char.ToUpper(charArray[i]);
                        }
            }
            Console.WriteLine(charArray);
                        
                            
        }
    }
}
