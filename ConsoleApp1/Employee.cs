using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExp
{
    
   
    public class Employee:Person,ITitle
    {
       

        public Employee(string ad, string soyad,string dept):base(ad,soyad,dept) { 
            
            Console.WriteLine("Merhaba ben "+ dept+" departmanından "+ ad+" " + soyad+".");
        }

        public void Gorev(string data)
        {
            Console.WriteLine(data+ " olarak çalışmaktayım.");
        }
    }


}
