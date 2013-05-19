/*Write a program that prints an isosceles triangle of 9 copyright symbols ©. Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.
*/

using System;
using System.Text;

class CopyrightTriangle
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.UnicodeEncoding.Unicode;
        
        char copyrightChar = '\u00A9';
        char emptyChar = ' ';

        string copyright = Convert.ToString(copyrightChar);
        string empty = Convert.ToString(emptyChar);
        
        Console.WriteLine(empty + empty + copyright + empty + empty);
        Console.WriteLine(empty + copyright + copyright + copyright + empty);
        Console.WriteLine(copyright + copyright + copyright + copyright + copyright);
    }
}