using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Address
    {
        public Address( 
            string country,
            string county, string city,
            string streetName,
            string streetNUmber) 
        {
            if (string.IsNullOrWhiteSpace( country ) )
            {
                throw new ArgumentNullException(nameof(country));
            }

            if (string.IsNullOrWhiteSpace(county))
            {
                throw new ArgumentNullException(nameof(county));
            }

            if (string.IsNullOrWhiteSpace(city))
            {
                throw new ArgumentNullException(nameof(city));
            }

            if (string.IsNullOrWhiteSpace(streetName))
            {
                throw new ArgumentNullException(nameof(streetName));
            }

            if (string.IsNullOrWhiteSpace(streetNUmber))
            {
                throw new ArgumentNullException(nameof(streetNUmber));
            }
            Country = country;
            County = county;
            City = city;
            StreetName = streetName;
            StreetNumber = streetNUmber;
        }
        public string Country { get; }

        public string County { get; }

        public string City { get; }

        public string StreetName { get; }

        public string StreetNumber { get; }

      /*  private static void ValidateNotNullOrEmpty(string parameterValue, string parameterName)
        { 
            if (string)
        }   
      */
    }
}
