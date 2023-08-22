using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertising
{
    public class Person
    {
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Armor { get; set; }

        public Person()
        {
            Health = 0;
            Attack = 0;
            Armor = 0;
        }

    }
}
