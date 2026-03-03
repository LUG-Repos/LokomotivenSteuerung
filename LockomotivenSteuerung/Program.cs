// Aufgabe: Lokomotiven-Steuerungssystem
// =======================================
// Dieses Programm prüft für jede Lokomotive der Flotte, ob sie auf ein bestimmtes
// Gleis passt. Die Prüfung erfolgt über Delegates vom Typ TargetTrackControll.
//
// DEINE AUFGABE:
// In ControllFuntions.cs sind drei Delegate-Felder deklariert: CheckTrackLength,
// CheckTrackWidth und CheckControllerChip. Weise diesen Feldern passende Methoden
// (als Delegates) zu, sodass getControl() korrekt funktioniert.

using LockomotivenSteuerung;
using static LockomotivenSteuerung.LokomotiveControll;

namespace LockomotivenSteuerung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Flotte erstellen
            LokomotiveFactory.CreateFleet();

            Console.WriteLine("=== Lokomotiven-Steuerungssystem ===\n");

            // TODO: Weise in ControllFuntions.cs die Delegate-Felder zu,
            //       damit die Prüfungen unten korrekt ausgeführt werden!

            foreach (Lokomotive lok in LokomotiveFactory.fleet)
            {
                Console.WriteLine($"--- Prüfe Lokomotive: {lok.Type} (ID: {lok.Guid}) ---");

                // getControl ruft die drei Delegate-Felder aus ControllFuntions auf.
                // Sind sie null, erscheint eine Fehlermeldung.
                LokomotiveControll.getControl(lok);

                Console.WriteLine();
            }

            Console.WriteLine("Alle Prüfungen abgeschlossen.");
        }
    }
}
