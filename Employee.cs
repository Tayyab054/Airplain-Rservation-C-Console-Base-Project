using System;

namespace Airplain__Rservation
{
    public class Employee
    {
        string EmployeeId;
        string Name;
        int CellNo;
        string Email; 
        string DOB;
        double Salary;
        public Employee() { }
        public Employee(string id, string name, int cell, string email, string DOB,double salary)
        {
            EmployeeId = id;
            Name = name;
            CellNo = cell;
            Email = email;
            this.DOB = DOB;
            Salary = salary;            
        }       

        public Employee(Employee E)
        {
            EmployeeId = E.EmployeeId;
            Name = E.Name;
            CellNo = E.CellNo;
            Email = E.Email;
            DOB = E.DOB;
            Salary = E.Salary;

        }
       public void setid(string id)
        {
            EmployeeId=id;
        }
        public void setname(string name)
        {
            Name = name;
        }
        public void setcell(int cell)
        {
            CellNo = cell;
        }
             
      public void print()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Cell No: {CellNo}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"DOB: {DOB}");
            Console.WriteLine($"Salary: {Salary}");
        }
        public void input()
        {
            Console.WriteLine("Enter Employee ID");
            EmployeeId = Console.ReadLine();
            Console.WriteLine("Enter Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Cell No");
            CellNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email");
            Email = Console.ReadLine();
            Console.WriteLine("Enter DOB");
            DOB = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            Salary = Convert.ToDouble(Console.ReadLine());
        }

    }
}
