using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class FizickoLice
    {
        long jmbg;
        string ime;
        string prezime;

        public long Jmbg
        {
            get
            {
                return jmbg;
            }

            set
            {
                jmbg = value;
            }
        }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }

        public FizickoLice(long jmbg, string ime, string prezime)
        {
            this.jmbg = jmbg;
            this.ime = ime;
            this.prezime = prezime;
        }

        public FizickoLice() : this(0, "", "") { }

        public override string ToString()
        {
            return $"JMBG : {jmbg}, ime i prezime : {ime} {prezime}";
        }
    }
}
