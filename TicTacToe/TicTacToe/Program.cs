using System;
using System.IO;
using TicTacToe.Classes;

namespace TicTacToe
{
    public class Program
    {
        public static GameBoard NewGame { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("You asked for TicTacToe!\n");
            Players();
            DisplayBoard();
            PlayGame();

        }

        /// <summary>
        /// This method takes input by user1 and user2 for names and assigns each the marker, x and o, respectively.
        /// </summary>
        public static void Players()
        {
            Console.WriteLine("This game is two players, by the way.\n" +
                "Player one, enter your name: ");
            string n1 = Console.ReadLine();

            Players player1 = new Players(n1, "x");

            Console.WriteLine($"Welcome {n1}!");

            Console.WriteLine("Alright, your turn to put in your name, Player two: ");
            string n2 = Console.ReadLine();

            Players player2 = new Players(n2, "o");

            Console.WriteLine($"Welcome to you too, {n2}!");
        }

        /// <summary>
        /// This method displays the board as a 3 by 3 matrix.
        /// </summary>
        public static void DisplayBoard()
        {
            GameBoard NewGame = new GameBoard();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"|{NewGame.Board[i, j]}|");
                }
                Console.WriteLine();

            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void PlayGame()
        {
            Console.WriteLine("Player 1, please type in the number where you would like your marker to appear: ");
            Console.ReadLine();
        }
    }
}
