namespace ZadatakParceleC;

internal class ParcelaGradjevinskaDozvola : Parcela
{
    public ParcelaGradjevinskaDozvola(int ID, float povrsinaZemljista) :
        base(ID, povrsinaZemljista)
    {
    }

    public override float Kalkulisi() =>
        PovrsinaZemljista * Poreznik.StopaPorezaZemljistaPom2;

    public override void Print() =>
        Console.WriteLine("Parcela sa gradjevniskom dozvolom.\n" +
          $" ID: {id},\n Povrsina zemljista: {PovrsinaZemljista} m2");
}