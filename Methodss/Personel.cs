using Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class Personel
    {
        public static string Information(string personName)
        {
            return personName;
        }

        //Kişi Adı ve İş Adı
        public static string Information(string personName, string jobName)
        {
            return personName + " " + jobName;
        }

        //Kişi Adı, İş Adı ve Alınan Maaş
        public static string Information(string personName, string jobName, string AlınanMaas)
        {
            return personName + " " + jobName + " " + AlınanMaas.ToString();
        }
    }
}
