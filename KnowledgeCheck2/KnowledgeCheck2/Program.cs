using System;

namespace KnowledgeCheck2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Video Games do you want to add? ");
            var numberOfGames = int.Parse(Console.ReadLine());

            var gamesList = new List<VideoGames>();
            for (int i = 0; i < numberOfGames; i++)
            {

                var myClass = new MicrosoftGames();
                

                   

                Console.WriteLine("What game are we adding to our list?");
                myClass.Title = Console.ReadLine();
                Console.WriteLine("Enter the Rating for this game?");
                myClass.Rating = Console.ReadLine();
                Console.WriteLine("Is this an Xbox game or a PC Game?");
                myClass.Console = Console.ReadLine();
                if (myClass.Console.ToLower() == "xbox")
                {
                    Console.WriteLine("Is this game on Xbox Game Pass? Y/N");
                    myClass.GamePass = Console.ReadLine();
                }




                gamesList.Add(myClass);
            }

            // Print out the list of games using Console.WriteLine()
            foreach(var game in gamesList) 
            {
                Console.WriteLine(game);
            }
        }
    }
}