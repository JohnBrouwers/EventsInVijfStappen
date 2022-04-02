using EventsInVijfStappen.StruikelDefinities;

namespace EventsInVijfStappen.Personen
{

    public class Hardloper: Persoon
    {

        private const int struikelSnelheidsDrempel = 19;

        public void LoopHard(int snelheid) 
        {
            Console.WriteLine($"{this.GetType().Name}:\t {this.Naam} loopt {snelheid} km/u");
            if (snelheid > struikelSnelheidsDrempel)
            {
                var pijnlijkheid = snelheid - struikelSnelheidsDrempel;
                Console.WriteLine($"{this.GetType().Name}:\t {this.Naam} struikelt met {snelheid} km/u");

                //TODO: Events stap 3
                //Roep het event op, ofwel voer het event uit, ofwel voer alle gekoppelde methods uit.
                //Deze gekoppelde methods worden eventhandlers genoemd, 'die handelen het event af' of 'die reageren op het event'
                StruikelEvent?.Invoke(this, new StruikelEventArgs(pijnlijkheid));

                #region Details
                //Detail:
                //Wanneer er geen eventhandlers gekoppeld zijn aan het event dan is het event null en kan het niet aangeroepen of uitgevoerd worden (met null kun je niks..)
                //if (StruikelEvent != null)
                //{
                //    StruikelEvent(this, new StruikelEventArgs (pijnlijkheid: 10));
                //}
                //Bovenstaande 'Event?.Invoke' regel heeft dezelfde werking als bovenstaand if blok, maw alleen wanneer het event niet null is, zal het uitgevoerd of aangeroepen worden (het vraagteken doet een null-check) 
                #endregion
            }

        }

        //TODO: Events stap 2
        //Implementeer een event object/class member van het type delegate
        //Een event is van het type delegate, en wordt onderstaand als 'public event field' gedefinieerd. Het StruikelEvent kan gezien worden als een datacontainer van eventhandler-methodes.
        public event StruikelDelegate StruikelEvent;

        #region Details
        //Detail:
        //Het keyword 'event' past encapsulation toe waardoor de '=' operator niet meer buiten de classe op het event toegepast kan worden: 'obj.event = handler;' mag dan niet meer, en alleen '+=' en '-=' zijn dan nog toegestaan 
        #endregion
    }
}
