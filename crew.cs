using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplain__Rservation
{
    public class crew:Employee
    {
         string Role;        
        public crew(crew other) :base(other)
        {
            Role = other.Role;
        }
       
        public crew(string id, string name,int cell,string email,string DOB,double salary, string role) : base(id, name, cell, email, DOB, salary)
        {
            Role = role;
        }     

        public  void Input()
        {
            base.input();
            Console.Write("Enter Crew Role: ");
            Role = Console.ReadLine();
        }
        public  void Print()
        {
            base.print();
            Console.WriteLine($"Role: {Role}");
        }
    }
}
