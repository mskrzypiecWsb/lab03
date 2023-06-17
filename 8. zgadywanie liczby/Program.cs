Console.WriteLine("Pomyśl liczbę z przedziału 1-20.");
Console.WriteLine("Naciśnij dowolny klawisz, gdy będziesz gotowy.");
Console.ReadKey();
Console.Clear();

int dolnyPrzedzial = 1;
int gornyPrzedzial = 20;
int liczbaPropozycji = 0;
int propozycja;

do
{
    propozycja = (dolnyPrzedzial + gornyPrzedzial) / 2;
    liczbaPropozycji++;

    Console.WriteLine("Czy Twoja liczba to {0}? (Odpowiedz ujemną, jeśli mniejsza, dodatnią, jeśli większa, zero jeśli odgadłem.)", propozycja);
    int odpowiedz = Convert.ToInt32(Console.ReadLine());

    if (odpowiedz < 0)
    {
        gornyPrzedzial = propozycja - 1;
    }
    else if (odpowiedz > 0)
    {
        dolnyPrzedzial = propozycja + 1;
    }
    else
    {
        Console.WriteLine("Odgadłem Twoją liczbę {0} w {1} próbach.", propozycja, liczbaPropozycji);
        break;
    }
} while (true);