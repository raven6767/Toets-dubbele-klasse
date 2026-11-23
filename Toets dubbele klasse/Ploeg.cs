using System;
using System.Collections.Generic;
using System.Text;

namespace Toets_dubbele_klasse
{
    internal class Ploeg
    {
        List<Speler> spelers = new List<Speler>();

        public string PloegNaam { get; set; }
        public List<Speler> Spelers { get;}

        public int BerekenTotaalDoelPunten()
        {
            int totaalDoelPunten = 0;
            foreach (Speler item in spelers)
            {
                totaalDoelPunten = totaalDoelPunten + item.Doelpunten;
            }
            return totaalDoelPunten;
        }

        public List<Speler> GeefTopSchutter()
        {
            List<Speler> topSchutter=new List<Speler>();
            int doelpunten = 0;
            foreach (Speler item in spelers)
            {
                if (doelpunten<item.Doelpunten)
                {
                    topSchutter.Clear();
                    doelpunten = item.Doelpunten;
                    topSchutter.Add(item);
                }
                
            }
            return topSchutter;
        }

        Ploeg()
        {

        }
        Ploeg(string ploegNaam)
        {
            PloegNaam = ploegNaam;
        }

        public override string ToString()
        {
            return PloegNaam;
        }

        public void VerwijderSpeler(int index)
        {
            Spelers.RemoveAt(index);
        }

        public void VoegSpelerToe(string naam,int rugnummer)
        {
            List<Speler> objSpeler = new List<Speler>();
            spelers.Add(objSpeler);
        }
    }
}
