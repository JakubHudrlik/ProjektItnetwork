using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojistencuProjekt
{

    public class Pojistenec
    {

        

        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }
        public int Vek { get; private set; }
        public int TelCislo { get; private set; }
        /// <summary>
        /// Konstruktor pojištěnců
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="vek"></param>
        /// <param name="telCislo"></param>
        public Pojistenec(string jmeno, string prijmeni, int vek, int telCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelCislo = telCislo;
        }
       
        public override string ToString()                                                       //přepsání do vhodné formy pro výpis
        {
            return $"Pojištěnec: {Jmeno} {Prijmeni} Let: {Vek} Tel.: {TelCislo}";
        }
    }
}
