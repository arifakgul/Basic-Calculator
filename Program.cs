using System;
using System.Formats.Asn1;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
           Random random = new Random();
           bool PlayAgain = true;
           string player;
           string computer;
           string answer;

           while(PlayAgain)
           {
                player = "";
                computer = "";
                answer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Enter ROCK, PAPER or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine($"Player = {player}");
                Console.WriteLine($"Computer = {computer}");

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("Sory You Lose!");
                        }
                        else
                        {
                            Console.WriteLine("You Win");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You Win");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw");
                        }
                        else
                        {
                            Console.WriteLine("You Lose!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You Lose!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You Win");
                        }
                        else
                        {
                            Console.WriteLine("It's a draw");
                        }
                        break;
                }
                Console.WriteLine("Do you want to exit ? (Y/N):");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    PlayAgain = false;
                }
                else
                {
                    PlayAgain = true;
                }    
           }
           Console.WriteLine("See you later goodbye");    
        }
    }
}
    