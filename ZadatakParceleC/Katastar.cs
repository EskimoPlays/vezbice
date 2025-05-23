namespace ZadatakParceleC;

internal class Katastar
{
    public Katastar(float stopaPorezaZemljistaPom2, float stopaPorezaGradjevinePom2) =>
        (Poreznik.StopaPorezaZemljistaPom2, Poreznik.StopaPorezaGradjevinePom2, parcele) =
        (stopaPorezaZemljistaPom2, stopaPorezaGradjevinePom2, []);
    public void DodajParcelu(Parcela parcela)=>
        parcele.Add(parcela);
    public void NapraviSpisak()=>
        parcele.ForEach(parcela => parcela.Print());
    public float NadjiUkupnuPovrsinu()
    {
        float sum = 0;

        for(int i = 0; i < parcele.Count; i++)
        {
            if(parcele[i] is ParcelaSaZgradom parcelaSaZgradom)
                sum += parcelaSaZgradom.PovrsinaOsnoveZgrade;
            sum += parcele[i].PovrsinaZemljista;
        }

        return sum;
    }
    public float NadjiUkupanPorez() =>
        parcele.Sum(parcela => parcela.Kalkulisi());

    private readonly List<Parcela> parcele;
}
