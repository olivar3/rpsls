using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_proj
{
    class NewGame
    {
        string rulesAgree;
        string player1Choice;
        string player2Choice;
        
        private string rules()
        {
            string yes;
            string input;
            Console.WriteLine("The rules to the game are simple, scissor cuts paper, paper covers rock, rock crushes lizard, lizard poisons Spock, Spock smashes scissors, scissors decapitate lizard, lizard eats paper, paper disproves spock, and spock vaporizes rock. Do you understand?");
            input = Console.ReadLine();
            if (input == yes)
            {
                return rulesAgree;
            }
            else{
                Console.WriteLine("Read the rules again");
            }
        }
        public void player1()
        {
            Console.WriteLine("Enter your choice");
            player1Choice = Console.ReadLine();
        }
        public void player2()
        {
            Console.WriteLine("Rock, Paper, Sissors, Lizard, Spock");
            player2Choice = Console.ReadLine();
        }
        public void Winner(player1Choice, player2Choice)
        {

        }
    }
}
