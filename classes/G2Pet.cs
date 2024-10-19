using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_FP_01.classes
{
    class G2Pet
    {

        public string G2_name {  get; set; }
        public string G2_age { get; set; }
        public string G2_breed { get; set; }
        public G2Owner G2_owner { get; set; }
        public G2Pet() { }
        public G2Pet(string g2_name, string g2_age, string g2_breed, G2Owner g2_owner)
        {
            G2_name = g2_name;
            G2_age = g2_age;
            G2_breed = g2_breed;
            G2_owner = g2_owner;
        }
    }
}
