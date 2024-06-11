// See https://aka.ms/new-console-template for more information



/* 
Console.WriteLine("Hello, World!");
Season current = Season.Winter;
 */
// ### Enumeration
// should be used for small set few to hundreds
// UpperCamelCase for type names and the Enumeration values

// ## Simula's Test
/* ChestState chest = ChestState.Locked;
string? readResult;

while (true)
{
    if (chest == ChestState.Open)
    {
        System.Console.Write("The chest is open. What do you want to do? ");
        readResult = Console.ReadLine();
        if (readResult.ToLower() == "close")
        {
            chest = ChestState.Closed;
        }

    }
    else if (chest == ChestState.Closed)
    {
        System.Console.Write("The chest is unlocked. What do you want to do? ");
        readResult = Console.ReadLine();
        if (readResult.ToLower() == "open")
        {
            chest = ChestState.Open;
        }
        else if (readResult.ToLower() == "lock")
        {
            chest = ChestState.Locked;
        }

    }
    else 
    {
        System.Console.Write("The chest is locked. What do you want to do? ");
        readResult = Console.ReadLine();
        if (readResult.ToLower() == "unlock")
        {
            chest = ChestState.Closed;
        }
    }

} */

// ### Tuples
// value types

/* (string, int, int) score1 = ("R2-D2", 12420, 15);
var score2 = ("Bleh", 123, 10); // 3-tuple composed of smaller elements, string, int and int.
System.Console.WriteLine($"name:{score1.Item1} Level:{score1.Item3}, score: {score1.Item2}");

// instead of using Item, can use laternative name in left or right side or combo of both
(string Name, int Points, int Level) score3 = ("Fish", 200, 2);
var score4 = (Name: "Sammy", Points: 51231, Level: 99);

System.Console.WriteLine($"Name: {score3.Name} Level: {score3.Level} Score: {score3.Points}");
System.Console.WriteLine($"Name: {score4.Name} Level: {score4.Level}, Score: {score4.Points}");

// deconstructing a tuple
string name1;
int points1;
int level1;

(name1, points1, level1) = score3;
System.Console.WriteLine($"{name1} reached level {level1} with {points1} points");

// quick swap
double x = 4;
double y = 2;
(x, y) = (y, x);


// _ discard, level from score4 will not be recorded.
(name1, points1, _) = score4;

System.Console.WriteLine($"From ENUM to number: W:{(int)Season.Winter}, S: {(int)Season.Spring}, Summer: {(Season)9}, Fall: {(Season)10} ");
System.Console.WriteLine($"{(Season)11}"); // invalid enum number will just return the int
 */

// ### Simula's Soup
/* System.Console.WriteLine("Simula's Soup");
(Type RecipeType, Ingredient Ingredient, Seasoning Seasoning) mySoup = (Type.Stew, Ingredient.Chicken, Seasoning.Sweet);

System.Console.WriteLine("Select a Type of Soup (use the numbers below)");
System.Console.WriteLine("0. Soup");
System.Console.WriteLine("1. Stew");
System.Console.WriteLine("2. Gumbo");
var inputType = Convert.ToInt32(Console.ReadLine());
mySoup.RecipeType = (Type)inputType;

System.Console.WriteLine("Select an Ingredient");
System.Console.WriteLine("0. Mushrooms");
System.Console.WriteLine("1. Chicken");
System.Console.WriteLine("2. Carrots");
System.Console.WriteLine("3. Potatoes");
var inputIngredient = Convert.ToInt32(Console.ReadLine());
mySoup.Ingredient = (Ingredient)inputIngredient;

System.Console.WriteLine("Select a Seasoning");
System.Console.WriteLine("0. Spicy");
System.Console.WriteLine("1. Salty");
System.Console.WriteLine("2. Sweet");
var inputSeasoning = Convert.ToInt32(Console.ReadLine());
mySoup.Seasoning = (Seasoning)inputSeasoning;

System.Console.WriteLine($"Here's the recipe: {mySoup.Seasoning} {mySoup.Ingredient} {mySoup.RecipeType}");
System.Console.WriteLine(mySoup); */


// ### Vin Fletcher's Arrows
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

System.Console.WriteLine("Vin Fletcher's Arrows");
Arrow defaultArrow = new Arrow();
Arrow userArrow;

System.Console.WriteLine("Select a pre-determined arrow or create your own!");
System.Console.WriteLine("0. Elite Arrow");
System.Console.WriteLine("1. Beginner Arrow");
System.Console.WriteLine("2. Marksman Arrow");
System.Console.WriteLine("3. Custom arrow");

var userChoice = Convert.ToInt32(Console.ReadLine());

if (userChoice == 0)
{
    userArrow = Arrow.CreateEliteArrow();
}
else if (userChoice == 1)
{
    userArrow = Arrow.CreateBeginnerArrow();
}
else if (userChoice == 2)
{
    userArrow = Arrow.CreateMarksmanArrow();
}
else
{
    System.Console.WriteLine("Custom arrow selected!");
    System.Console.WriteLine("Select an arrowhead type");
    System.Console.WriteLine("0. Steel");
    System.Console.WriteLine("1. Wood");
    System.Console.WriteLine("2. Obsidian");
    var arrowHeadInput = Convert.ToInt32(Console.ReadLine());
    //userArrow._arrowhead = (Arrowhead)arrowHeadInput;

    System.Console.WriteLine("Select a Fletching type");
    System.Console.WriteLine("0. plastic");
    System.Console.WriteLine("1. turkey feathers");
    System.Console.WriteLine("2. goose feathers");

    var fletchingInput = Convert.ToInt32(Console.ReadLine());
    //userArrow._fletching = (Fletching)fletchingInput;

    System.Console.WriteLine("Select a shaft length between 60cm to 100cm");
    var shaftLengthInput = Convert.ToInt32(Console.ReadLine());

    //userArrow._shaftLength = shaftLengthInput;
    userArrow = new Arrow((Arrowhead)arrowHeadInput, (Fletching)fletchingInput, shaftLengthInput);
}



System.Console.WriteLine($"The cost of the default arrow is : {defaultArrow.GetCost()}");
System.Console.WriteLine($"The cost of your arrow is : {userArrow.GetCost()}");

System.Console.WriteLine($"User's arrow: {userArrow.Arrowhead}, {userArrow.Fletching}, {userArrow.ShaftLength}");

Console.WriteLine("Hello level 19");
var p1 = new Point();
var p2 = new Point(-2, 4);
p1.Print();
p2.Print();
p1.X = 5;
p1.Print();

var c1 = new MyColor();
var c2 = new MyColor(10, 20, 30);
var c3 = MyColor.SetWhite();
var c4 = new MyColor(-4, 999, 140);
var c5 = MyColor.SetOrange();
c1.Print();
c2.Print();
c3.Print();
c4.Print();
c5.Print();
// Object Oritented Programming
// Noun Extraction


// ways to check for null without the program crashing
//Both ?. and ?[] evaluate the part before it to see if it is null. If it is, then no further evaluation
// happens, and the whole expression evaluates to null.

/* private string? GetTopPlayerName()
{
return _scoreManager?.GetScores()?[0]?.Name;
} */
// may still need to use  if (x == null) in most cases
// can also use null coalescing operator to return value if null found

/* private string GetTopPlayerName() // No longer needs to allow nulls.
{
return _scoreManager?.GetScores()?[0]?.Name ?? "(not found)";
}
 */
(string Name, int Points, int Level) GetScore() => ("Jerma", 9000, 9);


public class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public Point()
    {
        X = 0;
        Y = 0;
    }
    public Point(int x, int y)
    {
        X = x;
        Y = y;

    }
    public void Print()
    {
        System.Console.WriteLine($"({X},{Y})");
    }

}
class Score
{
    // use unscore when naming fields, otherwise name hiding happens
    // or use this.name when using a constructor.
    public string _name;
    public int _points;
    public int _level;
    // how to call a constructor with this
    public Score() : this("Unknown", 0, 1)
    {

    }
    public Score(string name, int points, int level)
    {
        _name = name;
        _points = points;
        _level = level;
    }

    public bool EarnedStar() => (_points / _level) > 1000;
}
/* public class Score
{
public static int PointThreshold { get; } = 1000;
public static int LevelThreshold { get; } = 4;
} */

// factory method example
//Another common use of static methods is a factory method, which creates new instances for
//the outside world as an alternative to calling a constructor. For example, this method could be
//a factory method in our Rectangle class:
//public static Rectangle CreateSqaure(float size) => new Rectangle(size,size);

// outside world would call
//Rectangle mySquare = Rectangle.CreateSquare(2);
public class MyColor
{
    private int _red;
    private int _green;
    private int _blue;

    public int Red
    {
        get { return _red; }
        set
        {
            _red = value;
            if (_red > 255)
            {
                _red = 255;
            }
            else if (_red < 0)
            {
                _red = 0;
            }


        }
    }

    public int Green
    {
        get { return _green; }
        set
        {
            _green = value;
            if (_green > 255)
            {
                _green = 255;
            }
            else if (_green < 0)
            {
                _green = 0;
            }


        }
    }

    public int Blue
    {
        get { return _blue; }
        set
        {
            _blue = value;
            if (_blue > 255)
            {
                _blue = 255;
            }
            else if (_blue < 0)
            {
                _blue = 0;
            }


        }
    }

    public MyColor()
    {
        Red = 0;
        Green = 0;
        Blue = 0;
    }

    public MyColor(int red, int green, int blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }

    public void Print()
    {
        System.Console.WriteLine($"R: {Red} G: {Green} B: {Blue}");
    }

    public static MyColor SetWhite() => new MyColor(255, 255, 255);
    public static MyColor SetBlack() => new MyColor(0, 0, 0);
    public static MyColor SetRed() => new MyColor(255, 0, 0);
    public static MyColor SetOrange() => new MyColor(255, 165, 0);
    public static MyColor SetYellow()
    {
        return new MyColor(255,255,0);
    }
    public static MyColor SetGreen() => new MyColor(0,128,0);
    public static MyColor SetBlue() => new MyColor(0,0,255);
    public static MyColor SetPurple() => new MyColor(128,0,128);
}
class Arrow
{
    //private Arrowhead _arrowhead;
    //private Fletching _fletching;
    private int _shaftLength;

    public Arrowhead Arrowhead { get; set; }
    public Fletching Fletching { get; set; }
    public int ShaftLength
    {

        get
        {
            return _shaftLength;
        }
        set => _shaftLength = value;

    }
    public Arrow() : this(Arrowhead.Steel, Fletching.Plastic, 60)
    {

    }

    public Arrow(Arrowhead arrowhead, Fletching fletching, int shaftLength)
    {
        Arrowhead = arrowhead;
        Fletching = fletching;
        _shaftLength = shaftLength;
    }

    public int GetShaftLength()
    {
        return _shaftLength;
    }

    public static Arrow CreateEliteArrow()
    {
        return new Arrow(Arrowhead.Steel, Fletching.Plastic, 95);
    }


    public static Arrow CreateBeginnerArrow()
    {
        return new Arrow(Arrowhead.Wood, Fletching.GooseFeathers, 75);
    }


    public static Arrow CreateMarksmanArrow()
    {
        return new Arrow(Arrowhead.Steel, Fletching.GooseFeathers, 65);
    }

    public float GetCost()
    {
        float cost = 0;

        // arrowhead cost
        switch (Arrowhead)
        {
            case Arrowhead.Steel:
                cost += 10;
                break;
            case Arrowhead.Wood:
                cost += 3;
                break;
            case Arrowhead.Obsidian:
                cost += 5;
                break;
        }
        // feltching cost
        switch (Fletching)
        {
            case Fletching.Plastic:
                cost += 10;
                break;
            case Fletching.TurkeyFeathers:
                cost += 5;
                break;
            case Fletching.GooseFeathers:
                cost += 3;
                break;
        }

        cost += (ShaftLength * 0.05f);
        return cost;
    }
}

// when to use private or public
// fields should always be private.
// better to set as private, case by case for public. it should allow the class to fulfill its role in the system.

// abstraction
// you can change the insides of the methods, but as long as it performs it's role, it should be fine.

// internal keyword
// supporting role/class, that can help other classes accomplisht their job but dont want the outside world to know about.



/* class Rectangle
{
    private float _width;
    private float _height;
    private float _area;
    public Rectangle(float width, float height)
    {
        _width = width;
        _height = height;
        _area = _width * _height;
    }
    public float GetWidth() => _width;
    public float GetHeight() => _height;
    public float GetArea() => _area;
    public void SetWidth(float value)
    {
        _width = value;
        _area = _width * _height;
    }
    public void SetHeight(float value)
    {
        _height = value;
        _area = _width * _height;
    }
} */

// remove the need for getters ands etters with proeprties
public class Rectangle
{
    private float _width;
    private float _height;
    public Rectangle(float width, float height)
    {
        _width = width;
        _height = height;
    }
    public float Width
    {
        get => _width;
        set => _width = value;
    }
    public float Height
    {
        get => _height;
        set => _height = value;
    }
    public float Area => _width * _height;
}


enum Arrowhead { Steel, Wood, Obsidian };
enum Fletching { Plastic, TurkeyFeathers, GooseFeathers };

enum Season { Winter = 3, Spring = 6, Summer = 9, Fall }; // new types go after main AND METHODS or in seperate file
// first item is default.
enum ChestState
{
    Open,
    Closed,
    Locked
};

enum Type { Soup, Stew, Gumbo };
enum Ingredient { Mushrooms, Chicken, Carrots, Potatoes };
enum Seasoning { Spicy, Salty, Sweet }

enum CardColor
{
    Red,
    Green,
    Blue,
    Yellow

}




// int number = (int)Season.Fall;
// Season now = (Season)2;

