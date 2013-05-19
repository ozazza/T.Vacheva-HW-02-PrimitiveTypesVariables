/*Declare a character variable and assign it with the symbol that has Unicode code 72. Hint: first use the Windows Calculator to find the hexadecimal representation of 72.
*/

using System;

class CharUnicodeSymbol
{
    static void Main()
    {
        char charUnicodeSymbol = '\u0048';
        //char charUnicodeSymbol = (char)0x48;
        
        Console.WriteLine(charUnicodeSymbol);
    }
}