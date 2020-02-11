using System;
using System.Collections.Generic;
using System.Text;

namespace PowersOf
{
    public class PowerOf
    {
        public bool isPowerOf(int x, int powerToCheck)
        {
            // handle power of 1 case - all non negative integers are a power of 1
            if (powerToCheck == 1 && x >= 1)
            {
                return true;
            }

            if (!(x >= 1))
            {
                return false;
            }

            if (x == 1)
            {
                return true;
            }

            // check if x is evenly divisible by the power we want to test.
            if (!(x % powerToCheck == 0))
            {
                return false;
            }

            return isPowerOf(x / powerToCheck, powerToCheck);
        }
    }
}
