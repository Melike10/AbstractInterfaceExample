using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExp
{
    // ortak değerleri tutan bir abstract class oluşturdum.
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Dept { get; set; }


        public Person(string fname, string lname, string dept)
        {
            this.FirstName = fname;
            this.LastName = lname;
            Dept = dept;
        }
    }
}
