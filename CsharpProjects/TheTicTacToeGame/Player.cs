using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;
using System.Xml;

namespace TheTicTacToeGame
{
    public class Player
    {
        public string PlayerName { get; set; }
        public string PlayerChoice { get; set; }

        public Player(string playerName)
        {
            PlayerName = playerName;
        }

        public void MakeChoice()
        {
            System.Console.WriteLine("What Square do you want to play in?");
            bool validSelection = false;
            while (!validSelection)
            {
                string? readResult = Console.ReadLine();
                if (int.TryParse(readResult, out int choice))
                {
                    if (choice < 1 || choice > 9)
                    {
                        System.Console.WriteLine("Please Enter a number within the numpad range (1-9)");
                    } else
                    {
                        System.Console.WriteLine("TODO - valid number selected, return number and have the GAME ask if this is a valid space");
                    }
                } 
                
                else 
                {
                    System.Console.WriteLine("Please Enter a valid int number within the numpad range (1-9)");
                }


                
            }

        }

    }
}