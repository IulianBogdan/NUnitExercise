using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nunitest
{
    class CarDetails : ICarDetails
    {
        private Dictionary<int, string> _carDetails = new Dictionary<int, string>() { { 1, "BMW" }, { 2, "Audi" } };
        public string GetDetails(int id)
        {
            var details = _carDetails.Where(x => x.Key == id).First().Value;
  
            return details;
        }
    }
}
