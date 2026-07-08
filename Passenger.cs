using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplain__Rservation
{
    class Passenger
    {
        string PassengerName;
        string CNIC;
        string PassportNumber;
        char Gender;
        int Age;
        string Email;
        string CellNo;
        public Passenger(Passenger passenger)
        {
         
            PassengerName = passenger.PassengerName;
            CNIC = passenger.CNIC;
            PassportNumber = passenger.PassportNumber;
            Gender = passenger.Gender;
            Age = passenger.Age;
            Email = passenger.Email;
            CellNo = passenger.CellNo;
           
        }


        public Passenger(string passengername, int age, string cnic, string passportnumber, char gender, string email, string cellno)
        {
            PassengerName = passengername;
            CNIC = cnic;
            PassportNumber = passportnumber;
            Gender = gender;
            Age = age;
            Email = email;
            CellNo = cellno;
           
        }


        public void SetName(string name)
        {
            PassengerName = name;
        }

        public void SetAge(int age)
        {
            if (age > 0)
            {
                Age = age;
            }
            else
            {
                Console.WriteLine("Invalid Age!");
            }
        }

        public void SetCNIC(string cnic)
        {
            CNIC = cnic;
        }

        public void SetPassportNumber(string passportNumber)
        {
            PassportNumber = passportNumber;
        }

        public void SetGender(char gender)
        {
            if (gender == 'M' || gender == 'F')
            {
                Gender = gender;
            }
            else
            {
                Console.WriteLine("Invalid Gender. Must be 'M' or 'F'.");
            }
        }

        public void SetEmail(string email)
        {
            Email = email;
        }

        public void SetCellNo(string cellNo)
        {
            CellNo = cellNo;
        }


        public string GetName()
        {
            return PassengerName;
        }

        public int GetAge()
        {
            return Age;
        }

        public string GetCNIC()
        {
            return CNIC;
        }

        public string GetPassportNumber()
        {
            return PassportNumber;
        }

        public char GetGender()
        {
            return Gender;
        }

        public string GetEmail()
        {
            return Email;
        }

        public string GetCellNo()
        {
            return CellNo;
        }


        public void Input()
        {
            Console.Write("Enter Name of Passenger: ");
            SetName(Console.ReadLine());
            Console.Write("Enter Age of Passenger: ");
            SetAge(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter CNIC of Passenger: ");
            SetCNIC(Console.ReadLine());
            Console.Write("Enter Passport Number of Passenger: ");
            SetPassportNumber(Console.ReadLine());
            Console.Write("Enter Gender of Passenger (M/F): ");
            SetGender(Convert.ToChar(Console.ReadLine()));
            Console.Write("Enter Email of Passenger: ");
            SetEmail(Console.ReadLine());
            Console.Write("Enter Cell No of Passenger: ");
            SetCellNo(Console.ReadLine());
        }

        public void Print()
        {
 
            Console.WriteLine("Name:       " + PassengerName);
            Console.WriteLine("Age:        " + Age);
            Console.WriteLine("CNIC:       " + CNIC);
            Console.WriteLine("Passport:   " + PassportNumber);
            Console.WriteLine("Gender:     " + Gender);
            Console.WriteLine("Email:      " + Email);
            Console.WriteLine("Cell No:    " + CellNo);
        }
    }
}
