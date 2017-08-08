using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_proj
{
    public class NewGame
    {
        Rules rules;
        Player playerOne;
        Player playerTwo;
        public NewGame()
        {
            rules = new Rules();
        }
        public void getNumberOfPlayers()
        {
            Console.WriteLine("How many players, 1 or 2?");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            if (numberOfPlayers == 1)
            {
                playerOne = new Human();
                playerTwo = new Cpu();
                playerOne.name = getPlayerName();
                playerTwo.name = getPlayerName();
            }
            else if (numberOfPlayers == 2)
            {
                playerOne = new Human();
                playerTwo = new Human();
                playerOne.name = getPlayerName();
                playerTwo.name = getPlayerName();
            }
            else
            {
                Console.WriteLine("Please choose 1 or 2");
                getNumberOfPlayers();
            }
        }
        public string getPlayerName()
        {
            Console.WriteLine("Enter player name.");
            string name = Console.ReadLine();
            return name;
        }
        public void compareChoices()
        {
            playerOne.getChoice();
            playerTwo.getChoice();

            int d = (5 + playerOne.number - playerTwo.number) % 5;
            if (playerOne.number > playerTwo.number)
            {
                Console.WriteLine($"{playerOne.name} is the winner this time");
                playerOne.IncrementScore();
            }
            else if (playerOne.number < playerTwo.number)
            {
                Console.WriteLine($"{playerTwo.name} is the winner this time");
                playerTwo.IncrementScore();
            }
            else
            {
                Console.WriteLine("Scores are tied");
                compareChoices();
            }

        }
        public void deterimineWinner()
        {
            if (playerOne.roundScore >= 3 && playerTwo.roundScore <= 2)
            {
                Console.WriteLine($"{playerOne.name} wins the game!");
            }
            else if (playerOne.roundScore >= 2 && playerTwo.roundScore <= 1)
            {
                Console.WriteLine($"{playerOne.name} wins the game!");

            }
            else if (playerTwo.roundScore >= 3 && playerOne.roundScore <= 2)
            {
                Console.WriteLine($"{playerTwo.name} wins the game!");
            }
            else if (playerTwo.roundScore >= 2 && playerTwo.roundScore <= 1)
            {
                Console.WriteLine($"{playerTwo.name} wins the game!");
            }
        }
        public void runGame()
        {
            rules.DisplayRules();
            getNumberOfPlayers();
            while (playerOne.roundScore <= 3 && playerTwo.roundScore <= 3)
            {
                compareChoices();
                deterimineWinner();
            }
            askPlayAgain();
        }
        public void askPlayAgain()
        {
            Console.WriteLine("Play again? yes or no");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "yes")
            {
                runGame();
            }
            else
            {
                Console.WriteLine("Thanks for playing!");
                Environment.Exit(0);
            }
        }
    }
}