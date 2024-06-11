// See https://aka.ms/new-console-template for more information
using ThePoint;

Console.WriteLine("1. The Point");
ThePoint.Point point0 = new ThePoint.Point();
ThePoint.Point point1 = new ThePoint.Point(2,3);
ThePoint.Point point2 = new ThePoint.Point(-4,0);
point0.Show();
point1.Show();
point2.Show();
Console.ReadLine();

System.Console.WriteLine("2. The Color");
TheColor myColor = new TheColor(254,212,0);
TheColor errorColor = new TheColor(-2,277,9999);
TheColor purple = TheColor.MakePurple();

myColor.ShowColor();
errorColor.ShowColor();
purple.ShowColor();
Console.ReadLine();

System.Console.WriteLine("3. The Card");

Card redOneCard = new Card(CardColor.Red, CardRank.One);
redOneCard.GetCardType();
redOneCard.GetCardName();

// for each color
//    for each rank
//        create a card, show the card type and name of the card, onto the next one.

// only used to display, not apply to a method
// foreach (string colorName in Enum.GetNames(typeof(CardColor)))
// {
//     foreach (string rankName in Enum.GetNames(typeof(CardRank)))
//     {
//        Card newCard = new Card((CardColor)colorName,rankName);
        
//     }
// }

// foreach (string name in Enum.GetNames(typeof(CardRank)))
// {
//     System.Console.WriteLine(name);
// }

// creating new cards from the enum
foreach(CardColor cardColor in Enum.GetValues(typeof(CardColor)))
{
    foreach(CardRank cardRank in Enum.GetValues(typeof(CardRank)))
    {
        Card newCard = new Card(cardColor, cardRank);
        newCard.GetCardName();
        newCard.GetCardType();
    }
}

System.Console.ReadLine();

System.Console.WriteLine("4. The Locked Door");
bool validPassword = false;
int userSelectedPassword;
Door myDoor = null;
string? readResult;
while (validPassword == false)
{
    System.Console.WriteLine("Enter a numeric password for the door");
    readResult = Console.ReadLine();
    
    if (readResult == "" || readResult == null || !int.TryParse(readResult, out userSelectedPassword))
    {
        System.Console.WriteLine("Please enter a numeric password");
    } 
    else
    {
        System.Console.WriteLine("Password Saved");
        validPassword = true;
        myDoor = new Door(userSelectedPassword);
    }

}

//myDoor.StateChange("1234");

bool keepRunning = true;

System.Console.WriteLine("The Door is open.");


while (keepRunning)
{
    System.Console.WriteLine("A door stands before you. what would you like to do? (open, close, lock, unlock, exit)");
    readResult = Console.ReadLine();
    if (readResult.ToLower() == "exit")
    {
        System.Console.WriteLine("Thanks for playing");
        keepRunning = false;
    }
    myDoor.StateChange(readResult);
}

keepRunning = true;
System.Console.WriteLine("The Password Validator");
    while(keepRunning)
{
    System.Console.WriteLine("Enter a password (enter exit to exit)");
    readResult = Console.ReadLine();
    if (readResult.ToLower() == "exit")
    {
        System.Console.WriteLine("Leaving password validator");
        keepRunning = false;
        continue;
    }
    if (PasswordValidator.isValidPassword(readResult))
    {
        System.Console.WriteLine("Valid Password entered");
    }
    else
    {
        System.Console.WriteLine("Invalid Password entered");
    }
}

