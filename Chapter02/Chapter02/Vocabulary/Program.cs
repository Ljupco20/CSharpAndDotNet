using System.Reflection;


//#error version
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine();
System.Data.DataSet ds;
HttpClient client;


Assembly? assembly = Assembly.GetEntryAssembly();
if (assembly == null) return;
// loop through the assemblies that this app references
foreach (AssemblyName name in assembly.GetReferencedAssemblies())
{
    // load the assembly so we can read its details

Assembly a = Assembly.Load(name);
    // declare a variable to count the number of methods
    int methodCount = 0;
    // loop through all the types in the assembly
    foreach (TypeInfo t in a.DefinedTypes)
    {
        // add up the counts of methods
        methodCount += t.GetMethods().Count();
    }
    // output the count of types and their methods
    Console.WriteLine(
    "{0:N0} types with {1:N0} methods in {2} assembly.",
    arg0: a.DefinedTypes.Count(),
    arg1: methodCount, arg2: name.Name);
}

//For text, a single letter, such as an A, is stored as a char type.

char letter = 'A';
char digit = '1';
char symbol = '$';
char userChoice = Console.ReadKey().KeyChar;

Console.WriteLine($"{nameof(letter)} : {letter} \r\n " +
    $"{nameof(digit)} : {digit} \r\n " +
    $"{nameof(symbol)} : {symbol} \r\n " +
    $"{nameof(userChoice)} : {userChoice} \r\n " 

    );

//For text, multiple letters, such as Bob, are stored as a string type and are assigned using double quotes around the literal value

string firstName = "Bob"; // assigning literal strings
string lastName = "Smith";
string phoneNumber = "(215) 555-4256";

Console.WriteLine($"{nameof(firstName)} : {firstName} \r\n " +
    $"{nameof(lastName)} : {lastName} \r\n " +
    $"{nameof(phoneNumber)} : {phoneNumber} \r\n "
    );


string fullNameWithTabSeparator = "Bob\tSmith";
Console.WriteLine(fullNameWithTabSeparator);

string filePath = "C:\\televisions\\sony\\bravia.txt";
string filePath2 = @"C:\televisions\sony\bravia.txt";

Console.WriteLine($"{filePath}" +
    $" {filePath2}");