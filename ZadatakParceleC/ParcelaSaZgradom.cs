namespace ZadatakParceleC;

internal class ParcelaSaZgradom : Parcela
{
    public ParcelaSaZgradom(int ID, float povrsinaZemljista,
        float povrsinaOsnoveZgrade) : base(ID, povrsinaZemljista)=>
        PovrsinaOsnoveZgrade = povrsinaOsnoveZgrade;

    public override float Kalkulisi() =>
        PovrsinaZemljista * Poreznik.StopaPorezaZemljistaPom2 +
        PovrsinaOsnoveZgrade * Poreznik.StopaPorezaGradjevinePom2;

    public override void Print()=>
        Console.WriteLine("Parcela sa izgradjenom zgradom.\n" +
            $" ID: {id},\n Povrsina zemljista: {PovrsinaZemljista} m2\n" +
            $"Povrsina osnove zgrade: {PovrsinaOsnoveZgrade} m2");

    public float PovrsinaOsnoveZgrade { get; private set; }
}
