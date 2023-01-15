using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LokalniKontroler
{
    public enum Vrednost { open, close, on, off, analogMeasurement }

    public class LokalniKontroler
    {
        public string ImeLokalnogKontrolera { get; set; }

        //ovde nije int lupila sam
        public int TimeStamp { get; set; }

        public Vrednost ActualValue { get; set; }


        public LokalniKontroler() { }

        public LokalniKontroler(string imeLokalnogKontrolera, int timeStamp, Vrednost actualValue)
        {
            if (ImeLokalnogKontrolera == null )
            {
                throw new ArgumentNullException("Lokalni kontroler mora da ima ime");
            }

            if (ImeLokalnogKontrolera.Trim() == "")
            {
                throw new ArgumentException("Ime mora da sadrzi karaktere");
            }


            ImeLokalnogKontrolera = imeLokalnogKontrolera;
            TimeStamp = timeStamp;
            //nmp ovo
            //ActualValue = Vrednost(actualValue);
        }
    }
}
