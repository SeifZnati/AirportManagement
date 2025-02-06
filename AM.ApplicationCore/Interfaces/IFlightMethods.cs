using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IFlightMethods
    {
        public IList<DateTime> GetFlightDates(string destination);

        public void GetFlights(string filterType, string filterValue);
    }
}
