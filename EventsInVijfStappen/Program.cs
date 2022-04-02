using EventsInVijfStappen.Personen;

//Dit voorbeeldproject geeft in 5 stappen met uitleg aan hoe events geïmplementeerd kunnen worden in C#

//In de regions 'Details' kun je extra uitleg vinden, klik dan op het plusje aan het begin van de regel om deze details zichtbaar te maken, zie bijvoorbeeld regel 16 in dit codeblad

//Via menu 'View' > 'Task List' maak je het taken-panel zichtbaar en kun je makkelijk naar de verschillende stappen navigeren met een dubbelklik op een aangegeven stap in de Task List

//Events in 5 stappen
// 1 - Definineer de delegate
// 2 - Implementeer het event
// 3 - Roep het event op
// 4 - Implementeer een eventhandler
// 5 - Koppel de eventhandler aan het event

//Gebruik daarna het object om het event te laten gebeuren en af te handelen door (meestal) een ander object

#region Details

//Events in 5 stappen
// 1 - Definineer de delegate: StruikelDelegate
// 2 - Implementeer het event: StruikelEvent
// 3 - Roep het event op: wanneer de hardloper sneller loopt dan 25 km/uur dan struikelt de hardloper, zie de hardloop methode
// 4 - Implementeer een eventhandler: StruikelHandler
// 5 - Abonneer(subscribe) of koppel de eventhandler aan het event: rappeRonnie.StruikelEvent += dokterDirk.StruikelHandler;
//Gebruik daarna het object om het event te laten gebeuren en af te handelen


//Belangrijk in het gebruik van delegates (en events) is dat het ene object verantwoordelijk is voor het moment van de gebeurtenis en een ander object verantwoordeijk is voor het reageren op de gebeurtenis.
//De hardloper bepaald het moment van struikelen, de dokter en de toeschouwer bepalen óf ze willen reageren en hoe ze erop reageren. Ook wanneer er niet geabonneerd is op het event kan de hardloper struikelen, event-subscription is optioneel! 

#endregion


Console.WriteLine("\n#################  Begin voorbeeld struikelende hardloper  #################\n");

Dokter dokterDirk = new Dokter() { Naam = "Dirk" };
Toeschouwer toeschouwerTheo = new Toeschouwer() { Naam = "Theo" };
Hardloper rappeRonnie = new Hardloper() { Naam = "Rappe Ronnie" };

//TODO: Events Stap 5
//Abonneer op het event, ofwel koppel de eventhandler aan het event
rappeRonnie.StruikelEvent += dokterDirk.StruikelHandler;
rappeRonnie.StruikelEvent += toeschouwerTheo.StruikelHandler;

rappeRonnie.LoopHard(23);
rappeRonnie.LoopHard(29);

Console.WriteLine("\n#################  Einde voorbeeld struikelende hardloper  #################\n");