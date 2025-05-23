namespace Karta;

internal class ObicnaKarta : Karta
{
    public ObicnaKarta(int broj, Stanica polazna, Stanica dolazna, int cena) :
        base(broj, polazna, dolazna, cena)
    {
    }

    public override string ToString()
    {
        return $"Karta br: {Broj}\n Tip: obicna karta\n Cena: {_cena}\n Polazna stanica br: {_polazna.Broj}\n Dolazna stanica br: {_dolazna.Broj}";
    }
}
