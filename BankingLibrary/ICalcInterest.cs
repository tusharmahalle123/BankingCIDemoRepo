using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{
    interface ICalcInterest
    {
         int SimpInterest(int principle, int amount, int rate);
    }
}
