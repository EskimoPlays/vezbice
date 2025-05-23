using ZadatakParceleC;

Katastar katastar = new(20, 30);

katastar.DodajParcelu(new ParcelaBezGradjevinskaDozvola(1, 89));
katastar.DodajParcelu(new ParcelaGradjevinskaDozvola(2, 90));
katastar.DodajParcelu(new ParcelaSaZgradom(3, 120, 50));

katastar.NapraviSpisak();
Console.WriteLine(katastar.NadjiUkupnuPovrsinu());
Console.WriteLine(katastar.NadjiUkupanPorez());
katastar.ToString();