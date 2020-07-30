using System;
using System.Collections.Generic;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            List<string> names = new List<string> { "Andoni", "Simon", "Josh", "Sumana" };
            List<string> favoriteColor = new List<string> { "green", "blue", "red", "yellow" };
            List<string> favoriteFood = new List<string> { "Rainbow Trout", "Caprese Salad", "Fois Grais", "Detroit Style Pizza" };
            List<string> favoriteFilm = new List<string> { "No Country For Old Men", "There Will Be Blood", "Hot Fuzz", "Mean Girls" };
            while (a == true)
            {
                Console.WriteLine("Hello, What student would you like to Learn about?");
                DisplayStudents(names);
                try
                {
                    int student = int.Parse(Console.ReadLine()) - 1;
                    if (student >= 3 && student >= 0)
                    {

                    }
                    Console.WriteLine($"You have chosen: {names[student]}, would you like to know the student's favorite color? If yes, give me a 'y'");
                    string response = Console.ReadLine();
                    if (response == "y")
                    {
                        Console.WriteLine($"Their favorite color is {favoriteColor[student]}");
                        Console.WriteLine();
                    }
                    Console.WriteLine($"Would you like to know {names[student]}'s favorite food? If yes, give me a 'y'");
                    string responseFood = Console.ReadLine();
                    if (response == "y")
                    {
                        Console.WriteLine($"Their favorite food is {favoriteFood[student]}");
                        Console.WriteLine();

                    }
                    Console.WriteLine($"Would you like to know {names[student]}'s favorite film? If yes, give me a 'y'");
                    string responseFilm = Console.ReadLine();
                    if (response == "y")

                    {
                        Console.WriteLine($"Their favorite film is {favoriteFilm[student]} great choice!");
                        Console.WriteLine();

                    }
                    Console.WriteLine("Would you like to keep going? y/n");
                    Console.WriteLine();
                    string responseLast = Console.ReadLine();
                    if (responseLast == "y")
                    {
                        a = true;
                    }
                    else if (responseLast == "n" || responseLast == "no")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Alright. Thanks for your time, bye!");
                        a = false;
                    }
                    else
                    {
                        Console.WriteLine("Seriously? y/n?");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("That input was not a correct number");
                    Console.WriteLine("Press any key to try again");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        public static void DisplayStudents(List<string> names)
        {

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"{i + 1}){names[i]}");
            }
        }





    }
}


