// See https://aka.ms/new-console-template for more information

namespace AbstractClassExp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee("Melike", "Göz", "IT");
            employee.Gorev("Yazılım Geliştiricisi");

            Employee employee1 = new Employee("Ahmet", "Göz", "IK");
            employee1.Gorev("İş Sağlığı Güvenliği Uzmanı");
        }
    }
}
