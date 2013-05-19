/*Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.
*/

using System;

class IntegerAssignAndExchange
{
    static void Main()
    {
        int numOne = 5;
        int numTwo = 10;

        Console.WriteLine("First Number = {0}; Second Number = {1};", numOne, numTwo);

        int numTree = numOne;
        numOne = numTwo;
        numTwo = numTree;

        Console.WriteLine("First Number = {0}; Second Number = {1};", numOne, numTwo);
    }
}