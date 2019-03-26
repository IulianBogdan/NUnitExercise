using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nunitest
{
    class Car
    {
        private readonly ICarDetails _carDetails;

        public Car(ICarDetails carDetails)
        {
            _carDetails = carDetails;
        }
        public string GetCarDetails(int id)
        {
            var details = _carDetails.GetDetails(id);
            if (details == "BMW")
            {
                details += ", That's a great car!";
            }
            else
            {
                details += ", That's also a great car!";
            }
            return details;
        }
    }
}
