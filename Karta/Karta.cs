namespace Karta;

struct Stanica
{
    public Stanica(int broj) => Broj = broj;
    public int Broj { get; }

    public override bool Equals(object? obj)
    {
        return obj is Stanica stanica &&
               Broj == stanica.Broj;
    }

    public override int GetHashCode()
    {
        return Broj.GetHashCode();
    }

    public static bool operator == (Stanica lhs, Stanica rhs)=>
        lhs.Broj == rhs.Broj;
    public static bool operator != (Stanica lhs, Stanica rhs) =>
        !(lhs == rhs);
}

internal abstract class Karta
{
    public Karta(int broj, Stanica polazna, Stanica dolazna, int cena) =>
        (Broj, _polazna, _dolazna, _cena) = (broj, polazna, dolazna, cena);

    public int Broj { get; private set; }
    public Stanica _polazna, _dolazna;
    protected int _cena;
    protected float _popust = 0;
    public float PlatnaCena { get => (1f - _popust / 100f) * _cena; }
    public override abstract string ToString();
}
