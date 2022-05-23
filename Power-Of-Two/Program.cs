// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
static bool isPowerOfTwo(int n)
{
    if (n == 0)
        return false;

    while (n != 1)
    {
        if (n % 2 != 0)
            return false;

        n = n / 2;
    }
    return true;
}

{
    Console.WriteLine(isPowerOfTwo(31) ? "Yes" : "No");
    Console.WriteLine(isPowerOfTwo(64) ? "Yes" : "No");
}
