Console.WriteLine("enter the number: ");
int end = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= end; i++)
{
    Console.Write(Math.Pow(i, 3) + " ");
}