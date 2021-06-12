namespace Partygaeste.Repositories
{
    public interface IPartygaesteRepository
    {
        int GetAnzahlBesuche(string name);
        void SetAnzahlBesuche(string name, int anzBesuche);
    }
}
