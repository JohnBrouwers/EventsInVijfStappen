using EventsInVijfStappen.StruikelDefinities;

namespace EventsInVijfStappen.Personen
{
    public class Dokter : Persoon
    {
        //TODO: Events stap 4
        //Implementeer de eventhandler
        //Hoe kan er gereageerd worden op een event, hoe kan het event afgehandeld worden, wat moet er op dat moment gebeuren
        public StruikelDelegate StruikelHandler => (hardloper, args) => {
            if (args.Pijnlijkheid > 7)
            {
                Console.WriteLine($"{this.GetType().Name}:\t\t {this.Naam} behandelt de open wonden van gestruikelde hardloper {hardloper.Naam}");
            }
        };
    }
}
