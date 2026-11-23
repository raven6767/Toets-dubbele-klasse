using System;
using System.Collections.Generic;
using System.Text;

namespace Toets_dubbele_klasse
{
    internal class Speler
    {
        int doelpunten;

        public int Doelpunten { get;  }
        public string Naam { get; set; }
        public int Rugnummer { get; set; }

        public void ScoorDoelpunt()
        {
            doelpunten++;
        }

        Speler()
        {

        }

        Speler(string naam, int rugnummer)
        {
            Naam = naam;
            Rugnummer = rugnummer;
        }

        public override string ToString()
        {
            return $"{Rugnummer}-{Naam}(doelpunten:{Doelpunten})";
        }
    }
}
