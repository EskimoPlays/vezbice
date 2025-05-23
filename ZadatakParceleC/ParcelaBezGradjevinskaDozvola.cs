namespace ZadatakParceleC;
internal class ParcelaBezGradjevinskaDozvola : Parcela
{
    public override float Kalkulisi() =>
        PovrsinaZemljista * Poreznik.StopaPorezaZemljistaPom2 / delilac;

    public override void Print()=>
        Console.WriteLine("Parcela bez gradjevniske dozvole.\n" +
            $" ID: {id},\n Povrsina zemljista: {PovrsinaZemljista} m2");

    private const float delilac = 100;

    public ParcelaBezGradjevinskaDozvola(int ID, float povrsinaZemljista) : base(ID, povrsinaZemljista)
    {
    }
}
