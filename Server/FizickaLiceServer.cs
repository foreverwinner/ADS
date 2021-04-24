using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class FizickaLiceServer : IFizickaLica
    {
        public void DodajLice(long jmbg, string ime, string prezime)
        {
            if (!BazaPodataka.fizickaLica.ContainsKey(jmbg))
            {
                FizickoLice f = new FizickoLice(jmbg, ime, prezime);
                BazaPodataka.fizickaLica.Add(jmbg, f);
            }
        }

        public void ObrisiLice(long jmbg)
        {
            if (BazaPodataka.fizickaLica.ContainsKey(jmbg))
            {
                BazaPodataka.fizickaLica.Remove(jmbg);
            }
        }

        public string SpisakLica()
        {
            StringBuilder sb = new StringBuilder();

            foreach (FizickoLice f in BazaPodataka.fizickaLica.Values)
            {
                sb.AppendLine(f.ToString());
            }

            return sb.ToString();
        }
    }
}
