using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_proj
{
    public class Player
    {
            public int roundScore;
            public string name;
            public int number;
        public Player()
        {

        }
        public void IncrementScore()
        {
            roundScore++;
        }
        public virtual void getChoice()
        {
            Console.WriteLine("Enter your choice. Rock = 1, paper = 2, scissors = 3, lizard = 4, and Spock = 5");
            number = int.Parse(Console.ReadLine());
            if (number > 5)
            {
                Console.WriteLine("Too high. Please choose a number between 1 and 5");
                getChoice();
            }
        }
    }
}
