Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int current = n;
Console.Write(n);

while (!isPrime(current))
{
    current = digitSum(current);
    Console.Write(" " + current);

    if (current == digitSum(current) && !isPrime(current)) break;
}

Console.WriteLine();
Console.WriteLine("Простое число - " + current);

static int digitSum(int n)
{
    int sum = 0;
    while (n > 0)
    {
        sum += n % 10;
        n /= 10;
    }

    return sum;
}

static bool isPrime(int n)
{
    if (n < 2) return false;
    if (n == 2) return true;
    if (n % 2 == 0) return false;

    int i = 3;
    while (i * i <= n)
    {
        if (n % i == 0) return false;
        i += 2;
    }

    return true;
}