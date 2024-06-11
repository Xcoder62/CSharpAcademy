using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTicTacToeGame
{
    public class Board
    {
        private Dictionary<int, string> _board;

        public Board()   
        {
            _board = new Dictionary<int, string>();
            for (int i = 1; i < 10; i++)
            {
                _board[i] = " ";
            }
        }

        public void DisplayBoard()
        {
            Console.Beep();
            System.Console.WriteLine($" {_board[7].ToUpper()} | {_board[8].ToUpper()} | {_board[9].ToUpper()} ");
            System.Console.WriteLine($"---+---+---");
            System.Console.WriteLine($" {_board[4].ToUpper()} | {_board[5].ToUpper()} | {_board[6].ToUpper()} ");
            System.Console.WriteLine($"---+---+---");
            System.Console.WriteLine($" {_board[1].ToUpper()} | {_board[2].ToUpper()} | {_board[3].ToUpper()} ");
        }

        public bool ConfirmChoice(Player player)
        {
            if (_board[player.PlayerChoice] == " "){
                _board[player.PlayerChoice] = player.PlayerName; 
                return true;
            } 
            else 
            {
                System.Console.WriteLine($"An {_board[player.PlayerChoice]} occupies this spot. please try again");
                return false;
            }
        }

    }
}