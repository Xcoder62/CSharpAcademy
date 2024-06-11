// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/* //CountDown(10);
var wait = Console.ReadLine();

string CountDown(int x)
{
    if (x == 1)
    {
        System.Console.WriteLine(x);
        return "";
    }
    System.Console.WriteLine(x);
    return CountDown(x-1);
}
 */

// Hunting the Manticore game start

int cityHP = 15;
int manticoreHP = 10;
int round = 1;

int manticoreLocation = SetManticoreDistance();
Console.Clear();
System.Console.WriteLine("Player 2, It is your turn.");
System.Console.WriteLine("----------------------------------------------------");
do
{
    DisplayStatus();
    int expectedDmg = CalculateDmg();
    System.Console.WriteLine($"The cannon is expected to deal {expectedDmg} damage this round.");
    LaunchCannon(expectedDmg);
    if (manticoreHP <= 0)
    {
        DetermineWinner();
        return;
    }

    // increment round
    cityHP--;
    round++;
    Console.BackgroundColor = ConsoleColor.Black;
    System.Console.WriteLine("----------------------------------------------------");

} while (cityHP > 0 && manticoreHP > 0);

DetermineWinner();

void DetermineWinner()
{
    if (cityHP > manticoreHP)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        System.Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
    } else if (cityHP < manticoreHP)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        System.Console.WriteLine("The City of Consolas has been destoryed! The Manticore reigns supreme!");
    } else
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        System.Console.WriteLine("Both the City Of Consolas and Manticore have been destroyed!");
    }

    System.Console.WriteLine("Thanks for playing!! Press any button to exit");
    var result = Console.ReadLine();
}

void LaunchCannon(int expectedDmg)
{
    string? readResult;
    int guessLocation = -1;
    bool validResponse = false;
    System.Console.Write("Enter desired cannon range: ");
    do
    {
        readResult = Console.ReadLine();

        if (readResult != null)
        {
            try
            {
                if (int.TryParse(readResult, out guessLocation))
                {
                    if (guessLocation > -1 && guessLocation < 101)
                    {
                        validResponse = true;
                    }
                }
            }
            catch (Exception ex)
            {
                // do nothing ask eagain.
            }
        }

    } while (validResponse == false);

    if (manticoreLocation == guessLocation)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        System.Console.WriteLine("\rThat round was a DIRECT HIT!");
        manticoreHP -= expectedDmg;
    }
    else if (guessLocation < manticoreLocation)
    {
        Console.BackgroundColor = ConsoleColor.Magenta;
        System.Console.WriteLine("\rThat round FELL SHORT of the target.");
    } 
    else if (guessLocation > manticoreLocation)
    {
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        System.Console.WriteLine("\rThat round OVERSHOT the target.");
    }

}

int CalculateDmg()
{
    int result = 0;
    if (round % 5 == 0 && round % 3 == 0)
    {
        result = 10;
    }
    else if (round % 5 == 0)
    {
        result = 3;
    }
    else if (round % 3 == 0)
    {
        result = 3;
    }
    else
    {
        result = 1;
    }

    return result;
}

void DisplayStatus()
{
    System.Console.WriteLine($"STATUS: Round: {round} City: {cityHP}/15 Manticore: {manticoreHP}/10");
}

int SetManticoreDistance()
{
    int result = 0;
    bool validResponse = false;
    string? readResult;

    do
    {
        System.Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
        readResult = Console.ReadLine();
        if (readResult != null)
        {
            try
            {
                if (int.TryParse(readResult, out result))
                {
                    if (result > -1 && result < 101)
                    {
                        validResponse = true;
                    }
                }



            }
            catch (Exception ex)
            {
                // do nothing, program should ask again.
            }
        }


    } while (validResponse == false);

    return result;
}

