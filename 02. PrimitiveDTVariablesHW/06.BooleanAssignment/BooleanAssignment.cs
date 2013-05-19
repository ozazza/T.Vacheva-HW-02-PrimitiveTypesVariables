/*Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.

 */

using System;

class BooleanAssignment
{
    static void Main()
    {
        bool isFemale;

        Console.WriteLine("Are you a female or a male:");
        string isGender = Console.ReadLine();
        
        if (isGender == "female")
        {
            isFemale = true;
            Console.WriteLine("You are a female: " + isFemale);
        }
        else
        {
            isFemale = false;
            Console.WriteLine("You are a female: " + isFemale + ", clearly!");
        }
    }
}