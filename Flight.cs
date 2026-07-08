using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplain__Rservation
{
    class Flight
        {
            int FlightNumber;
            string Origin;
            string Destination;
            public Time DepartureTime;
            public Date ArrivalTime;
            public List<Seat> Seats;
             public Flight()
            {
            FlightNumber = 0;
            Origin = "";
            Destination = "";
            ArrivalTime = new Date();
            Seats = new List<Seat>();

            }
            public Flight(Flight other)
            {
                FlightNumber = other.FlightNumber;
                Origin = other.Origin;
                Destination = other.Destination;
                DepartureTime = other.DepartureTime;
                ArrivalTime = other.ArrivalTime;
                Seats = other.Seats;
            }
            public Flight(int flightnumber, string origin, string destination, Time departuretime, Date arrivaltime, List<Seat> seats)
            {
                FlightNumber = flightnumber;
                Origin = origin;
                Destination = destination;
                DepartureTime = departuretime;
                ArrivalTime = arrivaltime;
                Seats = seats;
            }
         
        public void SetFlightNumbe(int f)
        {
            FlightNumber = f;
        }
        public int getFlightNumber()
        {
            return FlightNumber;
        }
        public string GetOrigin()
        {
            return Origin;
        }

        public void SetOrigin(string o)
        {
            Origin = o;
        }

        
        public string GetDestination()
        {
            return Destination;
        }

        public void SetDestination(string D)
        {
            Destination = D;
        }

        // Getter and Setter for DepartureTime
        public Time GetDepartureTime()
        {
            return DepartureTime;
        }

        public void SetDepartureTime(Time Dep)
        {
            DepartureTime = Dep;
        }

 
        public Date GetArrivalTime()
        {
            return ArrivalTime;
        }

        public void SetArrivalTime(Date Atime)
        {
            ArrivalTime = Atime;
        }

    
        public List<Seat> GetSeats()
        {
            return Seats;
        }

        public void SetSeats(List<Seat> Se)
        {
            Seats = Se;
        }


        public void input()
            {
                Console.WriteLine("Enter Flight Number [In number]");
                FlightNumber = Convert.ToInt32( Console.ReadLine());
                Console.WriteLine("Enter Origin [in word]");
                Origin = Console.ReadLine();
                Console.WriteLine("Enter Destination [in word]");
                Destination = Console.ReadLine();               
                Seat S = new Seat();
                S.input();
                Seats.Add(S);
                
            }
            public void print()
            {
                Console.WriteLine($"Flight Number\t{FlightNumber}\tOrigin{Origin}\tDestination{Destination}\tDeparture Time{DepartureTime}\tArrival Time{ArrivalTime}");
                for (int i = 0;i<Seats.Count;i++)
                {
                Seats[i].Print();
                }
            }
        }
    }



