Console.WriteLine("Podaj liczbę wyrazów ciągu Fibonacciego do wygenerowania:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Wygenerowane wyrazy ciągu Fibonacciego:");
for (int i = 0; i < n; i++)
{
    int fib = Fibonacci(i);
    Console.Write(fib + " ");
}

static int Fibonacci(int n)
{
    if (n <= 1)
    {
        return n;
    }
    else
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}