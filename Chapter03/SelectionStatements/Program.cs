﻿

int number = (new Random()).Next(1,7);
Console.WriteLine($"My random number is {number}");

switch (number)
{

	case 1:
		Console.WriteLine("One");
        break; // jumps to end of switch statement

		case 2:
		Console.WriteLine("Two");
		goto case 1;

		case 3:
			case 4:
        Console.WriteLine("Three or four");
        goto case 1;
    case 5:
        goto A_label;
    default:
        Console.WriteLine("Default");


        break;
}// end of switch statement

Console.WriteLine("After end of switch");
A_label:
Console.WriteLine($"After A_label");