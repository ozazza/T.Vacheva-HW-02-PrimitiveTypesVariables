/*Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console.
*/

using System;

class ASCIICharacters
{
    static void Main()
    {
        for (int i = 0; i < 256; i++)
        {
            char code = (char)i;
            Console.WriteLine(code);
        }
    }
}