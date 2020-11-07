using System;
using System.Threading;
using System.Threading.Tasks;

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
            Game(player);
        }

        static void Game(Player player)
        {
            int choice = MainMenu(player);
            switch (choice)
            {
                case 1:
                    Play(player);
                    break;
                case 2:
                    Shop(player);
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
        static void Play(Player player)
        {
            Console.Clear();

            string[] enemiesBelowLvThree = { "Orch", "Goblin", "Slime" };
            string[] enemiesAboveLvThree = { "Giant", "Dragon", "Demon" };

            string enemyName;
            int enemyLevel = player.level;
            int enemyATK;
            int enemyDEF;
            int enemyHP;
            int enemyReward;
            Random rnd = new Random();
            if (player.level < 3)
            {
                int x = rnd.Next(enemiesBelowLvThree.Length);
                int y = rnd.Next(enemyLevel * 10);
                int z = rnd.Next(enemyLevel * 10);
                int hp = rnd.Next(enemyLevel * 100);
                int reward = rnd.Next(20, 150);
                enemyName = enemiesBelowLvThree[x];
                enemyATK = y;
                enemyDEF = z;
                enemyHP = hp;
                enemyReward = reward;
            } else
            {
                int x = rnd.Next(enemiesAboveLvThree.Length);
                int y = rnd.Next(enemyLevel * 15);
                int z = rnd.Next(enemyLevel * 15);
                int hp = rnd.Next(enemyLevel * 100);
                int reward = rnd.Next(150, 500);
                enemyName = enemiesAboveLvThree[x];
                enemyATK = y;
                enemyDEF = z;
                enemyHP = hp;
                enemyReward = reward;
            }

            Enemy enemy = new Enemy(enemyName, enemyLevel, enemyATK, enemyDEF, enemyHP, enemyHP, enemyReward);

            Console.WriteLine("You've spotted a wild " + enemy.name + "!");
            Console.WriteLine("Quick! Defeat it for rewards!");
            Console.ReadLine();
            bool won = Fight(player, enemy);
            if (won == true)
            {
                Console.WriteLine("Congrats! You beat the " + enemy.name + "!");
                player.money += enemy.moneyReward;
            } else
            {
                Console.WriteLine("You died...");
                player.hp = player.maxHP;
                if (player.money >= 10)
                {
                    player.money = player.money / 2;
                }
            }
            Task.Delay(2500).Wait();
            Game(player);
        }

        static void Shop(Player player)
        {
            Console.WriteLine("Not made yet :)");
        }

        static void Exit()
        {
            Console.WriteLine("Bye!");
            Console.ReadLine();
            System.Environment.Exit(1);
        }

        static bool Fight(Player player, Enemy enemy)
        {
            if (enemy.hp <= 0)
            {
                return true;
            }
            else if (player.hp <= 0)
            {
                return false;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Monster: " + enemy.name);
                Console.WriteLine("");
                Console.WriteLine("HP: " + enemy.hp + " / " + enemy.maxHP);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Player: " + player.name);
                Console.WriteLine("");
                Console.WriteLine("HP: " + player.hp + " / " + player.maxHP);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("(1) Attack");
                Console.WriteLine("(2) Heal");
                Console.WriteLine("(3) Forfeit");
                Console.Write("What will you do? ");

                int choice = FightChoice();
                Console.Clear();
                if (choice == 1)
                {
                    Attack(player, enemy);
                }
                else if (choice == 2)
                {
                    Heal(player);
                }
                else if (choice == 3)
                {
                    Forfeit();
                }

                return Fight(player, enemy);
            }
        }

        static int FightChoice()
        {
            

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice <= 3 && choice >= 1)
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("That wasn't even an option bruh...");
                    Console.Write("Try again... ");
                    return FightChoice();
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("This is invalid mate.\nYou even caused an error; " + err.Message);
                Console.Write("Try again... ");
                return FightChoice();
            }
        }

        static void Attack(Player player, Enemy enemy)
        {
            Console.Clear();
            Console.WriteLine("You attack the " + enemy.name + "...");
            Random rnd = new Random();

            int playerDeals = rnd.Next((player.atk * 3) / 2) - (enemy.def / 5);
            int enemyDeals = rnd.Next((enemy.atk * 4) / 3) - (player.def / 5);

            Task.Delay(2500).Wait();
            Console.WriteLine("You deal " + playerDeals + " towards the " + enemy.name);
            enemy.hp -= playerDeals;
            if (enemy.hp > 0)
            {
                Task.Delay(2500).Wait();
                Console.WriteLine("The " + enemy.name + " deals " + enemyDeals + " towards you");
                player.hp -= enemyDeals;
            }
            Task.Delay(2500).Wait();
        }

        static void Heal(Player player)
        {

        }
        
        static void Forfeit()
        {

        }
    }
}
