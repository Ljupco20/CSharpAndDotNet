
/*
 
Exercise 1 – Test your knowledge 

1. What statement can you type in a C# file to discover the compiler and language version?
  --
Console.Write(typeof(string).Assembly.ImageRuntimeVersion);
#error version
csc

2. What are the two types of comments in C#?
// and /* * /

3. What is the difference between a verbatim string and an interpolated string?
@verbatim
$interpolated
• Verbatim string: A literal string prefixed with @ to disable escape characters so that a
backslash is a backslash. It also allows the string value to span multiple lines because
the white space characters are treated as themselves instead of instructions to the
compiler.
• Interpolated string: A literal string prefixed with $ to enable embedded formatted
variables.

4. Why should you be careful when using float and double values?
Double is more precise than float and can store 64 bits, double of the number of bits float can store.

5. How can you determine how many bytes a type like double uses in memory?
sizeof (type)

6. When should you use the var keyword?
- when working with anonymous types
- var requires less typing. It also is shorter and easier to read, for instance, than Dictionary<int,IList>.
- var requires less code changes if the return type of a method call changes. You only have to change the method declaration, not every place it’s used.
- var encourages you to use a descriptive name for the variable. This means the instance, not the type name. 
-
7. What is the newest way to create an instance of a class like XmlDocument?
8. Why should you be careful when using the dynamic type?
9. How do you right-align a format string?
10. What character separates arguments for a console application?

 */

/*
 Exercise 2 – Test your knowledge of number types
What type would you choose for the following "numbers"?
1. A person's telephone number
2. A person's height
3. A person's age
4. A person's salary
5. A book's ISBN
6. A book's price
7. A book's shipping weight
8. A country's population
9. The number of stars in the universe
10. The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business)
 
 */

//Exercise 3 – Practice number sizes and ranges

using System.Runtime.InteropServices;




var types = new[] { typeof(sbyte), typeof(byte), typeof(short), typeof(ushort), typeof(int), typeof(uint), typeof(long), typeof(ulong), typeof(float), typeof(double), typeof(decimal) };

Console.WriteLine("------------------------------------------------------------------------------------------");
Console.WriteLine("| {0, -10} | {1, 7} | {2, 30} | {3, 30} |", "Type", "Byte(s)", "Min", "Max");
Console.WriteLine("|------------|---------|--------------------------------|--------------------------------|");
foreach (var type in types)
{
    Console.WriteLine(
       "| {0, -10} | {1, 7} | {2, 30} | {3, 30} |",
       type.Name,
       Marshal.SizeOf(Activator.CreateInstance(type)),
       type.GetField("MinValue").GetValue(null),
       type.GetField("MaxValue").GetValue(null));
}