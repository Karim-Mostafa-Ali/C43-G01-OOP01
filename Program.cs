using System.ComponentModel;

namespace ConsoleApp1
{
    internal class Program
    {
        enum WeekDays { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
        enum Season { Spring, Summer, Autumn, Winter }

        enum Colors { Red, Green, Blue }

        [Flags]
        enum Permissions
        {
            Read = 1,
            Write = 2,
            Delete = 4,
            Execute = 8
        }

        
        static void Main(string[] args)
        {
            #region 1-Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this Enum.

            //Console.WriteLine("Days of the Week:");
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region 2-Create an Enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Console.Write("Enter a season (Spring, Summer, Autumn, Winter): ");
            //string? inputSeason = Console.ReadLine();

            //if (Enum.TryParse(inputSeason, true, out Season season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season!");
            //}

            #endregion

            #region   3-Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum           .
            //Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission existed inside variable

            //Permissions userPermissions = (Permissions) 3;// Read ,write
            //Console.WriteLine(userPermissions); 

            //userPermissions |= Permissions.Delete; // Add Delete Permission
            //Console.WriteLine($"Permissions after adding Delete: {userPermissions}");

            //userPermissions &= ~(Permissions.Write); // Remove Write Permission
            //Console.WriteLine($"Permissions after removing write: {userPermissions}");

            ////// Check if Write Permission exists
            //bool hasDelete = (userPermissions & Permissions.Delete) == Permissions.Delete;
            //Console.WriteLine($"Has Delete Permission: {hasDelete}");

            #endregion

            #region 4.Create an Enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //Console.Write("Enter a color name: ");
            
            //bool isParsed = Enum.TryParse(Console.ReadLine(),true, out Colors Colors);

            //if (isParsed == true)
            //{
            //    Console.WriteLine("The color is a primary color.");
            //}
            //else
            //{
            //    Console.WriteLine("The color is not a primary color.");
            //}

            #endregion


        }
    }
}
