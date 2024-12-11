using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassLibrary
{
    public class LearnClass
    {
        public int TimeInSecunds(int a, int b)
        {
            return a * 3600 + b * 60;


        }
        public int SecondsInHours(int a)
        {
            return a / 3600;

        }
        public int SecondsInMinute(int a)
        {
            return a / 3600 %3600/ 60;

        }
    }
}
