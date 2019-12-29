using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekPoşeti
{
    class Check : Payment
    {
        public string Code { get; set; }
        public int BankID { get; set; }
    }
}
