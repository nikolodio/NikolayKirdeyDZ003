Console.Write("Enter the five-digit number: ");
string? number = Console.ReadLine();
void fiveDigit(string number)
{

    if (number![0] == number[4] || number[1] == number[3])
    {
        Console.Write($"Number {number} -> palindrom");
    }
    else
    {
        Console.Write($"Number {number} its not palindrom");
    }
}
if (number!.Length == 5)
{
    fiveDigit(number);
}
else
{
    Console.WriteLine("enter another number");
}