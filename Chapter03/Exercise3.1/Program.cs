using static System.Console;

WriteLine("--------------------- 1 ------------------------");
int myNum = 12;

try
{
    WriteLine($"{myNum} / {0} = {myNum / 0}");
}
catch (Exception ex)
{
    WriteLine(ex.ToString());
}

WriteLine("--------------------- 2 ------------------------");

double myDouble = 12.0;

try
{
    WriteLine($"{myDouble} / {0} = {myDouble / 0}");
}
catch (Exception ex)
{
    WriteLine(ex.ToString());
}

WriteLine("--------------------- 3 ------------------------");

int intOverflow = int.MaxValue;

WriteLine($"Min value of int: {int.MinValue}");
WriteLine($"Max value of int: {int.MaxValue}");
WriteLine($"Overflow of int by one: {++intOverflow}");

WriteLine("--------------------- 4 ------------------------");

int y = 5;
int x = y++;
WriteLine($"y is {y}");
WriteLine($"x = y++ is {x}");

int c = 5;
int d = ++c;
WriteLine($"c is {c}");
WriteLine($"d = ++c is {d}");

WriteLine("--------------------- 5 ------------------------");

for (int i = 0; i <=5; i++)
{
    WriteLine(i);
    if (i ==2)
    {

        break;
    }
    WriteLine("End of iteration");
}

for (int i = 0; i <=5; i++)
{
    WriteLine(i);
    if (i == 2)
    {

        continue;
    }
    WriteLine("End of iteration");
}

for (int i = 0; i <=5; i++)
{
    WriteLine(i);
    if (i == 2)
    {
     
        return;
    }
    WriteLine("End of iteration");
}

WriteLine("--------------------- 6 ------------------------");

