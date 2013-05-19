/*Declare two string variables and assign them with following value:

 * The "use" of quotations causes difficulties.

	Do the above in two different ways: with and without using quoted strings.
*/

using System;

class UseOfQuotations
{
    static void Main()
    {
        string quote = "\"";
        string quotedString = "The" + " " + quote + "use"+ quote + " " + "of quotations causes difficulties.\n";
        
        string useQuotesFirst = "The \"use\" of quotations causes difficulties.\n";
        string useQuotesSecond = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(quotedString + useQuotesFirst + useQuotesSecond);
    }
}