using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RockPaperScissorsGame
    {
        private Player player;
        private ComputerPlayer computer;
        private int playerScore;
        private int computerScore;

        public RockPaperScissorsGame(Player player, ComputerPlayer computer)
        {
            this.player = player;
            this.computer = computer;
            playerScore = 0;
            computerScore = 0;
        }

        public void PlayRound()
        {
            player.MakeMove();
            computer.MakeRandomMove();

            Console.WriteLine($"{player.Name} chose {player.Move}");
            Console.WriteLine($"Computer chose {computer.Move}");

            if (player.Move == computer.Move)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((player.Move == "rock" && computer.Move == "scissors") ||
                     (player.Move == "scissors" && computer.Move == "paper") ||
                     (player.Move == "paper" && computer.Move == "rock"))
            {
                Console.WriteLine($"{player.Name} wins this round!");
                playerScore++;
            }
            else
            {
                Console.WriteLine("Computer wins this round!");
                computerScore++;
            }

            Console.WriteLine($"{player.Name}: {playerScore}  Computer: {computerScore}");
        }

        public void PlayGame()
        {
            Console.WriteLine("Welcome to Rock-Paper-Scissors Game!");

            do
            {
                PlayRound();

                Console.Write("Do you want to play another round? (yes/no): ");
                string playAgain = Console.ReadLine().ToLower();

                if (playAgain != "yes")
                {
                    Console.WriteLine("Thanks for playing!");
                    Console.WriteLine($"{player.Name}: {playerScore}  Computer: {computerScore}");
                    break;
                }
            } while (true);
        }
    }
}
