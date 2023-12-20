// See https://aka.ms/new-console-template for more information
// # Csharp-write-first
//Console.WriteLine("This is the first line.");
//Console.Write("This is the second line.");

// # csharp-literals-variables
// char
Console.WriteLine('b');
// int
Console.WriteLine(123);
// float
Console.WriteLine(0.25F);
// double
Console.WriteLine(2.625);
//decimal
Console.WriteLine(12.39816m); // m or M literal suffix results in decimal data type
//boolean 
Console.WriteLine(true);
Console.WriteLine(false);

// strings
string firstName;
firstName = "Bob";
//"bob" = firstName; The left-hand side of an assignment must be a variable, property or indexer
Console.WriteLine(firstName);
firstName = "Avatar";
Console.WriteLine(firstName);
firstName = "Kitara";
Console.WriteLine(firstName);
firstName = "Oppa";
Console.WriteLine(firstName);

string lastName = "Eric";
Console.WriteLine(lastName);

var message = "Hello World"; // locked in string as data type, cant be changed
//message = 10.703m; // can not implicitly convert type decimal to string

string userName = "Bob";
int numOfMessages = 3;
double degrees = 34.4;

Console.Write(String.Format("Hello, {0}! You have {1} messages in your inbox. The temperature is {2} celsius",userName,numOfMessages,degrees));

Console.WriteLine(32.20m);

// # Format literal strings in C#
Console.WriteLine("Hello\nWorld");
Console.WriteLine("Hello\tWorld");
Console.WriteLine("Hello \"World\"!");
Console.WriteLine("c:\\source\\repos");

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice 1021\t\tComplete!");
Console.WriteLine("Invoice 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.WriteLine(@"c:\invoices");

Console.WriteLine(@"    c:\source\repos
        (this is where your code goes)");

// unicode
// windows command prompt will display ? instead of the unicode character
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

Console.WriteLine("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");

// exercise-string-concatenation
string fName = "Bob";
string greeting = "Hello";
string myMessage = greeting + " " + fName + "!";
Console.WriteLine(greeting + " " + fName + "!");

// string interpolation
string hisMessage = $"{greeting} {fName}!";

string newName = "Sandy";
string herMessage = $"Hello {newName}!";
Console.WriteLine(herMessage);

int version = 11;
string updootText = "Update to Windows";
string nMessage = $"{updootText} {version}";
//Console.WriteLine(nMessage); // remove the intermediate variable above by doing the interpolation in writeline
Console.WriteLine($"{updootText} {version}");

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

// Challenge: Format and display instructions
string project = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043e\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($"View English output:\n\tc:\\Exercise\\{project}\\data.txt" + "\n");
Console.WriteLine($"{russianMessage}:\n\tc:\\Exercise\\{project}\ru-RU\\data.txt");

// microsoft solution
string pName = "ACME";
string englishLocation = $@"c:\Exercise\{pName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");
Console.WriteLine(englishLocation + @"\");

// # exercise add numbers
int fNumber = 12;
int sNumber = 7;
Console.WriteLine(fNumber + sNumber);

Console.WriteLine(pName + " sold " + sNumber + " widgets"); // string + int, int is implicitly converted to string
Console.WriteLine(pName + " sold " + sNumber + 7 + " widgets."); // since int as implcitly converted to string, 77 is produced. instead of adding both
Console.WriteLine(pName + " sold " + (sNumber + 7) + " widgets."); // pararthesist tells compiler to add 2 ints together, getting 14.

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"decimal quotient: {decimalQuotient}");
decimal incorrectQuotient = 7 / 5;
Console.WriteLine($"incorrect quotient: {incorrectQuotient}"); // the left side must be decimal and at least one of the numbers on the right need to be decimal

// three methods of parenthesis operator, method invocation, order of oepratiosn and now casting
int first = 7;
int second = 5;
decimal newQuotient = (decimal)first / (decimal)second;
Console.WriteLine(newQuotient);

// modulus is also useful for showing feedback to end user after every 100 data records have been processed
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5: {7%5}");

int val1 = 3 + 4 * 5;
int val2 = (3 + 4) * 5; //pedemas
Console.WriteLine(val1);
Console.WriteLine(val2);

int val3 = 1;
val3 = val3 + 1;
Console.WriteLine("First Increment: " + val3);
val3 += 1;
Console.WriteLine("2nd increment: " + val3);
val3++;
Console.WriteLine("3rd increment: " + val3);
val3 = val3 - 1;
Console.WriteLine("First decrement: " + val3);
val3 -= 1;
Console.WriteLine("Second decrement: " + val3);
val3--;
Console.WriteLine("Third decrement: " + val3);

int val4 = 1;
val4++;
Console.WriteLine("First: " + val4);
Console.WriteLine($"Second: {val4++}"); // should recieve val4 (2), display it, then increment after it is used in writeline
Console.WriteLine("Third: " + val4);
Console.WriteLine("Fourth: " + (++val4)); // increment then display

// convert fahrenheit to celsius
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32) * (5.0m / 9.0m);
Console.WriteLine($"The temperature is {celsius} Celsius.");

// # Grade Book Project
// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;


decimal sophiaScore = (decimal)sophiaSum / currentAssignments;
decimal nicolasScore = (decimal)nicolasSum / currentAssignments;
decimal zahirahScore = (decimal)zahirahSum / currentAssignments;
decimal jeongScore = (decimal)jeongSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA"); // tabs use 4 char intervals, so if string of 5 char is folowed by tab, the next tab  stop will be 8th char location.
Console.WriteLine("Zicolas:\t" + nicolasScore + "\tB");// b4 score 12
Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA"); //b4 score 6 \t 8 \t 12



// # GPA Guided Projects
string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

//Console.WriteLine($"{totalGradePoints} {totalCreditHours}");

decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

int leadingDigit = (int)gradePointAverage;

int firstDigit = (int)(gradePointAverage * 10) % 10;
//int firstDigit = (int) (2.994573 * 10) % 10; // move 1 decimal place over, use 100 for 2 decimal places
//int firstDigit = 29 % 10;
//int firstDigit = 9;
int secondDigit = (int)(gradePointAverage * 100) % 10;


Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");
Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t\t{course5Grade}\t\t{course5Credit}");
Console.WriteLine($"\nFinal GPA:\t\t\t{leadingDigit}.{firstDigit}{secondDigit}");