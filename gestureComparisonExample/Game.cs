using System;
using System.Collections.Generic;
using System.Text;

namespace gestureComparisonExample
{
    class Game
    {
        Player playerOne;
        Player playerTwo;

        public Game()
        {
            playerOne = new Player() { name = "Ahnikka", score = 0, gesture = "scissors" };
            playerTwo = new Player() { name = "David", score = 0, gesture = "paper" };
        }

        public void RunGame()
        {
            playerTwo = CompareGestureOption2(playerTwo, playerOne);
            playerOne = CompareGestureOption2(playerOne, playerTwo);

            Console.WriteLine($"Player One Score: {playerOne.score}\nPlayer Two Score: {playerTwo.score}");
        }
        public Player CompareGestureOption2(Player playerOne, Player playerTwo)
        {
            if (playerOne.gesture == "scissors" && (playerTwo.gesture == "paper" || playerTwo.gesture == "lizard"))
            {
                Console.WriteLine($"{playerOne.name} has won the round! Scissors cuts paper!");
                playerOne.score++;
            }
            return playerOne;
        }
    }
}
