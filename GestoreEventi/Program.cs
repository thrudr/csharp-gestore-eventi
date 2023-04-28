
using GestoreEventi;

Console.WriteLine("Inserisci il nome dell'evento:");
string nomeEventoUtente = Console.ReadLine();

Console.WriteLine("Inserisci la data dell'evento (dd/MM/yyyy):");
String dataEventoUtente = Console.ReadLine();

Console.WriteLine("Inserisci il numero di posti totali:");
int numeroTotalePostiEventoUtente = int.Parse(Console.ReadLine());

Evento eventoInserito = new Evento(nomeEventoUtente, dataEventoUtente, numeroTotalePostiEventoUtente);

Console.WriteLine("Inserisci post Prenotati:");
int numeroPostiPrenotati = int.Parse(Console.ReadLine());
eventoInserito.PrenotaPosti(numeroPostiPrenotati);

Console.WriteLine(eventoInserito.ToString());

Console.WriteLine("Quanti posti desideri prenotare?");
int quantitaPostiUtente = int.Parse(Console.ReadLine());
eventoInserito.PrenotaPosti(quantitaPostiUtente);

int postiDisponibili = eventoInserito.GetMaxPosti() - eventoInserito.GetPostiPrenotati();
Console.WriteLine("I posti disponibili sono: " + postiDisponibili);
Console.WriteLine("I posti prenotati sono: " + eventoInserito.GetPostiPrenotati());

Console.WriteLine("Vuoi disdire dei posti? (si/no)?");
string check = Console.ReadLine();
while (check == "si")
{
    Console.WriteLine("Indica il numero di posti da disdire:");
    int numeriPostiDisdetta = int.Parse(Console.ReadLine());
    eventoInserito.DisdiciPosti(numeriPostiDisdetta);

    postiDisponibili = eventoInserito.GetMaxPosti() - eventoInserito.GetPostiPrenotati();
    Console.WriteLine("I posti disponibili sono: " + postiDisponibili);
    Console.WriteLine("I posti prenotati sono: " + eventoInserito.GetPostiPrenotati());

    Console.WriteLine("Vuoi disdire altri posti? (si/no)?");
    check = Console.ReadLine();
}