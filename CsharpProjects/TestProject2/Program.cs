// See https://aka.ms/new-console-template for more information
/* System.Console.WriteLine("a" == "a");
System.Console.WriteLine("a" == "A");
System.Console.WriteLine(1 == 2);

string myValue = "a";
System.Console.WriteLine(myValue == "a");

string value1 = " a";
string value2 = "A ";

// massage data
System.Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower()); */

/* System.Console.WriteLine("a" != "a");
System.Console.WriteLine("a" != "A");
System.Console.WriteLine(1 != 2);
string val3 = "a";
System.Console.WriteLine(val3 != "a"); */

// comparision operators
/* System.Console.WriteLine(1>2);
System.Console.WriteLine(1<2);
System.Console.WriteLine(1 >=1);
System.Console.WriteLine(1 <= 1); */

// some methods return bool
//string pangram = "The quick brown fox jumps over the lazy dog.";
/* System.Console.WriteLine(pangram.Contains("fox"));
System.Console.WriteLine(pangram.Contains("cow")); 
System.Console.WriteLine(!pangram.Contains("fox"));
System.Console.WriteLine(!pangram.Contains("cow"));
*/

/* int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
System.Console.WriteLine($"Discount: {discount}"); */

/* Random coinFlip = new Random();
var flipResult = coinFlip.Next(0,2);
System.Console.WriteLine((flipResult == 1) ? "heads" : "tails");
 */

//string permission = "Admin|Manager";
/* string permission = "burger";
int level = 54;

if (permission.Contains("Admin") && level > 55) {
    System.Console.WriteLine("Welcome, Super Admin user.");
} else if (permission.Contains("Admin") && level <= 55) {
    System.Console.WriteLine("Welcome. Admin user.");
} else if (permission.Contains("Manager") && level >= 20) {
    System.Console.WriteLine("Contact Admin for access");
} else if (permission.Contains("Manager") && level < 20) {
    System.Console.WriteLine("You do not have sufficent priviledges.");
} else if (!permission.Contains("Admin") && !permission.Contains("Manager")) {
    System.Console.WriteLine("You do not have sufficent priviledges.");
}

string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
} */

// # code blocks and variable scopes
/* bool flag = true;
int value;
if (flag) {
    value = 10;
    System.Console.WriteLine($"Inside of code block: {value}");
}
System.Console.WriteLine($"Outside of code block: {value}");  */// because value = 10 is inside the code block and flag should be false, it is still technically an unassigned variable. 
                                                                // need to initalize outside of code block too.

/* bool flag = true;
int value = 0;
if (flag) {
    value = 10;
    System.Console.WriteLine($"Inside of code block: {value}");
}
System.Console.WriteLine($"Outside of code block: {value}");  */
/* 
bool flag2 = true;
if (flag2) {
    System.Console.WriteLine(flag2); // 1 line of code? can convert to a code block with curly braces
}

if (flag2)
    System.Console.WriteLine(flag2);

// not so good if statement
if (flag2) System.Console.WriteLine(flag2);

string name = "steve";
if (name == "bob") System.Console.WriteLine("Found Bob");
else if (name == "steve") System.Console.WriteLine("Found Steve");
else System.Console.WriteLine("Found Chuck");

// better fomatting
string name2 = "steve";

if (name2 == "bob")
    System.Console.WriteLine("Found Bob");
else if (name2 == "steve")
    System.Console.WriteLine("Found Steve");
else
    System.Console.WriteLine("Found Chuck");
 */


/*  int[] numbers = {4,8,15,16,23,42}; 

int total = 0;
bool found = false;
foreach (int number in numbers)
{
    if (number == 42) 
        found = true;

    total += number;
}

if (found) 
    System.Console.WriteLine("Set contains 42");

System.Console.WriteLine($"Total: {total}"); */

// # switch
// A switch is best used when.
// You have a single value (variable or expression) that you want to match against many possible values.
// For any given match, you need to execute a couple of lines of code at most.
/* int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";
switch (employeeLevel) 
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;

}

System.Console.WriteLine($"{employeeName}, {title}"); */

// SKU = Stock Keeping Unit.
// SKU value format: <product #>-<2-letter color code>-<size code>
/* string sku = "01-MN-L";
string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

// if version

if (product[0] == "01")
    type = "Sweat shirt";
else if (product[0] == "02")
    type = "T-Shirt";
else if (product[0] == "03")
    type = "Sweat pants";
else
    type = "Other";

if (product[1] == "BL")
    color = "Black";
else if (product[1] == "MN")
    color = "Maroon";
else 
    color = "White";


if (product[2] == "S")
    size = "Small";
else if (product[2] == "M")
    size = "Medium";
else if (product[2] == "L")
    size = "Large";
else 
    size = "One Size fits All";

System.Console.WriteLine($"Product: {size} {color} {type}");

// switch version
switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;   
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;   
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "White";
        break;   
}

System.Console.WriteLine($"Product: {size} {color} {type}"); */

// # For Loops
//  (initializer, condition, and iterator) 
/* for (int i = 0; i < 10; i++) // last number is 9
{
    System.Console.WriteLine(i);
}
System.Console.WriteLine("");
// decrement
for (int i = 10; i >= 0; i--) // last number is 0 
{
    System.Console.WriteLine(i);
}
System.Console.WriteLine("");
// skip past certain values
for (int i = 0; i < 10; i += 3) {
    System.Console.WriteLine(i);
}
System.Console.WriteLine("");

// break an iteration
for (int i = 0; i < 10; i++)
{
    System.Console.WriteLine(i);
    if (i == 7)
        break;
}

System.Console.WriteLine("");

// iterate through the names of the array
string[] names = { "Alex", "Eddie", "David", "Michael"};
for (int i = names.Length-1; i>= 0; i--) // we can go backwards in a for loop but not the foreach loop
{
    System.Console.WriteLine(names[i]);
} */

// you can't change/update the value in the foreach loop iterator
//  error CS1656: Cannot assign to 'name' because it is a 'foreach iteration variable'
/* foreach (var name in names) {
    if (name == "David")
        name = "Sammy";
} */

// overcome limitation with for loop
/* for (int i = 0; i < names.Length; i++) {
    if (names[i] == "David")
        names[i] = "Sammy";
}

foreach (var name in names) {
    System.Console.WriteLine(name);
}
 */

/* for (int i = 1; i < 101; i++){
    if (i % 3 == 0 && i % 5 == 0) {
        System.Console.WriteLine($"{i} - FizzBuzz");
    } else if (i % 5 == 0) {
        System.Console.WriteLine($"{i} - Buzz");
    } else if (i % 3 == 0) {
        System.Console.WriteLine($"{i} - Fizz");
    } else {
        System.Console.WriteLine($"{i}");
    }
 } */

// # While statements
// allow us to iterate through a block of code with the intent that the logic inside of the code block will affect when we can stop iterating.

/* Random rand = new Random();
int current = 0;
// do-while, will always perform the code block once then run a test on the boolean expression to see if it should loop again.
// it will only go again for the expression evalutes to true.
// useful when you need to get the user's input and only exit the loop once they enter the special combination to exit
// in while loops the number of times to iterate depends on inside in the code block where for loops have outside external factors
do 
{
    current = rand.Next(1,11);
    System.Console.WriteLine(current);
} while (current != 7);
 */
// while loop
// only flow into the while loop code block if the boolean expression is true.

/* Random rand = new Random();
int current = rand.Next(1,11);

while (current >= 3) { // if the expression is false, it stops
    System.Console.WriteLine(current);
    current = rand.Next(1,11);
}
System.Console.WriteLine($"Last number: {current}"); */

// use continue to short-circuit code, or skip to the boolean expression
// continue will still keep the loop going if the boolean expression is true
// break will break the entire loop and continue after the loop regardless of the boolean expression.
/* Random r = new Random();
int current = r.Next(1,11);

do 
{
    current = r.Next(1,11);
    
    if (current >= 8) continue; // ensures that a value of 8 or above will never be written to the console.

    System.Console.WriteLine(current);
} while (current != 7); */

// # Small RPG
/* using System.Runtime.Intrinsics.Arm;

Random atkDice = new Random();

int playerHP = 10;
int monsterHP = 10;

while (playerHP > 0 && monsterHP > 0) 
{
    int attackValue = atkDice.Next(1,11);
    monsterHP -= attackValue;
    System.Console.WriteLine($"Monster was damaged and lost {attackValue} health and now has {monsterHP} health.");

    if (monsterHP <= 0)
        continue;

    attackValue = atkDice.Next(1,11);
    playerHP -= attackValue;
    System.Console.WriteLine($"Hero was damaged and lost {attackValue} health and now has {playerHP} health.");

    
}

System.Console.WriteLine((playerHP > monsterHP) ? "Hero wins!" : "Monster wins!"); 

// Microsoft way
int hero = 10;
int monster = 10;

Random dice = new Random();
do
{
    int roll = dice.Next(1,11);
    monster -= roll;
    System.Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0)
        continue;
    
    roll = dice.Next(1,11);
    hero -= roll;
    System.Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");
} while (hero > 0 && monster > 0);

System.Console.WriteLine((hero>monster) ? "Hero wins!" : "Monster wins!"); */

// While Project 1

/* bool validInput = false;
int userNumber = 0;

System.Console.WriteLine("Enter an integer value between 5 and 10");
do
{
    var input = Console.ReadLine(); // empty string if no input entered
    if (input != null) 
    {
        if(int.TryParse(input, out userNumber)) 
        {
            if (userNumber >=5 && userNumber <= 10) {
                validInput = true;
            } else {
                System.Console.WriteLine($"You entered {userNumber}. Please enter a number between 5 and 10.");
            }
        }
        else 
        {
            System.Console.WriteLine("Sorry, you entered an invalid number, please try again");
        }
    } 

} while (validInput == false);

System.Console.WriteLine($"Your input value ({userNumber}) has been accepted");




  System.Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
 bool isValid = false;
 string? userInput = "";
 string? cleanInput = "";
 do
 {
    userInput = Console.ReadLine();
    if (userInput != null) {
        cleanInput = userInput.Trim().ToLower();
        if (cleanInput == "administrator" || cleanInput == "manager" || cleanInput == "user"){
            isValid = true;
        } else {
            System.Console.WriteLine($"The role name that you entered, \"{userInput}\" is not valid. Enter your role name (Administrator, Manager, or User)");
        }
    }
    
 } while (isValid != true);
 System.Console.WriteLine($"Your input value ({userInput}) has been accepted."); 



string[] myStrings = new string[2] {"I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"};
for (int i = 0; i < myStrings.Length; i++) {
    string myString = myStrings[i];
    var periodIndex = myString.IndexOf(".");
    while (periodIndex != -1) // important lesson, the exit condition should always be defined (periodindex for this example) in the code block
    {
        System.Console.WriteLine(myString.Substring(0,periodIndex));
        myString = myString.Substring(periodIndex).Remove(0,1).TrimStart();
        periodIndex = myString.IndexOf(".");


    }
    System.Console.WriteLine($"{myString}");
    
} */

// # min and max values
/* System.Console.WriteLine("Signed integral types:"); // signed types uses bytes to represent positive and negative numbers

System.Console.WriteLine($"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
System.Console.WriteLine($"short : {short.MinValue} to {short.MaxValue}");
System.Console.WriteLine($"int :   {int.MinValue} to {int.MaxValue}"); //2.14 billion whole numbers
System.Console.WriteLine($"long:   {long.MinValue} to {long.MaxValue}");

// unsigned type uses butes to present only positive numbers.
System.Console.WriteLine("");
System.Console.WriteLine("Unsigned integral types:");

System.Console.WriteLine($"byte     : {byte.MinValue} to {byte.MaxValue}");
System.Console.WriteLine($"ushort   : {ushort.MinValue} to {ushort.MaxValue}");
System.Console.WriteLine($"unint    : {uint.MinValue} to {uint.MaxValue}");
System.Console.WriteLine($"ulong    : {ulong.MinValue} to {ulong.MaxValue}"); */

// sgined types use 1 bit to store whether the value is positive or negative.
// use decimal data when you need more precise results like financial data... uh oh lol

/* System.Console.WriteLine("");
System.Console.WriteLine("Floating point types:");
System.Console.WriteLine($"float    : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
System.Console.WriteLine($"double   : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
System.Console.WriteLine($"decimal  : {decimal.MinValue} to {decimal.MaxValue} (with ~28-29 digits of precision)"); */

// E notation == times 10 raised to the power of. 5E+2 is 500 or 5 * 10^2

// defining reference types
//int[] data = new int[3]; // returns address of int array with the 3 elements defaulting to 0.

// string is also reference type, behind the scenes System.String is created and intialized to "Hello World"
// new instances of referecnce types are created using new oeprator.
// ref types are arrays, strings and classes.

// what tdata type to use
// base on value range. ie if you need 1 to 10000, byte and sbyte are too low
// if you are absolutely sure that no negative numbers can go into the variable, use ushort a positive unbsigned itneger from 0 to 65,535
// int would be too big.
// dont need to fit perfrectly, othe rsoftware can provide insights on what else can negatively impact perofrmance, not the capacity of the variable.

// # Basic Data Types
/*
int for most whole numbers
decimal for numbers representing money
bool for true or false values
string for alphanumeric value
*/
// # data type for special situtations
/*
byte: working with encoded data that comes from other computer systems or using different character sets.
double: working with geometric or scientific purposes. double is used frequently when building games involving motion.
System.DateTime for a specific date and time value.
System.TimeSpan for a span of years / months / days / hours / minutes / seconds / milliseconds.
*/

/* int first = 2;
string second = "4";
string result = first + second;
System.Console.WriteLine(result); */

// converting string "hello" to int would r
// result in exception, must use Helper function to convert datatype instead

// widening conversion converts from one data type with less info to a data type with more info is safe
/* int myInt = 3;
System.Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
System.Console.WriteLine($"decimal: {myDecimal}"); */

/* decimal myDecimal = 3.14m;
System.Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
System.Console.WriteLine($"int: {myInt}"); */

// will i lose data with this narrowing cast?
/* decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

System.Console.WriteLine($"Decimal   : {myDecimal}");
System.Console.WriteLine($"Float     : {myFloat}"); // precision lost, notice the rounding */

// # performing data conversions
// use variable to convert
/* int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
System.Console.WriteLine(message);
 */
// use the data type's helper function parse
// tryparse is best practice
/* System.Console.WriteLine();
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
System.Console.WriteLine(sum);


// use the convert classes
int result = Convert.ToInt32(first) * Convert.ToInt32(second);
System.Console.WriteLine(result);
// use convert for fractional to whole numbers as it will convert the way you expect it too.

int value = (int)1.5m;
System.Console.WriteLine(value); // casting truncates
int value2 = Convert.ToInt32(1.5m);
System.Console.WriteLine(value2); // converting rounds up */

// # tryparse a string into an int.
/* string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
    System.Console.WriteLine($"Measurement: {result}");
}
else
{
    System.Console.WriteLine("Unable to report the measurement.");
}

if (result > 0)
    System.Console.WriteLine($"Measurement (w/ offset) {50 + result}");
 */

// # data type challenge

/* double total = 0d;
string message = "";


string[] values = {"12.3", "45", "ABC", "11", "DEF"};

for(int i = 0; i < values.Length; i++)
{
    double value;
    if (double.TryParse(values[i], out value))
    {
        total += value;
    }
    else
    {
        message += values[i];
    }
}

System.Console.WriteLine($"Message: {message}");
System.Console.WriteLine($"Total: {total}");
 */

// # Casting Challenge 2
/* int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

//int result1 = value1 / (int)value2;
// should be
int result1 = Convert.ToInt32((decimal)value1 / value2);
decimal result2 = value2 / (decimal)value3;
float result3 = value3 / (float) value1;

System.Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");
System.Console.WriteLine($"Divide value2 by value3, display the result as an decimal: {result2}");
System.Console.WriteLine($"Divide value3 by value1, display the result as an float: {result3}"); */

// # Array Sort and Reverse
/* string[] pallets = {"B14", "A11", "B12", "A13"};
System.Console.WriteLine("Sorted....");

Array.Sort(pallets); // sort alphanumerically
foreach (var pallet in pallets)
{
    System.Console.WriteLine($"-- {pallet}");
}

System.Console.WriteLine("");
System.Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach(var pallet in pallets)
{
    System.Console.WriteLine($"-- {pallet}");
} */

/* string[] pallets = { "B14", "A11", "B12", "A13" }; 
System.Console.WriteLine("");

System.Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets,0,2); // replaces the values with nulls for strings and 0s. does not remove them. count will still be 4.
// nulls are converted to empty string for presentation purposes.
// check for null
if (pallets[0] != null)
    System.Console.WriteLine($"After: {pallets[0].ToLower()}");

System.Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    System.Console.WriteLine($"-- {pallet}");
}

System.Console.WriteLine("");
Array.Resize(ref pallets, 6);
// add elements
System.Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach ( var pallet in pallets)
{
    System.Console.WriteLine($"-- {pallet}");
}

// removing elements
System.Console.WriteLine("");
Array.Resize(ref pallets, 3); // the last 3 elements are removed enough tho they have string info in them.
System.Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    System.Console.WriteLine($"-- {pallet}");
} */

// # use ToCharArray() to reverse a string
/* string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
//string result = new string(valueArray);

// creating a new comma seperated string
string result = String.Join(",", valueArray);
System.Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    System.Console.WriteLine(item);
} */

// # reverseing each single word in a sentence.

/* string pangram = "The quick brown fox jumps over the lazy dog";
var pangramWords = pangram.Split(" ");
string[] resultArray = new string[pangram.Length];

int counter = 0;
foreach (string word in pangramWords)
{
    char[] wordcharArray = word.ToCharArray();
    Array.Reverse(wordcharArray);
    resultArray[counter] = new string(wordcharArray);
    counter++;
}

string result = String.Join(" ", resultArray);

System.Console.WriteLine(result); */

/* string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderIds = orderStream.Split(",");
Array.Sort(orderIds);

foreach (string orderId in orderIds)
{
    if (orderId.Length != 4) 
    {
        System.Console.WriteLine($"{orderId}\t- Error");
    }
    else 
    {
        System.Console.WriteLine($"{orderId}");
    }
}
 */
// # What is composite formatting or string.Format() / Console.WriteLine()
// everyhting in the braces will be resolved to a value taht was passed based on position
/* string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
System.Console.WriteLine(result);

System.Console.WriteLine("{1}, {0}!", first, second);
System.Console.WriteLine("{0}, {0}, {0}!", first, second); */

// # String interpolation best practice
/* string first = "Hello";
string second = "World";
System.Console.WriteLine($"{first} {second}!");
System.Console.WriteLine($"{second} {first}!");
System.Console.WriteLine($"{first} {first} {first}!");

decimal price = 123.45m;
int discount = 50;
System.Console.WriteLine($"Price: {price:C} (Save {discount:C})"); // how to display currency format
// note depends on the country/language set on windows. ie. English (United States)

// what is culture in .net? refers to the country/region and language of the end user. a 5 chararcter culture code for en-US for usa , fr-FR french speaker in france.
// fr-CA french speaker in canada.
// affects calender, formatting for dates and numbers.
// the process of having the correct format show depending on the user's location is called localization or globalization

// number format, include commas
decimal measurement = 123456.78912m;
System.Console.WriteLine($"Measurement: {measurement:N} units"); // Measurement: 123,456.79 units

// add a number after N to display the number of decimal digits to have
System.Console.WriteLine($"Measurement (precise 4 ditgits): {measurement:N4}");

// percentages
// use a number to display the number of decimal digits after the decimal point
decimal tax = .36785m;
System.Console.WriteLine($"Tax rate: {tax:P2}");


decimal price2 = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price2- salePrice), price2);

yourDiscount += $"A discount of {((price2 - salePrice)/price2):P2}!";

System.Console.WriteLine(yourDiscount); */

/* int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

System.Console.WriteLine($"Invoice Number: {invoiceNumber}");
System.Console.WriteLine($"    Shares: {productShares:N3} Product");
System.Console.WriteLine($"    Sub Total: {subtotal:C}");
System.Console.WriteLine($"        Tax: {taxPercentage:P2}");
System.Console.WriteLine($"    Total Billed: {total:C}"); */

// string.PadLeft
// add enough spaces to the left of the string so that the string has 12 total characters. right alignment
/* string input = "Pad This";
System.Console.WriteLine(input.PadLeft(12)); // 4 spaces are added to the left
System.Console.WriteLine(input.PadRight(12)); // 4 spaces are added to the right

System.Console.WriteLine(input.PadLeft(12,'-'));
System.Console.WriteLine(input.PadRight(12,'-'));

string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";


var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);
Console.WriteLine("1234567890123456789012345678901234567890"); // used as a check
System.Console.WriteLine(formattedLine); */

/* string customerName = "Ms. Barros";

System.Console.WriteLine($"Dear {customerName},");

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

System.Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
System.Console.WriteLine();
System.Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.");

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

System.Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C2}.");

System.Console.WriteLine("Here's a quick comparision\n");

string comparisionMessage = "";

comparisionMessage += $"{currentProduct}".PadRight(20) + $"{currentReturn:P2}".PadRight(10) + $"{currentProfit:C2}\n";
comparisionMessage += $"{newProduct}".PadRight(20) + $"{newReturn:P2}".PadRight(10) + $"{newProfit:C2}";

System.Console.WriteLine(comparisionMessage); */


// # IndexOf Examples
/* string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

//System.Console.WriteLine(openingPosition);
//System.Console.WriteLine(closingPosition);

openingPosition += 1; // without this, it starts with '(' , use the value of what you can trying to skip
int length = closingPosition - openingPosition;
System.Console.WriteLine(message.Substring(openingPosition, length));

string msg = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int opnPos = msg.IndexOf(openSpan);
int closePos = msg.IndexOf(closeSpan);
opnPos += openSpan.Length;

int len = closePos - opnPos;
System.Console.WriteLine(msg.Substring(opnPos, len)); */

// when to use const? for magic values like <span>
//string message = "(What if) I am (only interested) in the last (set of parentheses)?";
/* int openingPosition = message.LastIndexOf('(');

openingPosition += 1;
int closingPosition = message.LastIndexOf(')');
int length = closingPosition - openingPosition;
System.Console.WriteLine(message.Substring(openingPosition, length)); */

/* while (true)
{
    int openingPosition = message.IndexOf('(');
    if (openingPosition == -1)
        break;
    
    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    System.Console.WriteLine(message.Substring(openingPosition, length));

    // return the remaining unprocess message:
    message = message.Substring(closingPosition + 1);
} */

/* string message = "Help (find) the {opening symbols}";
System.Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 6;
int openingPosition = message.IndexOfAny(openSymbols);
System.Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols,startPosition);
System.Console.WriteLine($"Found WITH using startPosition {startPosition}: {message.Substring(openingPosition)}"); */

/* string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// start off by looing for the open symbol
char[] openSymbols = { '[', '{', '('};

// use the closing position of previous iteration as the starting index for the next open symbol
// initialize the closingPosition variable to zero.

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1)
        break;
    
    string currentSymbol = message.Substring(openingPosition, 1); // gets [ , { , or (
    
    // find matching closing symbol
    char matchingSymbol = ' ';
    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // set the next search as the closing poistion
    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // show the substring
    int length = closingPosition - openingPosition;
    System.Console.WriteLine(message.Substring(openingPosition, length));
} */

/* string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5,20); // remove name by starting at position 5 and remvoing 20 characters
System.Console.WriteLine(updatedData);

// replace works for all instances of a method
string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
System.Console.WriteLine(message); */

/* const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

const string openSpan = "<span>";
const string closeSpan = "</span>";
int startingPosition = input.IndexOf(openSpan);
startingPosition += openSpan.Length;

int closingPosition = input.IndexOf(closeSpan);
int length = closingPosition - startingPosition;
string qty = input.Substring(startingPosition,length);

quantity = $"Quantity: {qty}";

output = input;
output = output.Replace("<div>", "");

// remove closing </div> tag
const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = output.Remove(divCloseStart, closeDiv.Length);

output = output.Replace("&trade;","&reg;");
output = "Output: " + output;


System.Console.WriteLine(quantity);
System.Console.WriteLine(output); */

// # methods
// return type, method name, parameters

/* System.Console.WriteLine("Generating Random Numbers:");
DisplayRandomNumbers();

void DisplayRandomNumbers()
{
    Random random = new Random();

    for (int i = 0; i < 5; i++)
    {
        System.Console.Write($"{random.Next(1,100)} ");
    }

    System.Console.WriteLine();
} */


/* using System;

int[] times = {800,1200,1600,2000};
int diff = 0;

System.Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Current Medicine Schedule:");
DisplayTimes();

System.Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());



if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    System.Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    AdjustTimes();
}
else 
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    AdjustTimes();
}

System.Console.WriteLine("New Medicine Schedule");
DisplayTimes();
 */

/*
void DisplayTimes()
{
   Format and display medicine time 
   foreach (int val in times)
   {
       string time = val.ToString();
       int len = time.Length;

       if (len >= 3)
       {
           time = time.Insert(len-2,":");
       }
       else if (len == 2)
       {
           time = time.Insert(0,"0:");
       }
       else 
       {
           time = time.Insert(0,"0:0");
       }

       System.Console.Write($"{time} ");
   }

   System.Console.WriteLine();
}

void AdjustTimes()
{
   /* Adjust the times by adding the difference, keeping the value within 24 hours 
   for (int i = 0; i < times.Length; i++)
   {
       times[i] = ((times[i] + diff)) % 2400;
   }
}
*/

/*
pseudo-code
if ipAddress consist of 4 numbers and
if each ipaddress number has no leading zeroes and
if each ipadress number is in range 0 - 255

then ipaddress is valid
else ipaddress is invalid

*/

/* string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
string [] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;



foreach (string ip in ipv4Input)
{
    // if 255...255 for example, would remove the empty entrys between the dots, only having 255 and 255 in the list
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

    ValidateLength();
    ValidateZeroes();
    ValidateRange();

    if (validLength && validZeroes && validRange)
    {
        System.Console.WriteLine($"{ip} is a valid IPv4 address");
    }
    else
    {
        System.Console.WriteLine($"{ip} is an invalid IPv4 address");
    }


}


void ValidateLength() 
{
    validLength = address.Length == 4;

}
void ValidateZeroes() 
{

    foreach (string number in address)
    {
        if (number.Length > 1 && number.StartsWith("0"))
        {
            validZeroes = false; 
            return; // return after first invalid zero is found.
        }
    }

    validZeroes = true; // if all zeroes valid, returns true
    // bug, 2 ways to fix, either set validZeroes to true in the beginning 
    // OR perferred: use return, to have it go back to main code loop b4 it sets itself to true accidently
}


void ValidateRange() 
{
    //string[] address = ipv4Input.Split(".");

    foreach (string number in address)
    {
        int value = int.Parse(number);
        if (value < 0 || value > 255)
        {
            validRange = false;
            return;
        }
    }
    validRange = true;
}


 */

// convert the following to method tellFortune
/* 
string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

System.Console.WriteLine("A fortune teller whispers the following words:");
tellFortune();
tellFortune();
tellFortune();
tellFortune();
tellFortune();


void tellFortune()
{
    Random random = new Random();
    int luck = random.Next(100);

    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
    for (int i = 0; i < 4; i++)
    {
        System.Console.Write($"{text[i]} {fortune[i]} ");
    }
    System.Console.WriteLine();
} */

// # methods with parameters this time
/* int[] schedule = {800,1200,1600,2000};
DisplayAdjustedTimes(schedule, -6, 6);

void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
{
    int diff = 0;
    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12) // is it between -12 and 12?
    {
        System.Console.WriteLine("Invalid GMT");
    }
    else if  (newGMT <= 0 && currentGMT <= 0 || newGMT  >= 0 && currentGMT >= 0 )// if both are positive or both are negative
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    } else
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }

    for (int i = 0; i < times.Length; i++)
    {
        int newTime = ((times[i] + diff)) % 2400;
        System.Console.WriteLine($"{times[i]} -> {newTime}");
    }
} */

//using System.Net.NetworkInformation;

/* string[] students = {"Jenna", "Harry", "Ron", "Voldamort"};

DisplayStudents(students);
DisplayStudents(new string[] {"Robert","Vanya"});

void DisplayStudents(string[] students) { // the global var students was not used, students the parameter takes precendence over students the global var.
    foreach (string student in students){
        System.Console.Write($"{student}, ");
    }
    System.Console.WriteLine();
}
// pi is a good global var as it is used in both methods and did not change btw them
double pi = 3.14159;

PrintCircleInfo(12); // methods are pascal case or FirstLetterIsCapped
PrintCircleInfo(24);
//double circumference = 2 * pi * radius; // pi and radius only exist in the scope of PrintCircleArea



void PrintCircleArea(int radius)
{
    //double pi = 3.14159;
    double area = pi * (radius * radius);
    System.Console.WriteLine($"Area = {area}");
}
void PrintCircleCircumference(int radius)
{
    //double pi = 3.14159;
    double circumference = 2 * pi * radius;
    System.Console.WriteLine($"Circumference = {circumference}");
}
void PrintCircleInfo(int radius)
{
    System.Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
}
 */
// # How to Use value and reference type parameters
// Value types: int, bool, float, double, char contain values
// reference types: string, array, objects Like instances of Rnadom, store an address where their value is being stored.

// test pass by value
/* int a = 3;
int b = 4;
int c = 0;

Multiply(a, b, c);
// c the global variable retains it's original valve therefore it is still 0.
System.Console.WriteLine($"global statement: {a} x {b} = {c}");

// ints are value types, so their values are copied to the a,b,c parameters when passed into a method
// this prevents the original global a,b,c from being modified.
void Multiply(int a, int b, int c)
{
    c = a*b;
    System.Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
} */

// test pass by reference
// due to reference, the actual values are used and therefore can be changed in the method
/* int[] array = {1,2,3,4,5};
PrintArray(array);
Clear(array);
PrintArray(array);

void PrintArray(int[] array) {
    foreach (int a in array)
    {
        System.Console.Write($"{a} ");
    }
    System.Console.WriteLine();
}

void Clear(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 0;
    }
} */

// strings are immutable
/* string status = "Healthy";

System.Console.WriteLine($"Start: {status}");
SetHealth(status, false);
System.Console.WriteLine($"End: {status}");

void SetHealth(string status, bool isHealthy)
{
    // due to status being a parameter, a new variable is made only in this scope then lost.
    status = (isHealthy ? "Healthly" : "Unhealthy");
    System.Console.WriteLine($"Middle: {status}");
} */

// string fix, make it global
/* string status = "Healthy";

System.Console.WriteLine($"Start: {status}");
SetHealth(false);
System.Console.WriteLine($"End: {status}");

void SetHealth(bool isHealthy)
{
    // status is global variable, and therefore will be replaced with Healthy or unhealthy.
    status = (isHealthy ? "Healthly" : "Unhealthy");
    System.Console.WriteLine($"Middle: {status}");
} */

// methods with optional parameters and named parameters
/* string[] guestList = {"Jonny", "Nadia", "Noor", "Jonte"};
string[] rsvps = new string[10];
int count = 0;

// name is not optional paramter and thus all calls must require a name
RSVP("Jonny");
RSVP("Nadia",2,"Nuts");
// named arguments
// in poistional order
RSVP(name: "Linh",partySize: 2, inviteOnly: false);
// named argument
// 1 is in correct order, the rest do not have to be
// the one that needs to be in correct order does not have a name, so it needs to match the poisition.
RSVP("Tony",allergies: "Jackfruit", inviteOnly: true);
RSVP("Noor",4, inviteOnly: false);
RSVP("Jonte",2,"Stone fruit",false);
ShowRSVPs();

// if the parameter as a default value assigned, then it becomes an optional parameter
void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
{
    if (inviteOnly)
    {
        // search guestList b4 adding rsvp
        bool found = false;
        foreach (string guest in guestList)
        {
            if (guest.Equals(name))
            {
                found = true;
                break; // break the loop, guard cluase
            }
        }
        if (!found)
        {
            System.Console.WriteLine($"Sorry, {name} is not on the guest list");
            return; // terminate method, never add to rsvp list
        }
    }

    
    // adds to rsvp list
    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies {allergies}";
    count++;
}

void ShowRSVPs()
{
    System.Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        System.Console.WriteLine(rsvps[i]);
    }
}
 */

/* string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    // display internal emails
    DisplayEmail(corporate[i,0], corporate[i,1]);
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    // display external emails
    DisplayEmail(firstName: external[i,0], lastName: external[i,1], domain: externalDomain);
}

void DisplayEmail(string firstName, string lastName, string domain = "contoso.com")
{
    string emailName = firstName.Substring(0,2) + lastName;
    emailName = emailName.ToLower();
    System.Console.WriteLine($"{emailName}@{domain}");
}
 */


// # Methods that return a type
/* double total = 0;
double minimumSpend = 30.00;

double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

if (TotalMeetsMinimum())
{
    total -= 5.00;
}

System.Console.WriteLine($"Total : ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{
    // calculate the discounted price of the item
    return items[itemIndex] * (1 - discounts[itemIndex]);
}

bool TotalMeetsMinimum()
{
    return total >= minimumSpend;

}

string FormatDecimal(double input)
{
    // format the double so only 2 decimal places are displayed
    return input.ToString().Substring(0,5);
}

 */

/* double usd = 23.73;
int vnd = UsdToVnd(usd);

System.Console.WriteLine($"${usd} USD = ${vnd} VND");
System.Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

int UsdToVnd(double usd)
{
    int rate = 23500;
    return (int) (rate * usd);
}

double VndToUsd(int vnd)
{
    double rate = 23500;
    return vnd/rate;
} */



/* string input = "snake";

System.Console.WriteLine(input);
System.Console.WriteLine(ReverseWord(input));
System.Console.WriteLine();
string input2 = "There are snakes at the zoo";
System.Console.WriteLine(input2);
System.Console.WriteLine(ReverseSentence(input2));

string ReverseWord(string word)
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
        result += word[i];
    }


    return result;
}

string ReverseSentence(string input)
{
    string result = "";
    string[] words = input.Split(" ");
    foreach(string word in words){
        result += ReverseWord(word) + " ";
    }


    return result.Trim();
} */

// # palindrome interview question
/* string[] words = {"racecar", "talented", "deified", "tent", "tenet"};

System.Console.WriteLine("Is it a palindrome?");
foreach (string word in words)
{
    System.Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word)
{
    int start = 0;
    int end = word.Length - 1;

    // end the loop if the middle of the word is reached
    while (start < end)
    {
        if (word[start] != word[end])
        {
            return false;
        }
        start++;
        end--;
    }



    return true;
} */


// # Find coins to make change


//int target = 60;
//int[] coins = new int[] {5,5,50,25,25,10,5};
//int[] result = TwoCoins(coins, target);


/* int target = 30;
int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
int[,] result = TwoCoinsV2(coins, target);

//if (result.Length == 0)
//{
//    System.Console.WriteLine("No two coins make change");
//}
//else
//{
//    System.Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
//}

if (result.Length == 0){
    System.Console.WriteLine("No two coins make change");
} 
else {
    System.Console.WriteLine("Change found at poistions:");
    for (int i = 0; i < result.GetLength(0); i++){
        // hit default -1? stop here
        if (result[i,0] == -1)
        {
            break;
        }
        System.Console.WriteLine($"{result[i,0]},{result[i,1]}");
    }
}

int[] TwoCoins(int[] coins, int target)
{
    for (int curr = 0; curr < coins.Length; curr++)
    {
        for (int next = curr + 1; next < coins.Length; next++)
        {
            // do the sum of the two coins add up to the target?
            // immediately returns the first instance, any other is disregarded
            if (coins[curr] + coins[next] == target)
            {
                return new int[] { curr, next };
            }
        }
    }

    return new int[0]; // if none found, return empty array
}

int[,] TwoCoinsV2(int[] coins, int target)
{
    int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
    int count = 0;

    for (int curr = 0; curr < coins.Length; curr++)
    {
        for (int next = curr + 1; next < coins.Length; next++)
        {
            if (coins[curr] + coins[next] == target)
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;
            }
        }

        // based on the result variable above, we can only have 5 array elements, thus return when full
        if (count == result.GetLength(0))
        {
            return result;
        }
    }

    //if (count == 0)
    //{
    //    return new int[0,0];
    //}
    //return result;
    return (count == 0) ? new int[0, 0] : result;
} */

// Dice mini-game challenge

/* Random random = new Random();
string? readResult;

System.Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;
    while (play)
    {
        var target = random.Next(1,6);
        var roll = random.Next(1,7);

        System.Console.WriteLine($"Roll a number greater than {target} to win!");
        System.Console.WriteLine($"You rolled a {roll}");
        System.Console.WriteLine(WinOrLose(target,roll));
        System.Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    string userInput = "";
    readResult = Console.ReadLine();
    if (readResult != null){
        userInput = readResult.ToLower().Trim();
    }
    return userInput == "y";
}

string WinOrLose(int target, int roll){
    if (roll > target)
        return "You Win!";
    else
        return "You Lose!";
} */

/*

string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};
 */
/* Design Specs for petting zoo
- There will be three visiting schools
    - School A has six visiting groups (the default number)
    - School B has three visiting groups
    - School C has two visiting groups

- For each visiting school, perform the following tasks
    - Randomize the animals
    - Assign the animals to the correct number of groups
    - Print the school name
    - Print the animal groups
*/

// Petting zoo pseudocode

/* PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);

// since each school just has a different name and number of groups, we can create a method with these parameters
void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RandomizeAnimals();
    string[,] group = AssignGroup(groups);
    System.Console.WriteLine(schoolName);
    PrintGroup(group);
}

void RandomizeAnimals()
{
    Random random = new Random();


    // shuffle entire deck
    for (int i = 0; i < pettingZoo.Length; i++)
    {
        //int r = random.Next(pettingZoo.Length); // some elmenets get swapped multiple times or not at all
        int r = random.Next(i, pettingZoo.Length); // excludes swapping values less than i since its already been swapped.

        // swap
        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;
    }

}

// required parameters are needed first b4 assigning optional parameters
string[,] AssignGroup(int groups = 6)
{
    string[,] result = new string[groups, pettingZoo.Length / groups];
    // each group

    int start = 0;

    for (int i = 0; i < groups; i++)
    {
        // number of animals each group should contain
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = pettingZoo[start++];
        }
    }

    return result;

}

void PrintGroup(string[,] group)
{
    // get number of rows
    for (int i = 0; i < group.GetLength(0); i++)
    {
        System.Console.Write($"Group {i + 1}: ");
        // get number of columns
        for (int j = 0; j < group.GetLength(1); j++)
        {
            System.Console.Write($"{group[i, j]}  ");
        }
        System.Console.WriteLine();
    }
} */

// used  to test
//foreach (string animal in pettingZoo)
//{
//    System.Console.WriteLine(animal);
//}

/*
This code uses a names array and corresponding methods to display greeting messages
*/

/* string[] names = new string[] {"Sophia", "Andrew", "AllGreetings"};
string messageText = "";

foreach (string name in names)
{
    if (name == "Sophia")
        messageText = SophiaMessage();
    else if (name == "Andrew")
        messageText = AndrewMessage();
    else if (name == "AllGreetings")
        messageText = SophiaMessage() + "\n\r" + AndrewMessage();

    System.Console.WriteLine(messageText + "\n\r");
}

bool pauseCode = true;
while (pauseCode == true);

static string SophiaMessage()
{
    return "Hello, my name is Sophia.";
}

static string AndrewMessage()
{
    return "Hi, my name is Andrew. Good to meet you.";
}
 */

/* int productCount = 2000;
string[,] products = new string[productCount, 2];

// # debugger practice
LoadProducts(products, productCount);

for (int i = 0; i < productCount; i++)
{
    string result;
    result = Process1(products, i);

    if (result != "obsolete")
    {
        result = Process2(products, i);
    }
}

bool pauseCode = true;
while (pauseCode == true);

static void LoadProducts(string[,] products, int productCount)
{
    Random rand = new Random();

    for (int i = 0; i < productCount; i++)
    {
        int num1 = rand.Next(1,10000) + 10000;
        int num2 = rand.Next(1,101);

        string prodID = num1.ToString();

        if (num2 < 91)
        {
            products[i,1] = "existing";
        }
        else if (num2 == 91)
        {
            products[i,1] = "new";
            prodID = prodID + "-n";
        }
        else 
        {
            products[i,1] = "obsolete";
            prodID = prodID + "-0";
        }

        products[i,0] = prodID;

    }
}

static string Process1(string[,] products, int item)
{
    System.Console.WriteLine($"Process1 message - working on {products[item,1]} product");

    return products[item,1];
}

static string Process2(string[,] products, int item)
{
    System.Console.WriteLine($"Process2 message - working on product ID #: {products[item,0]}");
    if (products[item,1] == "new")
        Process3(products, item);

    return "continue";
}

static void Process3(string[,] products, int item)
{
    System.Console.WriteLine($"Process3 message - processing product information for 'new' product");
} */

/* string? readResult;
int startIndex = 0;
bool goodEntry = false;

int[] numbers = {1,2,3,4,5};

// display the array to the console.
Console.Clear();
Console.Write("\n\rThe 'numbers' array contains: {");
foreach(int number in numbers)
{
    System.Console.Write($"{number} ");
}

// sum the array elements starting with the user's starting element number
System.Console.WriteLine($"}}\n\r\n\rTo sum values 'n' through 5, enter a value for 'n':");
while (goodEntry == false)
{
    readResult = Console.ReadLine();
    goodEntry = int.TryParse(readResult, out startIndex);

    if (startIndex > 5)
    {
        goodEntry = false;
        System.Console.WriteLine("\n\rEnter an integer value between 1 and 5");
    }
}

// display the sum and then pause
System.Console.WriteLine($"\n\rThe sum of numbers {startIndex} through {numbers.Length} is: {SumValues(numbers, startIndex-1)}");

System.Console.WriteLine("press enter to exit");
readResult = Console.ReadLine();

// this method returns the sum of elements n thr 5
static int SumValues(int[] numbers, int n)
{
    int sum = 0;
    for (int i = n; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return sum;
} */

/* bool exit = false;
var rand = new Random();
int num1 = 5;
int num2 = 5;

do
{
    num1 = rand.Next(1,11);
    num2 = num1 + rand.Next(1,51);
} while (exit == false); */

// debugger challenge
// code should update the value of x then print the updated value but does not
/* int x = 5;

x = ChangeValue(x);

System.Console.WriteLine(x);
var read = Console.ReadLine();

int ChangeValue(int value)
{
    value = 10;
    return value;
} */

// Common exceptions Compiler-generated exceptions

// ArrayTypeMismatchException 
// storing an element type that does not belong to the array's type
/* string[] names = {"Dog", "Cat", "Fish"};
Object[] objs = (Object[])names;

Object obj = (Object)13;
objs[2] = obj; */

// DivideByZeroException
/* int number1 = 3000;
int number2 = 0;
System.Console.WriteLine(number1/ number2); */

// FormatException
// can occuring when converting from one datatype to another
/* int valueEntered;
string userValue = "two";
valueEntered = int.Parse(userValue); */

// IndexOutOfRangeException
/* int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };
int[] values2 = new int[6];

values2[values1.Length - 1] = values1[values1.Length - 1]; // IndexOutOfRangeException occurs */

// InvalidCastException
// An exception of type InvalidCastException is thrown when attempting an invalid casting or explicit conversion

/* object obj = "This is a string";
int num = (int)obj; */

// NullReferenceException
/* int[] values = null;
for (int i = 0; i <= 9; i++)
    values[i] = i * 2; */

/* string? lowCaseString = null;
Console.WriteLine(lowCaseString.ToUpper()); */

// OverflowException
// assign a value outside the range of the target data type
/* decimal x = 400;
byte i;

i = (byte)x; // overflowexception occurs
System.Console.WriteLine(i); */

/* double float1 = 3000.0;
double float2 = 0.0;
int number1 = 3000;
int number2 = 0;

try
{
    System.Console.WriteLine(float1 / float2);
    System.Console.WriteLine(number1 / number2);
} 
catch 
{
    System.Console.WriteLine("An exception has been caught");
}

System.Console.WriteLine("Exit Program"); */

/* try
{
    Process1();
}
catch
{
    System.Console.WriteLine("An exception has occurred");
}

static void Process1()
{
    WriteMessage();
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    System.Console.WriteLine(float1 / float2);
    System.Console.WriteLine(number1 / number2);
} */

/* try
{
    Process1();
}
catch
{
    System.Console.WriteLine("An exception has occurred");
}

System.Console.WriteLine("Exit Program");

static void Process1()
{
    try 
    {
        WriteMessage();
    } 
    catch (DivideByZeroException ex)
    {
        System.Console.WriteLine($"Exception caught in Process1: {ex.Message}");
    }
    
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;
    byte smallNumber;

    try 
    {
        System.Console.WriteLine(float1 / float2);
        System.Console.WriteLine(number1 / number2);
    } 
    catch (Exception ex)
    {
        System.Console.WriteLine("Caught in writemessage");
    }
    

    // checked will ensure that converting from one data type to another integral data type only successed if the source value
    // is within the range of the destination type. otherwise so bits would be lost in the uncheckted context, but it would succeed but still lose data.
    checked
    {
        smallNumber = (byte)number1;
    }
    

} */

// continue from Catch multiple exceptions in a code block
// https://learn.microsoft.com/en-us/training/modules/implement-exception-handling-c-sharp/7-exercise-catch-explicit-exception-types

// catch separate exceptions
// inputValues is used to store numeric values entered by a user
/* string[] inputValues = new string[] {"three", "9999999999", "0", "2"};
foreach (string inputValue in inputValues)
{
    int numValue = 0;
    try
    {
        numValue = int.Parse(inputValue);
    }
    catch (FormatException)
    {
        System.Console.WriteLine("Invalid readResult. Please enter a valid number.");
    }
    catch (OverflowException)
    {
        System.Console.WriteLine("The number you entered is too large or too small.");
    }
    catch (Exception ex)
    {
        System.Console.WriteLine(ex.Message);
    }
} */

/* checked
{
    try
    {
        int num1 = int.MaxValue;
        int num2 = int.MaxValue;
        DateTime now = DateTime.Now;
        now.ToString(:"yyy")
        int result = num1 + num2;
        System.Console.WriteLine("Result: " + result);

        if (num1 != num2)
        
    }
    catch (OverflowException ex)
    {
        throw ex;
        System.Console.WriteLine("Error: the number is too large to be represented as an integer. " + ex.Message);
    }
}


try
{
    string? str = null;
    int length = str.Length;
    System.Console.WriteLine("String Length: " + length);
}
catch (NullReferenceException ex)
{
    System.Console.WriteLine("Error: the reference is null. " + ex.Message);
}

try
{
    int[] numbers = new int[5];
    numbers[5] = 10;
    System.Console.WriteLine("Number at index 5: " + numbers[5]);
}
catch (IndexOutOfRangeException ex)
{
    System.Console.WriteLine("Error: Index out of range. " + ex.Message);
}


try
{
    int num3 = 10;
    int num4 = 0;
    int result2 = num3 / num4;
    System.Console.WriteLine("Result: " + result2);
}

catch (DivideByZeroException ex)
{
    throw;
    System.Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
}

System.Console.WriteLine("Exiting Program");

int[] array = new int[3];
array.Len
double employeeLevel = 100.00;
switch (employeeLevel) 
{
    case 100d:
    case 200d:
        title = "Senior Associate";
        break;
    case 300d:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;

} */

Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Red;

Console.Title = "Brother";

System.Console.WriteLine("Hello Vedal");
var wait = Console.ReadLine();

Console.Beep();

var wait2 = Console.ReadLine();

Console.Beep(440,1000);