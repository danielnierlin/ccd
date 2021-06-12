namespace Partygaeste
{
    public class PartygaesteService
    {
        public string GetBegruessung(string name, int anzahlBesuche)
        {
            if (anzahlBesuche == 1)
            {
                return $"Hello, {name}!";
            }
            
            if (anzahlBesuche == 2)
            {
                return $"Welcome back, {name}!";
            }

            var welcomeBack = $"Hello my good friend, {name}!";

            if (anzahlBesuche == 25)
            {
                return welcomeBack + " Congrats! You are now a platinum guest!";
            }

            return welcomeBack;
        }

        public bool IstGueltigerName(string name) =>
            !string.IsNullOrWhiteSpace(name);
    }
}