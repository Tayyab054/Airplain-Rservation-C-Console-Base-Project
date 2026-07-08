using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplain__Rservation
{
    class Airline
       
    {

        string CompanyName;
        string CellNo;
        string Country;
        string licence;
        public List<Airplane> Airplanes  = new List<Airplane>();
        public Airline(string companyname, string cellno, string country, string Licence, Airplane airplanes)
        {
            CompanyName = companyname;
            CellNo = cellno;
            Country = country;
            licence = Licence;
            Airplane airplane = airplanes;
        }

        public Airline()
        {
        }

        public void Add_Airplain(Airplane p)
        {
            Airplanes.Add(p);
        }
        public void  input()
        {
        Console.WriteLine("Enter  Company Name");
            CompanyName = Console.ReadLine();
            Console.WriteLine("Enter Cell No");
            CellNo = Console.ReadLine();
            Console.WriteLine("Enter Country");
            Country = Console.ReadLine();
            Console.WriteLine("Enter Licence");
            licence = Console.ReadLine();
            Console.WriteLine("Enter Airplane");
            
            
        }
        public void print()
        {
            Console.WriteLine($"Compnay Name\t{CompanyName}\tCell number{CellNo}\tCountry{Country}Licence{licence}");
            foreach (Airplane p in Airplanes)
            {
                p.Print();
            }

        }
    }
}
