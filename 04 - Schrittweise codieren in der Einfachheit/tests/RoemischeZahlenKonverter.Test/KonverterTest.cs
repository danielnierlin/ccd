using Xunit;

namespace RoemischeZahlenKonverter.Test
{
    public class KonverterTest
    {
        // Akzeptanztests
        [Theory]
        [InlineData("MCMLXXXIV", 1984)]
        [InlineData("MCDXCII", 1492)]
        public void RoemischeZahlInDezimalzahlUmwandeln(string roemischeZahl, int erwarteteDezimalZahl) => 
            CheckKonvertierung(roemischeZahl, erwarteteDezimalZahl);

        // Erster inkrementeller Test
        [Theory]
        [InlineData("M", 1000)]
        [InlineData("D", 500)]
        [InlineData("C", 100)]
        [InlineData("L", 50)]
        [InlineData("X", 10)]
        [InlineData("V", 5)]
        [InlineData("I", 1)]
        public void RoemischeZahlInDezimalzahlUmwandeln_ZahlzeichenUebersetzen(string roemischeZahl, int erwarteteDezimalZahl) => 
            CheckKonvertierung(roemischeZahl, erwarteteDezimalZahl);

        //Zweiter inkrementeller Test
        [Theory]
        [InlineData("MDCLXVI", 1666)]
        public void RoemischeZahlInDezimalzahlUmwandeln_OhneAbzugslogik(string roemischeZahl, int erwarteteDezimalZahl) =>
            CheckKonvertierung(roemischeZahl, erwarteteDezimalZahl);

        //Dritter inkrementeller Test
        [Theory]
        [InlineData("IV", 4)]
        [InlineData("XL", 40)]
        [InlineData("CD", 400)]
        public void RoemischeZahlInDezimalzahlUmwandeln_MitAbzugslogik(string roemischeZahl, int erwarteteDezimalZahl) =>
            CheckKonvertierung(roemischeZahl, erwarteteDezimalZahl);

        private void CheckKonvertierung(string roemischeZahl, int erwarteteDezimalZahl)
        {
            var actual = new Konverter().RoemischeZahlInDezimalzahlUmwandeln(roemischeZahl);

            Assert.Equal(erwarteteDezimalZahl, actual);
        }
    }
}
