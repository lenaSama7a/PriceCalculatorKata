using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculatorKata
{
    public interface ICosts
    {
        public decimal Amount { get; set; }
        public void Description();
    }
}

