using EventsInVijfStappen.StruikelDefinities;

namespace EventsInVijfStappen.Personen
{
    public class Toeschouwer: Persoon
    {
        //TODO: Events stap 4
        //Implementeer de eventhandler
        //Hoe kan er gereageerd worden op een event, hoe kan het event afgehandeld worden, wat moet er op dat moment gebeuren
        public void StruikelHandler(Hardloper hardloper, StruikelEventArgs args) 
        {
            if (args.Pijnlijkheid < 7)//alleen als het niet te erg is maakt een toeschouwer een foto..
            {
                Console.WriteLine($"{this.GetType().Name}:\t {Naam} maakt een foto van struikelende {hardloper.Naam}");
            }
        }
    }
}
