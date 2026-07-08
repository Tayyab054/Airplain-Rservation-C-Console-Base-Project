using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplain__Rservation
{
    class laggage
    {
        int Id;
        double weight;
        public Ticket ticket;
        public laggage(int id, double w, Ticket ticket)
        {
            Id = id;
            weight = w;
            this.ticket = ticket;
            ticket = new Ticket();
        }
        public laggage() { }
       
        public void  Setweight(int w)
        {
            if (weight < 40)
            {
                weight = w;
            }
            else
            {
                Console.WriteLine("Invalid Weight");
            }
        }
        public void Setid(int id)
        {
            Id = id;
        }
       
        public void input()
        {
            Console.WriteLine("Enter The Id");
            Setid(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter The weight");
            Setweight(Convert.ToInt32(Console.ReadLine()));
            ticket.Input();
        }
        public void print()
        {
            Console.WriteLine($"Laggage ID\t{Id}\tWeight\t{weight}");
            ticket.Print();
        }
    }
}
