using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoevaSJ.Sprint3.Task3.V6.Lib;

namespace Tyuiu.KoevaSJ.Sprint3.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();

            string value = "12able 1o s4gh";

          
            char replacement = 't';

            string wait = "ttable to stgh";
            string res = ds.ReplaceNumOnChar(value, replacement);

            Assert.AreEqual(res, wait);




        }
    }
}
