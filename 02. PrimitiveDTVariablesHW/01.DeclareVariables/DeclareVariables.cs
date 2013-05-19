/*Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
*/

using System;

class DeclareVariables
{
    static void Main()
    {
        byte byteA = 97;
        sbyte sbyteB = -115;
        short shortC = -10000;
        ushort ushortD = 52130;
        int intE = 4825932;

        Console.WriteLine("{0} byte; \n{1} sbyte; \n{2} short; \n{3} ushort; \n{4} int.", byteA, sbyteB, shortC, ushortD, intE);
    }
}
