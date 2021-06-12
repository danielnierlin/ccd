using System;

namespace Partygaeste
{
    class Program
    {
        static void Main()
        {
            Repositories.PartygaesteDateiRepository repo = new Repositories.PartygaesteDateiRepository();
            var service = new PartygaesteService();

            while (true)
            {
                Console.Write("Name: ");
                var name = Console.ReadLine();

                if (service.IstGueltigerName(name))
                {
                    var anzBesuche = repo.GetAnzahlBesuche(name) + 1;
                    Console.WriteLine(service.GetBegruessung(name, anzBesuche));

                    repo.SetAnzahlBesuche(name, anzBesuche);
                }
                else
                {
                    Console.WriteLine("Ungültiger Name.");
                }
            }
            // ReSharper disable once FunctionNeverReturns
        }
    }
}
