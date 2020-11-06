using System;

namespace learnCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this test game!");
            Console.Write("Please enter a username: ");
            string username = Console.ReadLine();
            Player player = new Player(username);
            Console.Clear();
            int choice = MainMenu(player);
            switch(choice)
            {
                case 1:
                    Play();
                    break;
                case 2:
                    Shop();
                    break;
                case 3:
                    Exit();
                    break;
            }


            Console.ReadLine();
        }

        static int MainMenu(Player player)
        {
            Console.WriteLine("Hey " + player.name + "! Welcome to the test game!");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Please choose one of the following:");
            Console.WriteLine("(1) Play");
            Console.WriteLine("(2) Shop");
            Console.WriteLine("(3) Exit");
            Console.WriteLine("");
            int choice;
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            } catch (Exception err)
            {
                Console.WriteLine("You do realize that is invalid?\nError:"+err.Message);
                Console.Write("Just press enter and I'll kick you out...");
                Console.ReadLine();
                return 3;
            }
            if (choice > 0 && choice <= 3)
            {
                return choice;
            } else
            {
                Console.WriteLine("Ok...");
                Console.ReadLine();
                return 3;
            }
        }
        static void Play()
        {
            Console.WriteLine("Not made yet :)");
        }

        static void Shop()
        {
            Console.WriteLine("Not made yet :)");
        }

        static void Exit()
        {
            Console.WriteLine("Bye!");
            Console.ReadLine();
            System.Environment.Exit(1);
        }
    }
}
