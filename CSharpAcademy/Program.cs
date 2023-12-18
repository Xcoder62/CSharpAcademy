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