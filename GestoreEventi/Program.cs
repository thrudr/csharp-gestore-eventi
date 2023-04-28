
using GestoreEventi;

Console.WriteLine("Inserisci il nome dell'evento:");
string nomeEventoUtente = Console.ReadLine();

Console.WriteLine("Inserisci la data dell'evento (dd/MM/yyyy):");
String dataEventoUtente = Console.ReadLine();

Console.WriteLine("Inserisci il numero di posti totali:");
int numeroTotalePostiEventoUtente = int.Parse(Console.ReadLine());

Evento eventoinserito = new Evento(nomeEventoUtente, dataEventoUtente, numeroTotalePostiEventoUtente);
Console.WriteLine(eventoinserito.ToString());

Console.WriteLine("Inserisci post Prenotati:");
int numeroPostiPrenotati = int.Parse(Console.ReadLine());
eventoinserito.PrenotaPosti(numeroPostiPrenotati);

