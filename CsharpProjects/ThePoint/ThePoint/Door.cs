using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThePoint
{
    public class Door
    {
        private int _password;
        public int Password { get {return _password; } set { _password = value;} }
        public DoorState DoorStatus { get; set; }

        public Door(int password)
        {
            Password = password;
            DoorStatus = DoorState.Open;
        }

        public bool HasValidPassword(string password)
        {
            if (password == Password.ToString())
            {
                return true;
            }
            return false;
        }

        public void StateChange(string command)
        {
            command = command.ToLower();
            if (command == Password.ToString())
            {
                
                string? readResult = "";
                int newPassword;
                bool validPassword = false;
                while (validPassword == false)
                {
                    System.Console.WriteLine("Please enter new numeric password:");
                    readResult = Console.ReadLine();
                    if (readResult == "" || readResult == null || !int.TryParse(readResult, out newPassword))
                    {
                        System.Console.WriteLine("Please enter a numeric password");
                    } 
                    else
                    {
                        Password = newPassword;
                        System.Console.WriteLine("Password Saved");
                        validPassword = true;
                    }

                }
                
            }
            

            else if (DoorStatus == DoorState.Open)
            {
                if (command == "open")
                {
                    System.Console.WriteLine("The door is already opened");
                } 
                else if (command == "close")
                {
                    DoorStatus = DoorState.Closed;
                    System.Console.WriteLine("The Door is now closed");
                }
                else if (command == "lock")
                {
                    //DoorStatus = DoorState.Locked;
                    //System.Console.WriteLine("The door is now locked.");
                    System.Console.WriteLine("The door must be closed first.");
                }
                else if (command == "unlock")
                {
                    System.Console.WriteLine("The door is already opened and unlocked.");
                } 
                else {
                    System.Console.WriteLine("Unknown Command");
                }


            }
            else if (DoorStatus == DoorState.Closed)
            {
                if (command == "open")
                {
                    DoorStatus = DoorState.Open;
                    System.Console.WriteLine("The door is now open.");
                } else if (command == "close")
                {
                    System.Console.WriteLine("The door is already closed.");
                } else if (command == "lock") 
                {
                    DoorStatus = DoorState.Locked;
                    System.Console.WriteLine("The door is now locked.");
                } else if (command == "unlock")
                {
                    System.Console.WriteLine("The door is already closed and unlocked.");
                }
            }
            else if (DoorStatus == DoorState.Locked)
            {
                if (command == "open")
                {
                    System.Console.WriteLine("Unable to open the locked door.");
                    


                } else if (command == "close")
                {
                    System.Console.WriteLine("The door is already closed and clocked");
                } else if (command == "lock") 
                {
                    System.Console.WriteLine("The door is already locked");
                } else if (command == "unlock")
                {
                    System.Console.WriteLine("Enter pin number:");
                    string? userInput = Console.ReadLine();
                    if (HasValidPassword(userInput))
                    {
                        DoorStatus = DoorState.Closed;
                        System.Console.WriteLine("The Door has been unlocked");
                    } 
                    else 
                    {
                        System.Console.WriteLine("Invalid password. Door remains locked");
                    }
                }
            }
            else 
            {
                System.Console.WriteLine("Unknown Command");
            }
        }



    }
}