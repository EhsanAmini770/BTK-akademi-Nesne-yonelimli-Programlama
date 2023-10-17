using ConsoleApp1;
using System;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string playerName = Console.ReadLine();
            Player humanPlayer = new HumanPlayer { Name = playerName };
            ComputerPlayer computerPlayer = new RandomComputerPlayer { Name = "Computer" };

            RockPaperScissorsGame game = new RockPaperScissorsGame(humanPlayer, computerPlayer);
            game.PlayGame();
        }
    }
}

