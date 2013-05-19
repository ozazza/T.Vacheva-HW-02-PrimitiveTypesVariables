/*
 Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
 */

using System;

class FloatDouble
{
    static void Main()
    {
        float floatFirst = 12.345f;
        float floatSecond = 3456.091f;

        double doubleThird = 34.56789023d;
        double doubleForth = 8923.1235857d;

        Console.WriteLine("{0} float; {1} float; {2} double; {3} double.", floatFirst, floatSecond, doubleThird, doubleForth);
    }
}