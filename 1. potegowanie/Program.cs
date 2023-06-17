Console.WriteLine("Podaj podstawę: ");
int podstawa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Podaj wykładnik: ");
int wykladnik = Convert.ToInt32(Console.ReadLine());

int wynik = 1;

for (int i = 0; i < wykladnik; i++)
{
    wynik *= podstawa;
}

Console.WriteLine("Wynik potęgowania: " + wynik);