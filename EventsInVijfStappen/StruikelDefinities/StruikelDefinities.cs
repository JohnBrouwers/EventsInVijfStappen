using EventsInVijfStappen.Personen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsInVijfStappen.StruikelDefinities
{

    //TODO: Events stap 1
    //Definieer de delegate
    // Hiermee bepaal je de signatuur van de communicatie tussen de verzender en de ontvanger (aantal, type en volgorde van de parameters en eventueel returntype

    #region Details
    // De verzender is in dit project de hardloper, de ontvanger is de dokter of toeschouwer die reageert op het moment wanneer de hardloper struikelt
    //Deze delegate definitie maakt het mogelijk te communiceren welke hardloper struikelt (sender) en wat de pijnlijkheid is (args)
    //Het is een codeer conventie om event signatures te voorzien van een 'sender' en EventArgs (Ps..NET System heeft hiervoor een voorgedefinieerde EventHandler<T>, maar het is nodig dat je alle 5 stappen eerst begrijpt en weet toe te passen)
    #endregion

    public delegate void StruikelDelegate(Hardloper sender, StruikelEventArgs args);

    public class StruikelEventArgs: EventArgs
    {
        public int Pijnlijkheid { get; private set; }

        public StruikelEventArgs(int pijnlijkheid)
        {
            Pijnlijkheid = pijnlijkheid;
        }
    }
}
