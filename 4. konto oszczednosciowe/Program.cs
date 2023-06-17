Console.WriteLine("Podaj kwotę początkową na koncie oszczędnościowym:");
decimal kwotaPoczatkowa = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Podaj oprocentowanie konta w skali roku:");
decimal oprocentowanie = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Podaj liczbę miesięcy oszczędzania:");
int liczbaMiesiecy = Convert.ToInt32(Console.ReadLine());

decimal kwotaKoncowa = ObliczKwoteKoncowa(kwotaPoczatkowa, oprocentowanie, liczbaMiesiecy);
decimal kwotaKoncowaPoPodatku = ObliczKwotePoPodatku(kwotaKoncowa);

Console.WriteLine("Kwota końcowa na koncie oszczędnościowym (po uwzględnieniu podatku Belki): " + kwotaKoncowaPoPodatku.ToString("N2"));

static decimal ObliczKwoteKoncowa(decimal kwotaPoczatkowa, decimal oprocentowanie, int liczbaMiesiecy)
{
    decimal oprocentowanieMiesieczne = oprocentowanie / 12 / 100;
    decimal kwotaKoncowa = kwotaPoczatkowa * (decimal)Math.Pow((double)(1 + oprocentowanieMiesieczne), liczbaMiesiecy);

    return kwotaKoncowa;
}

static decimal ObliczKwotePoPodatku(decimal kwota)
{
    decimal podatekBelki = 0.19m; // 19% podatek Belki
    decimal kwotaPoPodatku = kwota - (kwota * podatekBelki);

    return kwotaPoPodatku;
}