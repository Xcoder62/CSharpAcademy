// prompt user for lower and upper bounds

/* System.Console.Write("Enter the lower bound: ");
int lowerBound = int.Parse(Console.ReadLine());

System.Console.Write("Enter the upper bound: ");
int upperBound = int.Parse(Console.ReadLine());

decimal averageValue = 0;

// exception catching should happen at the calling method since we should be able to manage the exception here

bool exit = false;
do
{
    try 
    {
        // calculate the sum of the even numbers btw the bounds
        averageValue = AverageOfEvenNumbers(lowerBound, upperBound);
    
        // display value returned by method
        System.Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

        exit = true;
    
    } catch (ArgumentOutOfRangeException ex)
    {
        // use a do while loop since if the user reaches this exception again, we want to continue to catch this exception
        System.Console.WriteLine("An error has occured.");
        System.Console.WriteLine(ex.Message);
        System.Console.WriteLine($"The upper bound must be greater than {lowerBound}");
        System.Console.Write("Enter a new upper bound (or enter Exit to quit): ");
        string? userResponse = Console.ReadLine();

        if (userResponse.ToLower().Contains("exit"))
        {
            exit = true;
        }
        else
        {
            exit = false;
            upperBound = int.Parse(userResponse);
        }
        
    }
} while (exit == false);


// wait for user input
Console.ReadLine();

static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
{
    // introduce exception catching based on the user's parameters
    if (lowerBound >= upperBound)
    {
        throw new ArgumentOutOfRangeException("upperBound", "ArgumentOutOfRangeException: upper bound must be greater than lower bound.");
    }

    int sum = 0;
    int count = 0;
    decimal average = 0;
    for (int i = lowerBound; i <= upperBound; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
            count++;
        }
    }

    average = (decimal)sum / count;

    return average;
} */

string[][] userEnteredValues = new string[][]
{
    new string[] { "1", "2", "3"},
    new string[] {"1", "two", "3"},
    new string[] {"0", "1", "2"}
};

string overallStatusMessage = "";

try
{
    Workflow1(userEnteredValues);
    System.Console.WriteLine("'Workflow1 completed successfully.'");
}
catch (DivideByZeroException ex)
{
    System.Console.WriteLine("An error occured during 'Workflow1'");
    System.Console.WriteLine(ex.Message);
}

static void Workflow1(string[][] userEnteredValues)
{
    foreach (string[] userEntries in userEnteredValues)
    {

        try
        {
            Process1(userEntries);
            System.Console.WriteLine("'Process1' completed successfully.");
            System.Console.WriteLine();
        }
        catch (FormatException ex)
        {
            System.Console.WriteLine($"'Process1' encountered an issue, process aborted.");
            System.Console.WriteLine($"{ex.Message}");
            System.Console.WriteLine();
        }

    }

    static void Process1(String[] userEntries)
    {
        int valueEntered;

        foreach (string userValue in userEntries)
        {

            bool integerFormat = int.TryParse(userValue, out valueEntered);
            if (integerFormat == true)
            {
                if (valueEntered != 0)
                {
                    checked
                    {
                        int calculatedValue = 4 / valueEntered;
                    }

                }
                else
                {
                    throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
                }

            }
            else
            {
                throw new FormatException("Invalid data. User input values must be valid integers.");
            }



        }

    }
}