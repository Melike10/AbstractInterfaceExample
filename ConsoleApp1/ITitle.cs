using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExp
{
    public interface ITitle
    {
        // görev methodu interface'in içinde tutularak soyutlaştırıldı. Çünkü herkesin veri girişine göre değişecek
        void Gorev(string data);
    }
}
