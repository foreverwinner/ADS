using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
        [ServiceContract]
        public interface IFizickaLica
        {
            [OperationContract]
            void DodajLice(long jmbg, string ime, string prezime);

            [OperationContract]
            void ObrisiLice(long jmbg);

            [OperationContract]
            string SpisakLica();

        }
    
}
    /*
     Dodatne metode za vezbanje

            string PronadjiLicePoJMBG(long jmbg);

            List<string> PronadjiLicaPoImenu(string ime);

            List<string> PronadjiLicaPoPrezimenu(string prezime);

            bool PromeniImeLica(long jmbg, string ime);

            bool PromeniPrezimeLica(long jmbg, string prezime);
     */


