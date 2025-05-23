namespace Karta;

internal class PosebnaKarta : Karta
{
    public PosebnaKarta(int broj, Stanica polazna, Stanica dolazna,
        int cena, float popust) : base(broj, polazna, dolazna, cena)=>
        _popust = popust;
    
    public override string ToString()
    {
        return $"Karta br: {Broj}\n Tip: posebna karta\n Cena: {_cena}\n Popust: {_popust}%\n Polazna stanica br: {_polazna.Broj}\n Dolazna stanica br: {_dolazna.Broj}";
    }
}
