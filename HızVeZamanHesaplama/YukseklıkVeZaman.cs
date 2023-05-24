using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızVeZamanHesaplama
{
    public static class YukseklıkVeZaman
    {
        public static string HesaplaAt(double hiz)
        {
            double g = 9.807; // dünyanın g kuvveti

            double yukseklik = (hiz * hiz) / (2 * g); // atış yüksekliği
            double zaman = hiz / g; // atma süresi

            string information = "Topun atıldığı yükseklik: " + Math.Round(yukseklik, 4) + " metre\n" +
                                 "Topun atıldığı süre: " + Math.Round(zaman, 4) + " saniye";
            return information;
        }
    }
}