using System.Collections;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        /*         Console.WriteLine("Hello Dice!");
                Random dice = new Random();
                int roll = dice.Next(1,7);
                System.Console.WriteLine(roll);

                int result = dice.Next();
                System.Console.WriteLine(result); */

        // # Overloaded Methods
        /*  Random dice =  new Random();
         int roll1 = dice.Next();
         int roll2 = dice.Next(101); // 0 - 100
         int roll3 = dice.Next(50,101); // 50 - 100

         System.Console.WriteLine($"First roll: {roll1}");
         System.Console.WriteLine($"Second roll: {roll2}");
         System.Console.WriteLine($"Third roll: {roll3}"); */

        // # Bigger Number
        /* int firstValue = 500;
        int secondValue = 600;
        int largerValue;

        largerValue = System.Math.Max(firstValue,secondValue);

        System.Console.WriteLine(largerValue); */

        // # Dice game
        /* Random dice = new Random();
        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7); */

        // hardcoded
/*         roll1 = 2;
        roll2 = 2;
        roll3 = 4;
 */
        /* int total = roll1 + roll2 + roll3;

        System.Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        // logical or operator
        //First, you evaluate (roll1 == roll2). If that's true, then the entire expression is true. 
        //If it's false, you evaluate (roll2 == roll3). If that's true, then the entire expression is true. 
        //If it's false, you evaluate (roll1 == roll3). If that's true, then the entire expression is true. 
        //If that is false, then the entire expression is false.
        if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
        {

            if ((roll1 == roll2) && (roll2 == roll3))
            {
                System.Console.WriteLine("You rolled triples! +6 bonus to total!");
                total += 6;
            }
            else
            {
                System.Console.WriteLine("You rolled doubles! +2 bonus to total!");
                total += 2;
            }



        }

        if (total >= 16)
        {
            System.Console.WriteLine("You win a new car!");
        } 
        else if (total >= 10)
        {
            System.Console.WriteLine("You win a new laptop!");
        } else if (total == 7) {
            System.Console.WriteLine("You win a trip for two!");
        } else {
            System.Console.WriteLine("You win a kitten!");
        }
 */

        /* Random random = new Random();
        int daysUntilExpiration = random.Next(12);
        int discountPercentage = 0;

        // hard code days
        //daysUntilExpiration = 1;

        System.Console.WriteLine($"Days Left: {daysUntilExpiration}");

        if (daysUntilExpiration > 10) {
            
        } else if (daysUntilExpiration <= 0) {
            System.Console.WriteLine("Your subscription has expired.");
            
        } 
        
        else if (daysUntilExpiration == 1) {
            discountPercentage = 20;
            System.Console.WriteLine("Your subscription expires within a day!");
            //System.Console.WriteLine($"Renew now and save {discountPercentage}%!");
            
        } else if (daysUntilExpiration <= 5) {
            discountPercentage = 10;
            System.Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days");
            
        } else if (daysUntilExpiration <= 10 ){
            System.Console.WriteLine("Your subscription will expire soon. Renew Now!");
        }

        if (discountPercentage > 0) {
            System.Console.WriteLine($"Renew now and save {discountPercentage}%!");
        } */

        /* string[] fraudulentOrderIDs = new string[3]; // I can hold 3 string elements

        fraudulentOrderIDs[0] = "A123";
        fraudulentOrderIDs[1] = "B456";
        fraudulentOrderIDs[2] = "C789"; */

/*         // initialize an array
        string[] fraudulentOrderIDs = {"A123", "B456", "C789"};

        //fraudulentOrderIDs[3] = "D000"; out of next range. above implicitly means only 3 strings can fit in array

        System.Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
        System.Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
        System.Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

        fraudulentOrderIDs[0] = "F000";

        System.Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

        System.Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process."); */

        // # int arrays
        /* int[] inventory = {200,450,700,175,250};
        int sum = 0;
        int bin = 0;
        foreach (var items in inventory)
        {
            sum += items;
            bin++;
            System.Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
        }

        System.Console.WriteLine($"We have {sum} items in inventory");
 */
        /* string[] orderIds = {"B123","C234","A345","C15","B177","G3003","C235","B179"};

        foreach (string item in orderIds)
        {
            if (item.StartsWith("B")) {
                System.Console.WriteLine(item);
            }
        } */

        // Comment Practice
        // use camelCase ie thisIsCamelCase
        // be descriptive, bool orderComplete NOT bool isComplete.
        // use the full name, dont abbreiviate decimal orderAmount NOT decimal odrAmt;
        // dont use str or datatype in the name. ie do not use strMyValue.
        // use comments to help you understand highler level what the intent of the code is for
        // can use comments to test out new ideas without having to delete the old code.
        // if the comment can be answered through intellisense, then it is considered a low quality comment
        // should explain the purpose of the code as it relates to the larger system.
        // comment should explain how your code solves a problem.

        /* easy way to remove 3 or more lines of code through block comment
        string firstName = "Bob";
        int widgetsPurchased = 7;
        System.Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
        */

       /*  Low quality comment example
       Random random = new Random();
        string[] orderIDs = new string[5];
        // Loop through each blank orderID
        for (int i = 0; i < orderIDs.Length; i++) {
            // Gets a random value that equates to ASCII letters A to E
            int prefixValue = random.Next(65,70);
            // Convert the random value into a char, then a string
            string prefix = Convert.ToChar(prefixValue).ToString();
            // create a random number, pad with zeroes
            string suffix = random.Next(1,1000).ToString("000");
            // Combine the prefix and suffix together, then assign to current OrderID
            orderIDs[i] = prefix + suffix;
        }

        // printout each orderID
        foreach (var orderID in orderIDs)
        {
            System.Console.WriteLine(orderID);
        }
    */

    // high quality comment example

    /* 
      The following code creates five random OrderIDs
      to test the fraud detection process. OrderIDs
      Consist of a letter from A to E, and a three 
      digit number. Ex. A123.
    */
       /*  Random random = new Random();
        string[] orderIDs = new string[5];

        for (int i = 0; i < orderIDs.Length; i++) {
            int prefixValue = random.Next(65,70);
            string prefix = Convert.ToChar(prefixValue).ToString();
            string suffix = random.Next(1,1000).ToString("000");
            orderIDs[i] = prefix + suffix;
        }

        // printout each orderID
        foreach (var orderID in orderIDs)
        {
            System.Console.WriteLine(orderID);
        } */

    
    // Why Whitespace is important for readability
    // Example 1
    Console
    .
    WriteLine
    (
     "Hello Example 1!"
    );

    // Example 2:
    string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!");

    Random dice = new Random();

    int roll1 = dice.Next(1,7);
    int roll2 = dice.Next(1,7);
    int roll3 = dice.Next(1,7);

    int total = roll1 + roll2 + roll3;
    System.Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
    
    // for formatting if statements, { } should be used to define a code block and else is between the two.
    if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
    {
        if ((roll1 == roll2) && (roll2 == roll3)) 
        {
            System.Console.WriteLine("You rolled triples! +6 bonus to total!");
            total += 6;
        } 
        else 
        {
            System.Console.WriteLine("You rolled doubles! +2 bonus to total!");
            total += 2;
        }
    }

    // Improve readability Challenge


    /*      
       Counts the number of times 'o' appears in a message.
       In addition, reverses the message as well and prints
       the reversed message onto the console window. 
    */

/*     string message = "the quick brown fox jumps over the lazy dog"; // originalMessage
    
    char[] messageLetters = message.ToCharArray(); // message (being processed)
    Array.Reverse(messageLetters);

    int letterCount = 0;
    
    foreach (char letter in messageLetters) 
    { 
        if ( letter == 'o') 
        {
             letterCount++;
        }
    }

    string reversedMessage = new string(messageLetters); // newMessage (final result)

    System.Console.WriteLine(reversedMessage);
    System.Console.WriteLine($"'o' appears {letterCount} times."); */

    // # Guided Project - Develop foreach and if-else structures to process array data in c#.
    

    }

   

}

