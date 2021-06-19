using System.Collections.Generic;
using System.Linq;

namespace RoemischeZahlenKonverter
{
    public class Konverter
    {
        private readonly Dictionary<char, int> _zeichenwerte;

        public Konverter()
        {
            _zeichenwerte = new Dictionary<char, int>()
            {
                {'M', 1000},
                {'D', 500},
                {'C', 100},
                {'L', 50},
                {'X', 10},
                {'V', 5},
                {'I', 1},
            };
        }

        public int RoemischeZahlInDezimalzahlUmwandeln(string roemischeZahl)
        {
            int summe = 0;
            int? vorigeZahl = null;

            var zahlenUebersetzt = roemischeZahl.Select(zeichen => _zeichenwerte[zeichen]);

            foreach (var aktuelleZahl in zahlenUebersetzt)
            {
                // Wenn ein Zeichen kleinerer Wertigkeit vorangestellt wird, bedeutet das Subtraktion (z.B. IV => 4)
                if (vorigeZahl < aktuelleZahl)
                {
                    // Zuvor addierte Zahl wieder aus der Summe abziehen, da diese ja nicht korrekt war
                    summe -= vorigeZahl.Value;

                    // Zahl nach Subtraktion zur Summe hinzufügen
                    summe += aktuelleZahl - vorigeZahl.Value;
                }
                else
                {
                    summe += aktuelleZahl;
                }

                vorigeZahl = aktuelleZahl;
            }

            return summe;
        }
    }
}