using System;
using System.Collections.Generic;
using System.Linq;

namespace LockomotivenSteuerung
{
    public static class LokomotiveControll
    {
        // Delegate-Typ: Nimmt eine Lokomotive und einen int-Wert entgegen (z.B. Gleislänge)
        public delegate void TargetTrackControll(Lokomotive train, int value);

        // Alle verfügbaren Gleise mit ihrer Länge in Metern
        private static Dictionary<string, int> sideTracks = new Dictionary<string, int>()
        {
            { "Hauptgleis A1",       600  },
            { "Nebengleis B2",       300  },
            { "Abstellgleis Nord",   150  },
            { "Wartungsgleis 1",      80  },
            { "Ladegleis West",      450  },
            { "Gütergleis G5",       800  },
            { "Express-Durchgang 1", 1200 },
            { "Rangierbereich Süd",  200  },
            { "Museumsgleis",        100  },
            { "Notfall-Bucht 01",     20  }
        };

        /// <summary>
        /// Führt alle Prüfungen für eine Lokomotive auf jedem Gleis durch.
        /// Die Delegates in ControllFuntions müssen vorher zugewiesen werden!
        /// </summary>
        public static void getControl(Lokomotive train)
        {
            foreach (var track in sideTracks)
            {
                Console.WriteLine($"  Gleis: {track.Key} ({track.Value} m)");

                // Prüfung 1: Gleislänge
                if (ControllFuntions.CheckTrackLength != null)
                    ControllFuntions.CheckTrackLength(train, track.Value);
                else
                    Console.WriteLine("    [FEHLER] CheckTrackLength ist nicht zugewiesen!");

                // Prüfung 2: Spurweite (track.Value wird hier nicht benötigt, daher 0)
                if (ControllFuntions.CheckTrackWidth != null)
                    ControllFuntions.CheckTrackWidth(train, 0);
                else
                    Console.WriteLine("    [FEHLER] CheckTrackWidth ist nicht zugewiesen!");

                // Prüfung 3: Controller-Chip
                if (ControllFuntions.CheckControllerChip != null)
                    ControllFuntions.CheckControllerChip(train, 0);
                else
                    Console.WriteLine("    [FEHLER] CheckControllerChip ist nicht zugewiesen!");
            }
        }
    }

    // -------------------------------------------------------------------------

    public class Lokomotive
    {
        public string Type       { get; private set; }
        public int    Track      { get; private set; }   // Spurweite in mm
        public string Controller { get; private set; }
        public int    Length     { get; private set; }   // Länge in Metern
        public Guid   Guid       { get; private set; } = Guid.NewGuid();

        public Lokomotive(string type, int track, string controller, int length)
        {
            Type       = type;
            Track      = track;
            Controller = controller;
            Length     = length;
        }
    }

    // -------------------------------------------------------------------------

    static class LokomotiveFactory
    {
        public static List<Lokomotive> fleet = new List<Lokomotive>();

        public static void CreateFleet()
        {
            fleet.Add(new Lokomotive("S-Bahn",        101, "SN-74HC-01",      67));
            fleet.Add(new Lokomotive("Güterzug",       102, "SN-74HC-02",     540));
            fleet.Add(new Lokomotive("ICE 4",          201, "ARM-CORTEX-V1",  312));
            fleet.Add(new Lokomotive("Regionalbahn",   103, "SN-74HC-03",     145));
            fleet.Add(new Lokomotive("Rangierlok",      50, "ESP-32-LOK",      14));
            fleet.Add(new Lokomotive("ICE 3",          202, "ARM-CORTEX-V2",  200));
            fleet.Add(new Lokomotive("EuroCity",       104, "SN-74HC-04",     250));
            fleet.Add(new Lokomotive("Vectron",        105, "SIEMENS-X4",      19));
            fleet.Add(new Lokomotive("Nachtzug",       106, "SN-74HC-05",     320));
            fleet.Add(new Lokomotive("Museumsbahn",     99, "ANALOG-CHIP-01",  22));
        }
    }
}
