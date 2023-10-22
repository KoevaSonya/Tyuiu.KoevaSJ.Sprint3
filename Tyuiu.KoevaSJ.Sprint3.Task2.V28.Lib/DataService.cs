using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KoevaSJ.Sprint3.Task2.V28.Lib
{
    public class DataService : ISprint3Task2V28
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double MultiplySeries = 1;
            do
            {
                MultiplySeries = MultiplySeries + ((Math.Pow(2, startValue) * Math.Cos(1.8)) / (startValue + 1));
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(MultiplySeries, 3);
        } 
    }
}
