using static System.Console;

int numberOfApples = 12;
decimal pricePerApple = 0.35M;
WriteLine(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

string formatted = string.Format(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
    );

WriteToFile(formatted); // writes the string into a file

void WriteToFile(string formatted)
{
   WriteLine(
        format: "The next text was writen in the file: \r\n {0}",
        arg0: formatted);
}
/*
string firstname = "Omar";
string lastname = "Rudberg";
string fullname = $"{firstname} {lastname}";


Console.WriteLine(fullname);
*/
string applesText = "Apples";
int applesCount = 1234;

string bananasText = "Bananas";
int bananasCount = 56789;

WriteLine(
    format: "{0,-10} {1,6:N0}",
    arg0: "Name",
    arg1: "Count");

WriteLine(
    format: "{0,-10} {1,6:N0}",
    arg0: applesText,
    arg1: applesCount);

WriteLine(
format: "{0,-10} {1,6:N0}",
arg0: bananasText,
arg1: bananasCount);

Write("Type your first name and press ENTER: ");
string? firstName = Console.ReadLine();

Write("Type your first name and press ENTER: ");
string? age = Console.ReadLine();

WriteLine(
$"Hello {firstName}, you look good for {age}.");


Write("Press any key combination:");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
    arg0: key.Key,
    arg1: key.KeyChar,
    arg2: key.Modifiers); ;