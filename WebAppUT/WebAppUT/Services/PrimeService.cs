using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppUT.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }

            throw new NotImplementedException("Please create a test first");
        }

        public bool IsPrime5(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }

            throw new NotImplementedException("Please create a test first");
        }

        public async Task<bool> IsPrimeAsync(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }

            await Task.Delay(1000);

            throw new NotImplementedException("Please create a test first");
        }
    }
}
