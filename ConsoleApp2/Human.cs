using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Human
    {
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                {
                    age = value;

                }
            }
        }
    }
}
