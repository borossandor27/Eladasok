using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eladasok
{
    class Maganszemely : Vevo
    {
        string adoazonosito_jel;
        DateTime szuletesi_datum;

        public string Adoazonosito { get => adoazonosito_jel; set => adoazonosito_jel = value; }
        public DateTime Szuletesi_datum { get => szuletesi_datum; set => szuletesi_datum = value; }

        public Maganszemely(string neve, string adoazonosito, DateTime szuletett, decimal vasarlas_osszege) : base(neve, vasarlas_osszege)
        {
            Szuletesi_datum = szuletett;
            if (!AdoazonositoCheck(adoazonosito))
            {
                throw (new AdatbeviteliHiba("Nem megfelelő adóazonosító!"));
            }
            Adoazonosito = adoazonosito;
        }
        
        private bool AdoazonositoCheck(string input)
        {
            string szam = new string(input.Where(c => char.IsDigit(c)).ToArray());
            if (szam.Length!=10)
            {
                //-- Nem megfelelő hooszúságú adat! ------------------
                return false;
            }
            //-- numerikus ellenőrzés
            if (!szam.Substring(0,1).Equals("8"))
            {
                //-- •	az 1. számjegy konstans 8-as szám, mely az adóalany magánszemély voltára utal ----------------
                return false;
            }
            if ((int)(szuletesi_datum-(new DateTime(1867,1,1))).TotalDays!=int.Parse(szam.Substring(1,5)))
            {
                //-- a 2–6. számjegyek a személy születési időpontja és az 1867. január 1. között eltelt napok száma
                return false;
            }
            double osszeg = 0;
            for (int i = 0; i < 9; i++)
            {
                osszeg += char.GetNumericValue(szam[i]) * (i + 1);
            }
            if (osszeg%11 != char.GetNumericValue(szam[9]))
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public string toTXT()
        {
            return string.Join(";", "m", Id, Neve, Szuletesi_datum.ToString("yyyy-MM-dd"), adoazonosito_jel, Vasarlas_osszege);
        }
    }
}
