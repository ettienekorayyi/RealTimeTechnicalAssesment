using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealTimeTechnicalAssesment.Model;
using RealTimeTechnicalAssesment.Classes;

namespace RealTimeTechnicalAssesment.Classes
{
    public sealed class Utility
    {
        private static Random instance = null;
        private static readonly Object obj = new Object();
        public static Random GetInstance
        {
            get
            {
                lock (obj) { if(instance == null) instance = new Random();}
                return instance;
            }
        }
        
        public static int Random(int low, int high)
        {
            Numbers.RangeOfNumbers = Enumerable.Range(low, high).Where(i => !Numbers.ListOfNumbersToExclude.Contains(i)).ToList<int>();
            return Numbers.RangeOfNumbers.ElementAt(GetInstance.Next(0, high - Numbers.ListOfNumbersToExclude.Count()));
        }
    }
}
