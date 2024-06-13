using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTicTacToeGame
{
    public class Board
    {
        private Dictionary<int, string> _board;
        private string _winnerName = "";

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

        public bool WinCondition()
        {
            // horizontal win
            if (_board[7] == "X" && _board[8] == "X" && _board[9] == "X")
            {
                _winnerName = "X";
                return true;
            } 
            
            else if (_board[7] == "O" && _board[8] == "O" && _board[9] == "O")
            {
                _winnerName = "O";
                return true;
            } 
            else if (_board[4] == "X" && _board[5] == "X" && _board[6] == "X")
            {
                _winnerName = "X";
                return true;
            }
            else if (_board[4] == "O" && _board[5] == "O" && _board[6] == "O")
            {
                _winnerName = "O";
                return true;
            }
            else if (_board[1] == "X" && _board[2] == "X" && _board[3] == "X")
            {
                _winnerName = "X";
                return true;
            }
            else if (_board[1] == "O" && _board[2] == "O" && _board[3] == "O")
            {
                _winnerName = "O";
                return true;
            }
            // verical win
            else if (_board[7] == "X" && _board[4] == "X" && _board[1] == "X")
            {
                _winnerName = "X";
                return true;
            } 
            else if (_board[7] == "O" && _board[4] == "O" && _board[1] == "O")
            {
                _winnerName = "O";
                return true;
            }
            else if (_board[8] == "X" && _board[5] == "X" && _board[2] == "X")
            {
                _winnerName = "X";
                return true;
            }
            else if (_board[8] == "O" && _board[5] == "O" && _board[2] == "O")
            {
                _winnerName = "O";
                return true;
            }
            else if (_board[9] == "X" && _board[6] == "X" && _board[3] == "X")
            {
                _winnerName = "X";
                return true;
            }
            else if (_board[9] == "O" && _board[6] == "O" && _board[3] == "O")
            {
                _winnerName = "O";
                return true;
            }
            else if (_board[7] == "X" && _board[5] == "X" && _board[3] == "X")
            {
                _winnerName = "X";
                return true;
            }
            else if (_board[7] == "O" && _board[5] == "O" && _board[3] == "O")
            {
                _winnerName = "O";
                return true;
            }
            else if (_board[9] == "O" && _board[5] == "O" && _board[1] == "O")
            {
                _winnerName = "O";
                return true;
            }
            else if (_board[9] == "X" && _board[5] == "X" && _board[1] == "X")
            {
                _winnerName = "X";
                return true;
            }
            else
            {
                return false;
            }
            

            // diagonal win
        }

        public string GetWinnerName()
        {
            return _winnerName;
        }

    }
}