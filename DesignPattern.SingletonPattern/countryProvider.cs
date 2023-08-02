using DesignPattern.SingletonPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SingletonPattern
{
    public class CountryProvider
    {

        private static CountryProvider instance = null;
        public static CountryProvider Instance => instance ?? (instance = new CountryProvider());

        private new List<Country> Countries { get; set; }

        private CountryProvider()
        {
                // Retrieving data from db
                Task.Delay(1000).GetAwaiter().GetResult();    

                Countries = new List<Country>()
                {
                    new Country(){Name = "Turkey"},
                    new Country(){Name = "United Kingdom"}
                };
        }

        public async Task<List<Country>> GetCountries() => Countries;
    }
}
 