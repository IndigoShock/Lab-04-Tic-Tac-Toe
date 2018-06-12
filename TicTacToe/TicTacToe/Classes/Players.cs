using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Classes
{
    public class Players
    {
        public string Name { get; set; }
        public string Marker { get; set; }
        public bool isTurn { get; set; }

        public Players(string name, string marker, bool playerTurn)
        {
            Name = name;
            Marker = marker;
            isTurn = playerTurn;
        }
    }
}
