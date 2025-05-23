using System.Text;

namespace Karta
{
    internal class Preduzece
    {
        public Preduzece()=>
            (_karte, _stanice) = ([], []);
        public Preduzece Dodaj(Karta k)
        {
            if (_karte.ContainsKey(k.Broj))
            {
                throw new ArgumentException
                    ($"Karta sa brojem {k.Broj} vec postoji");
            }
            else if (!_stanice.Contains(k._dolazna) || !_stanice.Contains(k._polazna))
            {
                throw new ArgumentException
                    ($"Stanica broj {k._dolazna.Broj} ili {k._polazna.Broj}" +
                    $" ne postoji u trenutnom preduzecu");
            }
            _karte[k.Broj] = k;

            return this;
        }
        public string GetMiniStatistika()
        {
            StringBuilder stringBuilder = new();
            foreach (Stanica s in _stanice)
            {
                var brojPolaznih = _karte.Values.Count(k => k._polazna == s);
                var brojDolaznih = _karte.Values.Count(k => k._dolazna == s);
                stringBuilder.AppendLine($"Stanica br: {s.Broj}")
                    .AppendLine($"Broj polaznih: {brojPolaznih}")
                    .AppendLine($"Broj dolaznih: {brojDolaznih}")
                    .AppendLine(new string('-', 32));
            }    
           
            return stringBuilder.ToString();
        }
        public Preduzece Dodaj(Stanica s)
        {
            if (_stanice.Contains(s)) 
            {
                throw new ArgumentException($"Stanica sa brojem {s.Broj} vec postoji");
            }
            _stanice.Add(s);
            return this;
        }

        public Preduzece Obrisi(int broj)
        {
            if(!_karte.ContainsKey(broj))
            {
                throw new ArgumentException
                    ($"Karta sa brojem {broj} ne postoji");
            }
            _karte.Remove(broj);
            return this;
        }
        public float NadjiZaradu()=>
            _karte.Values.Sum(karta => karta.PlatnaCena);
        public override string ToString()=>
            string.Join("\n------------------------\n", _karte.Values);

        private Dictionary<int, Karta> _karte;
        private HashSet<Stanica> _stanice;
    }
}
