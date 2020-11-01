using System;
using System.Reflection.Metadata.Ecma335;

namespace Lab8_Get_To_Know_Your_Classmates
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            string[] classmateName = { "Sam", "Kate", "Phoenix", "Zach", "Linda", "Garry", "Joshua", "Ben", "Katie", "Andrika", "Gregory", "Cheryl", "Paul", "Janelle", "Jennifer", "BJ", "John", "Laura", "Roger", "Jamie" };
            string[] hometown = { "Jackson, MI", "Bacon Level, AL", "Deadhorse, AK", "Nothing, AZ", "Greasy Corner, AR", "Forks of Salmon, CA", "Nowhere, CO", "Hazardville, CT", "Blue Ball, DE", "Fluffy Landing, FL", "Ty Ty, GA", "Volcano, HI", "Santa, ID", "Bone Gap, IL", "Young America, IN", "What Cheer, IA", "Nuetral, KS", "Hell for Certain, KY", "Book, LA", "Friendship, ME" };
            string[] favoriteFood = { "Rice Pudding", "Chorizo", "Gouda Holland", "Ravioli", "Gnocchi", "Durian", "Brie de Meaux", "Miso Soup", "Sarma", "Pizza Margherita", "Pizza Napoletana", "Satay", "Banchan", "Pavlova", "Eclair", "Grilled Cheese", "Kombu", "Nori", "Parfait", "Mooncake" };

            do
            {
                int student = StudentQuery();
                IdentifyAndDetailQuery(student, classmateName, hometown, favoriteFood);
                Console.Write("Would you like to know more? (enter \"yes\" or \"no\"):");
                string userDecision = Console.ReadLine();
                if (userDecision == "yes") Console.Clear();             
                else if (userDecision == "no") loop = false;
            } while (loop);

        }

        static int StudentQuery()
        {
            do
            {
                Console.Write("Welcome to our C# class. Which student would you like to learn more about? (enter a number 1-20) ");
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int studentNumber) && studentNumber > 0 && studentNumber < 21) return studentNumber;
                else
                {
                    Console.Clear();
                    Console.WriteLine("That student does not exist. Please try again.\n");
                }
            } while (true);
        }

        static void IdentifyAndDetailQuery(int student, string[] classmateName, string[] hometown, string[] favoriteFood)
        {
            bool loop = false;
            Console.Write($"Student {student} is {classmateName[student - 1]}. What would you like to know about him/her? (enter \"hometown\" or \"favorite food\") ");

            do
            {
                
                string userChoice = Console.ReadLine();
                           
                switch (userChoice)
                {
                    case "hometown":
                        {
                            Console.WriteLine($"{classmateName[student - 1]} is from {hometown[student - 1]}");
                            loop = false;
                            break;
                        }
                    case "favorite food":
                        {
                            Console.WriteLine($"{classmateName[student - 1]} enjoys eating {favoriteFood[student - 1]}");
                            loop = false;
                            break;
                        }
                    default:
                        {
                            Console.Write("That data does not exist. Please try again. (enter \"hometown\" or \"favorite food\") ");
                            loop = true;
                            break;
                        }
                }
            } while (loop);
        }
    }
}
