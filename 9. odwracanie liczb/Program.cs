Console.WriteLine("Podaj liczbę:");
int liczba = Convert.ToInt32(Console.ReadLine());

int odwroconaLiczba = OdwrocKolejnoscCyfr(liczba);

Console.WriteLine("Odwrotność liczby: " + odwroconaLiczba);

    static int OdwrocKolejnoscCyfr(int liczba)
{
    if (liczba < 10)
        return liczba;

    int ostatniaCyfra = liczba % 10;
    int pozostaleCyfry = liczba / 10;

    int odwroconaPozostalosc = OdwrocKolejnoscCyfr(pozostaleCyfry);

    int iloscCyfr = (int)Math.Floor(Math.Log10(pozostaleCyfry) + 1);

    return ostatniaCyfra * (int)Math.Pow(10, iloscCyfr) + odwroconaPozostalosc;
}