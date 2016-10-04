using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_10_3_16
{
    class Human
    {
        //Fields

        private string name;
        private int age;

        //Properties

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }


        public override string ToString()
        {
            return "Name = " + Name + ", Age = " + Age;




        }
    }
}
