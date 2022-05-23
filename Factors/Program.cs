// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int num, x;
Console.WriteLine("Enter the Number ");
num = int.Parse(Console.ReadLine());
Console.WriteLine("The Factors are : ");
for (x = 1; x <= num; x++)
{
    if (num % x == 0)
    {
        Console.WriteLine(x);
    }
}
Console.ReadLine();
