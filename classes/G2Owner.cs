using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_FP_01.classes
{
    class G2Owner
    {
        public string G2_name { get; set; }
        public string G2_address { get; set; }
        public string G2_phone { get; set; }
        public G2Owner() { }
        public G2Owner(string g2_name, string g2_address, string g2_phone)
        {
            G2_name = g2_name;
            G2_address = g2_address;
            G2_phone = g2_phone;
        }
    }
}
