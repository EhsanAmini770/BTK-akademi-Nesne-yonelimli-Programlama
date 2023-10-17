using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Player
    {
        public string Name { get; set; }
        public string Move { get; set; }

        public abstract void MakeMove();
    }

    public abstract class ComputerPlayer : Player
    {
        public abstract void MakeRandomMove();
    }
    public class HumanPlayer : Player
    {
        public override void MakeMove()
        {
            Console.Write($"{Name}, enter your move (rock, paper, or scissors): ");
            Move = Console.ReadLine().ToLower();
        }
    }

    public class RandomComputerPlayer : ComputerPlayer
    {
        private readonly Random random = new Random();

        public override void MakeMove()
        {
            string[] moves = { "rock", "paper", "scissors" };
            int randomIndex = random.Next(moves.Length);
            Move = moves[randomIndex];
        }

        public override void MakeRandomMove()
        {
            string[] moves = { "rock", "paper", "scissors" };
            int randomIndex = random.Next(moves.Length);
            Move = moves[randomIndex];
        }
    }

}
