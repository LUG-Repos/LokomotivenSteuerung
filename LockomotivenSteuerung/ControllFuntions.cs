using System;
using static LockomotivenSteuerung.LokomotiveControll;

namespace LockomotivenSteuerung
{
    /// <summary>
    /// Diese Klasse enthält die Delegate-Felder für die drei Gleis-Prüfungen.
    ///
    /// AUFGABE:
    /// Implementiere die drei Methoden unten und weise sie den Delegate-Feldern zu.

    /// Prüfkriterien:
    ///   CheckTrackLength  → Passt die Lokomotive (train.Length) auf das Gleis (value = Gleislänge in m)?
    ///   CheckTrackWidth   → Hat die Lokomotive eine gültige Spurweite (train.Track zwischen 50 und 202)?
    ///   CheckControllerChip → Ist der Controller kein veralteter Chip? ("ANALOG-CHIP" gilt als veraltet)
    ///
    /// Gib für jede Prüfung eine aussagekräftige Konsolenausgabe aus (✓ oder ✗).
    /// </summary>
    public static class ControllFuntions
    {
        // -----------------------------------------------------------------------
        // Delegate-Felder – hier werden deine Methoden zugewiesen
        // -----------------------------------------------------------------------

        public static TargetTrackControll? CheckTrackLength    = null;
        public static TargetTrackControll? CheckTrackWidth     = null;
        public static TargetTrackControll? CheckControllerChip = null;

        // -----------------------------------------------------------------------
        // TODO: Implementiere die drei Methoden mit der richtigen Signatur
        //       und weise sie oben den Delegate-Feldern zu.
        //
        // Beispiel-Signatur (kopiere diese für alle drei):
        //
        //   public static void MeineMethode(Lokomotive train, int value)
        //   {
        //       // deine Logik hier
        //   }
        //
        // Zuweisung (z.B. im statischen Konstruktor oder in Program.cs):
        //
        //   CheckTrackLength = MeineMethode;
        //
        // -----------------------------------------------------------------------

        // PLATZ FÜR DEINE IMPLEMENTIERUNG:




    }
}
