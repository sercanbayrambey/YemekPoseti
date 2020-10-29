using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekPoşeti
{
    class Credit : Payment
    {
        public string Number { get; set; }
        public string Type { get; set; }
        public DateTime ExpDate { get; set; }
    }
}
