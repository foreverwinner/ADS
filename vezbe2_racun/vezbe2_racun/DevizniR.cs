using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vezbe2_racun
{
    class DevizniR : Racun
    {
        public DevizniR(double id, double stanje) : base(id, stanje) { }

        public override void Uplata(double novac)
        {
            Stanje += novac-(novac*5)/100;
        }
        public override void Isplata(double novac)
        {
            Stanje-= novac - (novac * 5) / 100;
        }

        public override void Ispis()
        {
            base.Ispis();
            Console.Write(" deviznom je " + Stanje+"\n");
        }
    }
}
