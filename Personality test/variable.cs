using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personality_test
{
    internal class variable
    {
      
        public static decimal orange =0; 
        public static decimal gold =0;
        public static decimal blue = 0;
        public static decimal green = 0;
        public static string name = "";
        public static string _name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public static decimal _orange
        {
            get
            {
                return orange;
            }
            set
            {
                orange = value;
            }
        }
        public static decimal _blue
        {
            get
            {
                return blue;
            }
            set
            {
                blue = value;
            }
        }
        public static decimal _gold
        {
            get
            {
                return gold;
            }
            set
            {
                gold = value;
            }
        }
        public static decimal _green
        {
            get
            {
                return green;
            }
            set
            {
                green = value;
            }
        }
    }
}
