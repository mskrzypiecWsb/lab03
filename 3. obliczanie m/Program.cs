int n, k;

do
{
    Console.WriteLine("Podaj liczbę n (n >= 5):");
} while (!int.TryParse(Console.ReadLine(), out n) || n < 5);

do
{
    Console.WriteLine("Podaj liczbę k (k >= 5):");
} while (!int.TryParse(Console.ReadLine(), out k) || k < 5);

long m = ObliczWartoscWyrazenia(n, k);
Console.WriteLine("Wartość wyrażenia m = (n! - k!) / k! wynosi: " + m);

    static long ObliczWartoscWyrazenia(int n, int k)
{
    long nFactorial = ObliczSilnie(n);
    long kFactorial = ObliczSilnie(k);

    return (nFactorial - kFactorial) / kFactorial;
}

static long ObliczSilnie(int liczba)
{
    long silnia = 1;

    for (int i = 2; i <= liczba; i++)
    {
        silnia *= i;
    }

    return silnia;
}