using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eladasok
{
    class Vallalkozas : Vevo
    {
        string adoazonosito_szam; //-- xxxxxxxx-y-zz

        public string Adoszam { get => adoazonosito_szam; set => adoazonosito_szam = value; }

        public Vallalkozas(string neve, string adoszam, decimal vasarlas_osszege) : base(neve, vasarlas_osszege)
        {
            if (!AdoszamCheck(adoszam))
            {
                throw (new AdatbeviteliHiba("Érvénytelen adószám!"));
            }
            Adoszam = adoszam;
        }
        private bool AdoszamCheck(string input)
        {
            //-- Most csak a számjegyek számára tudunk ellenőrízni ----------------
            string szam = new string(input.Where(c => char.IsDigit(c)).ToArray());
            if (szam.Length==11)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public string toTXT()
        {
            return string.Join(";", "v", Id, Neve, adoazonosito_szam, Vasarlas_osszege);
        }

    }
}
