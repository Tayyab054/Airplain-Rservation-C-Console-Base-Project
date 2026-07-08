using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Airplain__Rservation
    {
        class Program
        {
            static void Main(string[] args)
            {
                List<Flight> flights = new List<Flight>();
                List<Ticket> tickets = new List<Ticket>();
                List<Employee> employees = new List<Employee>();

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("\n===== Airline Reservation System =====");
                    Console.WriteLine("1. Add Flight");
                    Console.WriteLine("2. Update Flight");
                    Console.WriteLine("3. Cancel Flight");
                    Console.WriteLine("4. Search Flight");
                    Console.WriteLine("5. Check Seat Availability");
                    Console.WriteLine("6. Book Ticket");
                    Console.WriteLine("7. Cancel Ticket");
                    Console.WriteLine("8. Manage Employees (Pilots & Crew)");
                    Console.WriteLine("9. Exit");
                    Console.Write("Select an option: ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1)
                    {
                        Flight newFlight = new Flight();
                        newFlight.input();
                        flights.Add(newFlight);
                        Console.WriteLine("Flight added successfully!");
                    }
                    else if (choice == 2)
                    {
                        Console.Write("Enter Flight Number to Update: ");
                        int flightNum = Convert.ToInt16(Console.ReadLine());
                        for (int i = 0; i < flights.Count; i++)
                        {
                            if (flights[i].getFlightNumber() == flightNum)
                            {
                                flights[i].input();
                                Console.WriteLine("Flight updated successfully!");
                                break;
                            }
                        }
                    }
                    else if (choice == 3)
                    {
                        Console.Write("Enter Flight Number to Cancel: ");
                        int flightNum = Convert.ToInt16(Console.ReadLine());
                        for (int i = 0; i < flights.Count; i++)
                        {
                            if (flights[i].getFlightNumber() == flightNum)
                            {
                                flights.RemoveAt(i);
                                Console.WriteLine("Flight cancelled successfully!");
                                break;
                            }
                        }
                    }
                    else if (choice == 4)
                    {
                        Console.Write("Enter Flight Number to Search: ");
                        int flightNum = Convert.ToInt16(Console.ReadLine());
                        for (int i = 0; i < flights.Count; i++)
                        {
                            if (flights[i].getFlightNumber() == flightNum)
                            {
                                flights[i].print();
                                break;
                            }
                        }
                    }
                    else if (choice == 5)
                    {
                        Console.Write("Enter Flight Number to Check Seats: ");
                        int flightNum = Convert.ToInt16(Console.ReadLine());
                        for (int i = 0; i < flights.Count; i++)
                        {
                            if (flights[i].getFlightNumber() == flightNum)
                            {
                                flights[i].print();
                                break;
                            }
                        }
                    }
                    else if (choice == 6)
                    {
                        Ticket newTicket = new Ticket();
                        newTicket.Input();
                        tickets.Add(newTicket);
                        Console.WriteLine("Ticket booked successfully!");
                    }
                    else if (choice == 7)
                    {
                        Console.Write("Enter Ticket Number to Cancel: ");
                        int ticketNum = Convert.ToInt32(Console.ReadLine());
                        bool found = false;
                        for (int i = 0; i < tickets.Count; i++)
                        {
                            if (tickets[i].GetTicketNumber() == ticketNum)
                            {
                                tickets.RemoveAt(i);
                                Console.WriteLine("Ticket cancelled successfully!");
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("Ticket not found!");
                        }
                    }
                    else if (choice == 8)
                    {
                        Employee newEmployee = new Employee();
                        newEmployee.input();
                        employees.Add(newEmployee);
                        Console.WriteLine("Employee added successfully!");
                    }
                    else if (choice == 9)
                    {
                        Console.WriteLine("Exiting system...");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option! Please try again.");
                    }

                    Console.WriteLine("\nPress Enter to continue...");
                    Console.ReadLine();
                }
            }
        }
    }               