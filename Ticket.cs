using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplain__Rservation
{
        class Ticket
        {
            int TicketNumber;
            Passenger Passenger;
            int SeatNumber;
            double Price;
            public Date Date;
            public Flight Flight;

        //flight

        public Ticket(Ticket ticket)
            {
                TicketNumber = ticket.TicketNumber;
                Passenger = ticket.Passenger;
                SeatNumber = ticket.SeatNumber;
                Price = ticket.Price;
                Date = ticket.Date;
                Flight = ticket.Flight;

        }

            public Ticket(int ticketNumber, Passenger passenger, int seatNumber, double price,Date D,Flight flight)
            {
                TicketNumber = ticketNumber;
                Passenger = passenger;
                SeatNumber = seatNumber;
                Price = price;
                Date = D;
                Flight = flight;

        }
        public Ticket() { }

            public void SetTicketNumber(int ticketNumber)
            {
                if (ticketNumber > 0 && ticketNumber <= 200)
                {
                    TicketNumber = ticketNumber;
                }
                else
                {
                    Console.WriteLine("Invalid Ticket Number!");
                }
            }

            public void SetPassenger(Passenger passenger)
            {
                Passenger = passenger;
            }

            public void SetSeatNumber(int seatNumber)
            {
                if (seatNumber > 0 && seatNumber <= 200)
                {
                    SeatNumber = seatNumber;
                }
                else
                {
                    Console.WriteLine("Invalid Seat Number!");
                }
            }

            public void SetPrice(double price)
            {
                if (price >= 0)
                {
                    Price = price;
                }
                else
                {
                    Console.WriteLine("Invalid Price!");
                }
            }


            public int GetTicketNumber()
            {
                return TicketNumber;
            }

            public Passenger GetPassenger()
            {
                return Passenger;
            }

            public int GetSeatNumber()
            {
                return SeatNumber;
            }

            public double GetPrice()
            {
                return Price;
            }


            public void Input()
            {
                Console.Write("Enter Ticket Number: ");
                SetTicketNumber(Convert.ToInt32(Console.ReadLine()));
                Console.Write("Enter Seat Number: ");
                SetSeatNumber(Convert.ToInt32(Console.ReadLine()));
                Console.Write("Enter Price: ");
                SetPrice(Convert.ToDouble(Console.ReadLine()));
               
            }



            public void Print()
            {
                Console.WriteLine("Ticket Number: " + TicketNumber);
                Console.WriteLine("Seat Number  : " + SeatNumber);
                Console.WriteLine("Price        : " + Price);
                Console.WriteLine("Passenger Details: ");
                Passenger.Print();
                Date.Print();
                Flight.print();


        }
        }
    }


