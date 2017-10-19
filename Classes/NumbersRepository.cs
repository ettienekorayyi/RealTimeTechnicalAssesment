using RealTimeTechnicalAssesment.Interfaces;
using RealTimeTechnicalAssesment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeTechnicalAssesment.Classes
{
    public class NumbersRepository : IRepository
    {
        public NumbersRepository()
        {
            Numbers.ListOfNumbersToExclude = new List<int>();
        }
        public void PopulateModel(int lowNumber, int highNumber)
        {
            if(InputValidator.IsValid(lowNumber,highNumber) == true)
            {
                if (Numbers.ListOfNumbersToExclude.Count >= (highNumber - (lowNumber - 1))) 
                    return;
                Numbers.ListOfNumbersToExclude.Add(Utility.Random(lowNumber, highNumber));
                PopulateModel(lowNumber, highNumber);
            }
            else Console.WriteLine(Numbers.Valid);
        }
        
    }
}
