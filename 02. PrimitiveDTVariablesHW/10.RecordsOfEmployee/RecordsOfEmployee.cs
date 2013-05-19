/*A marketing firm wants to keep record of its employees. Each record would have the following characteristics – first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.
*/

using System;

class RecordsOfEmployee
{
    static void Main()
    {
        Console.WriteLine("Enter First Name: ");
        string firstName = Console.ReadLine();
        
        Console.WriteLine("Enter Family Name: ");
        string familyName = Console.ReadLine();

        Console.WriteLine("Age: ");
        byte age = Convert.ToByte(Console.ReadLine());

        Console.WriteLine("Gender: ");
        string gender = Console.ReadLine();

        Console.WriteLine("ID Number: ");
        int numID = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Unique Number: ");
        int numUnique = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n\n\n<<< Employee's Record >>>\n");
        Console.WriteLine("First Name: {0} \nSecond Name: {1} \nAge: {2} \nGender: {3} \nID Number: {4} \nUnique Number: {5} \n", firstName, familyName, age, gender, numID, numUnique);
    }
}