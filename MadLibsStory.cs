using System;

namespace MadLibsStory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Init Variables
            string theMatrix, system, neo, enemy, inside, save, unplugged, fight;
            string[] profession= new string[4], adj = new string[2];
            //Get inputs from user
            //Getting neo variable from user
            Console.WriteLine("Welcome user!");
            Console.WriteLine("Lets play a game of madLibs");
            Console.WriteLine("Please share with me your name?\n");
            neo = Console.ReadLine();
            //Getting Matrix variable from user
            Console.WriteLine($"Hello {neo} are you ready?\nWhat is something you want to know more about?\n");
            theMatrix = Console.ReadLine();
            //Getting system variable from user
            Console.WriteLine($"Oooh! You want to learn more about {theMatrix} huh?");
            Console.WriteLine($"Okay well first, tell me what you already know about {theMatrix} in one word (noun)\n");
            system = Console.ReadLine();
            //Getting enemy variable from user
            Console.WriteLine($"Okay give me a opposing noun to {system}");
            enemy = Console.ReadLine();
            //Getting inside variable from user
            Console.WriteLine($"Now give me any relaxing noun (present tense)");
            inside = Console.ReadLine();
            Console.WriteLine($"Okay, now I need four professions pertaining to {system}");
            ////Getting professions array from user
            for (int i = 0; i <profession.Length; i++)
            {
                                             //number they are on    // out of total
                Console.WriteLine($"Profession (plural) {i + 1} / {profession.Length}");
                profession[i] = Console.ReadLine();
            }
            // Getting the save variable
            Console.WriteLine($"Give me a hero-related verb (present tense):");
            save = Console.ReadLine();

            // Getting the unplugged variable
            Console.WriteLine($"Now give me a verb that makes you think about relief (past tense):");
            unplugged = Console.ReadLine();

            // Getting the adjectives
            Console.WriteLine($"Lastly I need 2 dystopian adjectives");

            for (int i = 0; i < adj.Length; i++)
            {
                                  //number they are on  // out of total
                Console.WriteLine($"Adjective {i + 1} / {adj.Length}:");
                adj[i] = Console.ReadLine();
            }

            // Getting the fight variable
            Console.WriteLine($"& a verb:");
            fight = Console.ReadLine();

            //Init story
            string madLibStory =
            $"{theMatrix} is a {system}, {neo}.\n"+
            $"That {system} is our {enemy}.\n"+
            $"But when you're {inside}, you look around, what do you see?\n"+
            $"{profession[0]}, {profession[1]}, {profession[2]}, {profession[3]}.\n"+
            $"The very minds of the people we are trying to {save}.\n"+
            $"But until we do, these people are still a part of that {system} and that makes them our {enemy}.\n"+
            $"You have to understand, most of these people are not ready to be {unplugged}.\n"+
            $"And many of them are so {adj[0]}, so hopelessly {adj[1]} on the {system}, that they will {fight} to protect it.\n";
            //Print Story
            Console.WriteLine(madLibStory);
            Console.ReadLine();
        }
    }
}
