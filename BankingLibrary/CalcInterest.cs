using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{
    public class CalcInterest : ICalcInterest
    {
        public int SimpInterest(int principle, int amount, int rate)
        {
            int simpint = ( principle * amount * rate) / 100;
            return simpint;
        }
    }
}
