
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MySolution_class46
{
    class Program
    {
        
        static void Main(string[] args)
        {

            SalesPerson Darko = new SalesPerson() { FirstName = "Darko", LastName = "Stojanovski", Salary = 1000, Role = Role.Sales };
               
            Manager Dejan = new Manager() {FirstName="Dejan", LastName="Stefanovski", Salary=3000};

            Employee Kristina = new Employee() { FirstName = "Kristina", LastName = "Mladenova", Salary = 800, Role = Role.Other };

            Darko.AddSuccessRevenue(1200);

            Dejan.AddBonus(1800);

            Darko.PrintInfo();
            Dejan.PrintInfo();
            Kristina.PrintInfo();

            Console.ReadLine();

        }
           
    }
}
    


