using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KoevaSJ.Sprint3.Task6.V10.Lib
{
    public class DataService : ISprint3Task6V10
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int sum = 0;
            int result = 0;
            for (x = startValue; x <= stopValue; x++) 
            {
                for (int d = 13; d <= x; d++)
                {
                    if (x % d ==0)
                    {
                        sum += d;
                    }

                }
                if (sum > 12)
                {
                    result += sum;
                }
                sum = 0;

            }
            return result;
        }
    }
}
