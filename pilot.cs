using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplain__Rservation
{
  
public class Pilot:Employee
    {
        public string LicenseNumber;

       
        public Pilot(Pilot other):base(other)
        {
            LicenseNumber = other.LicenseNumber;
        }
        public Pilot(string id, string name, int cell, string email, string DOB, double salary, string license) : base(id, name, cell, email, DOB, salary)
        {
            LicenseNumber = license;
        }

        public  void Print()
        {
            base.print();
            Console.WriteLine($"License: {LicenseNumber}");
        }

        public void Input()
        {
            base.input();
            Console.Write("Enter License Number: ");
            LicenseNumber = Console.ReadLine();
        }
    }
    }

