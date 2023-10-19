using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KoevaSJ.Sprint3.Task1.V30.Lib
{
    public class DataService : ISprint3Task1V30
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
           double sumSeries = 0;
           int k = startValue;
          
           while (startValue <= stopValue)
            {
                sumSeries = sumSeries + ((Math.Pow(value, k) + (5 / (k + 4))) * Math.Sin(value));
                startValue++;
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
