using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_quiz
{
    public class Fragebogen
    {
        public int FragebogenNr;
        public int ProzentZumBestehen;
        public List<Aufgabe> Aufgaben;

        public Fragebogen(int FragebogenNr, int ProzentZumBestehen) {
            this.FragebogenNr = FragebogenNr;
            this.ProzentZumBestehen = ProzentZumBestehen;
        }
    }
}
