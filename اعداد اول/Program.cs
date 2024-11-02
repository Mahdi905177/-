Console.Write("Enter number n: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Enter number m: ");
int m = int.Parse(Console.ReadLine());

if (n > m)
{
    int temp = n;
    n = m;
    m = temp;
}

Console.WriteLine($"Prime numbers between {n} and {m} are:");
for (int i = n; i <= m; i++)
{
    if (IsPrime(i))
    {
        Console.WriteLine(i);
    }
}
    
    static bool IsPrime(int num)
{
    if (num <= 1)
        return false;

    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
            return false;
    }

    return true;
}


