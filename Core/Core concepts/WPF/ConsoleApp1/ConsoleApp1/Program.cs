using System;

var trueOrFalse = double.TryParse("-150.00", out double num1);


if(trueOrFalse == true)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}