/*Create a program that assigns null values to an integer and to double variables. Try to print them on the console, try to add some values or the null literal to them and see the result.
*/

using System;

class NullableIntAndDouble
{
    static void Main()
    {
        int? intNull = null;
        double? doubleNull = null;
        
        int intAddFirst = 2;

        Console.WriteLine(">" + intNull + "<" + intAddFirst);

        int intAddResult = ((int)intNull) + 10; //Gives Exception
    }
}