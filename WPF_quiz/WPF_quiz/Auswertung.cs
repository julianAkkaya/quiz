using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_quiz
{
    class Auswertung
    {
        Fragebogen FB;
        private List<Aufgabe> falschBeantwortet = new List<Aufgabe>();
        private int anzahlFragen;
        private double ProzentRichtig;
        private bool bestanden;

        public Auswertung(Fragebogen FB) {
            this.FB = FB;
            anzahlFragen = FB.Aufgaben.Count;
            falschBeantwortetFüllen();
            ProzentRichtig = anzahlFragen / falschBeantwortet.Count * 100;
            bestanden = (ProzentRichtig < FB.ProzentZumBestehen) ? false : true;
        }

        public void falschBeantwortetFüllen()
        {
            foreach(Aufgabe aufgabe in FB.Aufgaben)
            {
                foreach(Antwort antwort in aufgabe.Antworten)
                {
                    if (antwort.IstKorrekt != antwort.UserAntwort)
                    {
                        falschBeantwortet.Add(aufgabe);
                        break;
                                            
                    }
                }

            }
        }
        public List<Aufgabe> getFalschBeantwortet()
        {
            return falschBeantwortet;
        }
        public double getErreichteProzent()
        {
            return ProzentRichtig;
        }
        public bool getBestanden()
        {
            return bestanden;
        }

    }
}
