using Xunit;

namespace Partygaeste.Test
{
    public class PartygaesteServiceTest
    {
        private readonly PartygaesteService _partygaesteService;

        public PartygaesteServiceTest()
        {
            _partygaesteService = new PartygaesteService();
        }

        [Fact]
        public void IstGueltigerName_MitGueltigemNamen_LiefertTrue()
        {
            var istGueltig = IstGueltigerName("Roger");

            Assert.True(istGueltig);
        }

        [Fact]
        public void IstGueltigerName_MitUngueltigemNamen_LiefertFalse()
        {
            var istGueltig = IstGueltigerName(string.Empty);

            Assert.False(istGueltig);
        }

        [Fact]
        public void GetBegruessung_BeiErstemBesuch_LautetHelloName()
        {
            var begruessung = GetBegruessung("Roger", 1);

            Assert.Equal("Hello, Roger!", begruessung);
        }

        [Fact]
        public void GetBegruessung_BeiZweitemBesuch_LautetWelcomeBackName()
        {
            var begruessung = GetBegruessung("Roger", 2);

            Assert.Equal("Welcome back, Roger!", begruessung);
        }

        [Fact]
        public void GetBegruessung_DritterBisVierundzwanzigsterBesuch_LautetHelloMyGoodFriendName()
        {
            for (var i = 3; i <= 24; i++)
            {
                var begruessung = GetBegruessung("Roger", i);

                Assert.Equal("Hello my good friend, Roger!", begruessung);
            }
        }

        [Fact]
        public void GetBegruessung_FuenfundzwanzigsterBesuch_LautetHelloMyGoodFriendNameMitPlantinumGuest()
        {
            var begruessung = GetBegruessung("Roger", 25);

            Assert.Equal("Hello my good friend, Roger! Congrats! You are now a platinum guest!", begruessung);
        }

        [Fact]
        public void GetBegruessung_SechundzwanzigsterBesuch_LautetHelloMyGoodFriendName()
        {
            var begruessung = GetBegruessung("Roger", 26);

                Assert.Equal("Hello my good friend, Roger!", begruessung);
        }

        private string GetBegruessung(string name, int anzahlBesuche) => 
            _partygaesteService.GetBegruessung(name, anzahlBesuche);

        private bool IstGueltigerName(string name) =>
            _partygaesteService.IstGueltigerName(name);
    }
}
