using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplain__Rservation
{
    public class Seat
    {
        int SeatNumber;
        string Category;
        double Price;
        string Status;
        public Seat()
        {
            SeatNumber = 0;
            Category = "";
            Price= 0;
            Status = "";
        }
        public Seat(int seatnumber, string category, double price, string status)
        {
            SeatNumber = seatnumber;
            Category = category;
            Price = price;
            Status = status;
        }
        public void SetSeatNumber(int seatnumber) 
        {
            SeatNumber = seatnumber; 
        }
        public int GetSeatNumber() 
        {
            return SeatNumber;
        }
        public void SetCategory(string category)
        {
            Category = category; 
        }
        public string GetCategory() 
        { 
            return Category;
        }
        public void SetPrice(double price) 
        {
            Price = price; 
        
        }
        public double GetPrice() 
        
        {
            return Price;
        }
        public void SetStatus(string status)
        {
            Status = status;
        }
        public string GetStatus() {
            return Status;
        }
        public void input()
        {
            Console.WriteLine("Enter the seat number [in number]");
            SeatNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the catagery buss or econ");
            Category = Console.ReadLine();
            Console.WriteLine("Enter the price [in number]");
            Price = Convert.ToInt32(Console.ReadLine());
        }
        public void Print() 
        {
            Console.WriteLine($"Seat {SeatNumber}: {Category}, {Price}");
        }
    }
}