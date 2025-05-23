using Karta;

Preduzece p = new();

Stanica br6 = new(6);
Stanica br7 = new(7);
Stanica br8 = new(8);
Stanica br9 = new(9);
Stanica br10 = new(10);

ObicnaKarta k1 = new(1, br6, br10, 1200);
PosebnaKarta pk1 = new(2, br7, br9, 1100, 20f);

Console.WriteLine(p.Dodaj(br6).Dodaj(br7).Dodaj(br8).Dodaj(br9).
    Dodaj(br10).Dodaj(k1).Dodaj(pk1).ToString());

Console.WriteLine(p.GetMiniStatistika());

Console.WriteLine($"Zarada: {p.NadjiZaradu()}");