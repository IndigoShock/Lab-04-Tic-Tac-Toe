using System;
using System.IO;
using TicTacToe.Classes;

namespace TicTacToe
{
    public class Program
    {
        public static void Main(string[] args)
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

            Players player1 = new Players(n1, "x", true);

            Console.WriteLine($"Welcome {n1}!");

            Console.WriteLine("Alright, your turn to put in your name, Player two: ");
            string n2 = Console.ReadLine();

            Players player2 = new Players(n2, "o", false);

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
        /// This method causes the game to start.
        /// </summary>
        public static void PlayGame()
        {
            Console.WriteLine("Player 1, please type in the number where you would like your marker to appear: ");
            Console.ReadLine();
        }

        //public static void SwitchPlayers()
        //{

        //    if (true) 
        //    {
        //        Players player1 = true;
        //        Players player2 = false;
        //    }
        //    else
        //    {
        //        Players player1 = false;
        //        Players player2 = true;
        //    }
        //}

        //public static bool CheckingWinner()
        //    {
        //    int[][] winners = new int[][]
        //    {
        //        new[] {1,2,3},
        //        new[] {4,5,6},
        //        new[] {7,8,9},

        //        new[] {1,4,7},
        //        new[] {2,5,8},
        //        new[] {3,6,9},

        //        new[] {1,5,9},
        //        new[] {3,5,7}
    }
}