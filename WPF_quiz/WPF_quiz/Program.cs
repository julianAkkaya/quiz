using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPF_quiz
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void PrüfungDurchfuehren(int FragebogenNr, int ProzentZumBestehen)
        {
            Fragebogen FB = new Fragebogen(FragebogenNr, ProzentZumBestehen); //fragebogenNr und prozent zum bestehen mitgeben
            // mit Daten aus der DB befüllen 
            // FB = MethodeZumBefüllenDerKlasseAufgaben(FB); 
            // Dann die Prüfung auf der GUI durchführen und Usereingaben zum Objekt hinzufügen
            // FB = MethodePrüfung(FB);
            Auswertung Ergebnis = new Auswertung(FB);
            //Ergebnis.getBestanden;
            //Ergebnis.getErreichteProzent;
            //Ergebnis.getFalschBeantwortet;
        }
        public static bool wurdeKomplettBeantwortet(Fragebogen FB)
        {
            foreach (Aufgabe aufgabe in FB.Aufgaben)
            {
                int counter = 0;
                int AnzAufgaben = aufgabe.Antworten.Count;
                foreach (Antwort antwort in aufgabe.Antworten)
                {
                    if (antwort.UserAntwort == true)
                    {
                        break;
                    }
                    else
                    {
                        counter++;
                    }
                }
                if (counter>=AnzAufgaben)
                {
                    return false;
                }
            }
            return true;
        }


    }
}
