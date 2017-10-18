using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealTimeTechnicalAssesment.Classes;
using RealTimeTechnicalAssesment.Model;

namespace RealTimeTechnicalAssesment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a Low Number:");
            int low = int.Parse(Console.ReadLine());
            Console.Write("Please Enter a High Number:");
            int high = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            new NumbersRepository().PopulateModel(low, high);
            Numbers.ListOfNumbersToExclude.ForEach(r => Console.WriteLine(r));
        }
       
    }
}
