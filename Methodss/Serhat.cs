using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodss
{
    public static class Serhat
    {
        //Only PersonelName
        public static string Customer(string namePersonel)
        {
            return namePersonel;
        }
        //Only PersonelName JobName
        public static string Customer(string namePersonel, string nameJob)
        {
            return namePersonel + " " + nameJob;
        }
        //Only PersonelName JobName AlınanMaas
        public static string Customer(string namePersonel, string nameJob, string AlınanMaas)
        {
            return namePersonel + " " + nameJob + " " + AlınanMaas;
        }
        //==================================
        public static int Add(int number1,int number2)
        {
            return number1+ number2;
        }
        public static int Add(int number1)
        {
            return number1;
        }
        public static int Add(int number1, int number2,int number3)
        {
            return number1 * number2*number3;
        }
    
    }
}
