Console.WriteLine("Podaj liczbę naturalną o co najmniej 3 cyfrach:");
int liczba = Convert.ToInt32(Console.ReadLine());

if (liczba < 100)
{
    Console.WriteLine("Podana liczba ma mniej niż 3 cyfry.");
}
else
{
    Console.WriteLine("Cyfry liczby:");
    WypiszCyfry(liczba);
}

    static void WypiszCyfry(int liczba)
{
    if (liczba < 10)
    {
        Console.WriteLine(liczba);
    }
    else
    {
        int ostatniaCyfra = liczba % 10;
        int pozostaleCyfry = liczba / 10;

        WypiszCyfry(pozostaleCyfry);

        Console.WriteLine(ostatniaCyfra);
    }
}