using System;

class Program
{
    // Struttura per rappresentare un pacchetto di dati
    struct Packet
    {
        public int Source;        // Nodo di origine
        public int Destination;   // Nodo di destinazione
        public string Data;       // Dati del pacchetto

        // Costruttore per inizializzare un pacchetto
        public Packet(int source, int destination, string data)
        {
            Source = source;
            Destination = destination;
            Data = data;
        }
    }

    // Funzione per calcolare il miglior percorso (deciso dal controller centrale)
    static int CalculateBestRoute(int source, int destination)
    {
        // Esempio semplificato di calcolo percorso
        Console.WriteLine($"Calcolando il miglior percorso da {source} a {destination}");

        // In un sistema reale, questo sarebbe più complesso (basato su topologia, congestione, ecc.)
        return destination;  // Supponiamo che il miglior percorso sia diretto alla destinazione
    }

    // Funzione per instradare il pacchetto (seguito dai dispositivi di rete)
    static void RoutePacket(Packet packet, int route)
    {
        Console.WriteLine($"Instradando pacchetto da {packet.Source} a {packet.Destination} via percorso {route}");
    }

    // Funzione per il controller centrale che gestisce l'instradamento di più pacchetti
    static void CentralController(Packet[] packets)
    {
        // Per ogni pacchetto nell'array, calcoliamo e instradamo il percorso
        foreach (var packet in packets)
        {
            int bestRoute = CalculateBestRoute(packet.Source, packet.Destination);
            RoutePacket(packet, bestRoute);
        }
    }

    // Funzione principale
    static void Main(string[] args)
    {
        // Array di pacchetti
        Packet[] packets = new Packet[]
        {
            new Packet(1, 5, "Messaggio 1"),
            new Packet(2, 6, "Messaggio 2"),
            new Packet(3, 7, "Messaggio 3"),
            new Packet(4, 8, "Messaggio 4")
        };

        // Il controller centralizzato gestisce l'instradamento di tutti i pacchetti
        CentralController(packets);
    }
}
