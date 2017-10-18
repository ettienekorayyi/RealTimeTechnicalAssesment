using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeTechnicalAssesment.Interfaces
{
    public interface IRepository
    {
        void PopulateModel(int lowNumber, int highNumber);
    }
}
