using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eladasok
{
    class Vevo
    {
        static int id = 0;
        int vevo_id;
        string neve;
        DateTime regisztracio_datuma;
        decimal vasarlas_osszege;

        public int Id { get => vevo_id;}
        public string Neve { get => neve; set => neve = value; }
        public DateTime Regisztracio_datuma { get => regisztracio_datuma; set => regisztracio_datuma = value; }
        public decimal Vasarlas_osszege { get => vasarlas_osszege; set => vasarlas_osszege = value; }

        public Vevo(string neve, decimal vasarlas_osszege)
        {
            vevo_id = id++;
            if (neve.Length<4)
            {
                throw new AdatbeviteliHiba("Túl rövíd név!");
            }
            Neve = neve;
            Vasarlas_osszege = vasarlas_osszege;
            Regisztracio_datuma = DateTime.Today;
        }
        public override string ToString()
        {
            //-- A listBox-ba ilyen formába tesszük bele -----------------
            return string.Join(",  ", Neve, Vasarlas_osszege.ToString("#,##0 Ft"));
        }

    }
}
