using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURS
{
    [Serializable]
    public class Currency
    {
        public double val { get; set; }
        public string date { get; set; }
        public string code { get; set; }
        public Currency(string Date, string Code, double Val)
        {
            val = Val;
            date = Date;
            code = Code;
        }
        public Currency()
        {
        }
    }
}
