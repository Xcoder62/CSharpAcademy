internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello Dice!");
        Random dice = new Random();
        int roll = dice.Next(1,7);
        System.Console.WriteLine(roll);

        int result = dice.Next();
        System.Console.WriteLine(result);
    }
}