using System;
using System.Collections.Generic;
using System.Linq;

namespace Partygaeste.Repositories
{
    public class PartygaesteDateiRepository : IPartygaesteRepository
    {
        private const char Separator = '|';

        private readonly string _dateiname;

        public PartygaesteDateiRepository()
        {
            _dateiname = AppContext.BaseDirectory + "db.txt";
        }

        public int GetAnzahlBesuche(string name)
        {
            if (GetDaten().TryGetValue(name, out var anzahlBesuche))
            {
                return anzahlBesuche;
            }

            return 0;
        }

        public void SetAnzahlBesuche(string name, int anzBesuche)
        {
            var dict = GetDaten();
            dict[name] = anzBesuche;

            var daten = dict.Select(i => i.Key + Separator + i.Value);

            System.IO.File.WriteAllLines(_dateiname, daten);

        }
        
        private Dictionary<string, int> GetDaten()
        {
            var daten = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            if (System.IO.File.Exists(_dateiname))
            {
                var lines = System.IO.File.ReadAllLines(_dateiname);

                foreach (var line in lines)
                {
                    var gesplittet = line.Split(Separator);

                    daten.Add(gesplittet[0], int.Parse(gesplittet[1]));
                }
            }

            return daten;
        }
    }
}
