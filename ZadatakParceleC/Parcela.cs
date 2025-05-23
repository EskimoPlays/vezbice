namespace ZadatakParceleC;

internal abstract class Parcela: IPrintable
{
    public Parcela(int ID, float povrsinaZemljista) =>
        (id, PovrsinaZemljista) = (ID, povrsinaZemljista);
    public float PovrsinaZemljista { get; }

    protected int id;

    public abstract float Kalkulisi();
    public abstract void Print();
}
