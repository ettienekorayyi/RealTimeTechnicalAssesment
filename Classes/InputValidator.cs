using RealTimeTechnicalAssesment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeTechnicalAssesment.Classes
{
    class InputValidator
    {
        public static bool IsValid(int lowNumber, int highNumber)
        {
            if (lowNumber > highNumber)
            {
                Numbers.Valid = "Warning! Low Number is greater than High Number!";
                return false;
            }
            else if (lowNumber < 1 || highNumber < 1)
            {
                Numbers.Valid = "Warning! Low Number is less than 1!";
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
