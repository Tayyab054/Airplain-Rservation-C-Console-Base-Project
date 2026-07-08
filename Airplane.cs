using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplain__Rservation
{

    public class Airplane
    {
        string AirplaneId;
        string Model;
        List<Seat> seats;

        public Airplane(Airplane other)
        {
            AirplaneId = other.AirplaneId;
            Model = other.Model;

        }

        public Airplane(string id, string model, List<Seat> seats)
        {
            AirplaneId = id;
            Model = model;
            this.seats = seats;
        }

        public void Print()
        {
            Console.WriteLine($"Plane {AirplaneId}<--->{Model}");
            for (int i = 0; i < seats.Count; i++)
            {
                seats[i].Print();
            }

        }

 
    }

    
}
