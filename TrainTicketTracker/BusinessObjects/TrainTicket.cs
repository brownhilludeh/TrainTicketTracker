using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketTracker.BusinessObjects
{
    /*
     * Class TrainTicket
     * @author Brownhill Udeh
     * @version 1.0
     * @since 2025-10-20
     * Description: This class is used to represent a train ticket tracker application 
     */
    internal class TrainTicket
    {
        //Private Attirbutes
        private string passengerName;
        private string ticketType;
        private string origin;
        private string destination;
        private string departure;
        private double ticketPrice;

        //public properties
        public string PassagerName { get => passengerName; set => passengerName = value; }
        public string TicketType { get => ticketType; set => ticketType = value; }
        public string Origin { get => origin; set => origin = value; }
        public string Destination { get => destination; set => destination = value; }
        public string Departure { get => departure; set => departure = value; }
        public double TicketPrice { get => ticketPrice; set => ticketPrice = value; }

        /*
         * Constructors
         * 
         * @param string passengerName
         * @param string ticketType
         * @param string origin
         * @param string destination
         * @param string departure
         * @param double ticketPrice
         * 
        */
        //Default
        public TrainTicket() { }

        //Parameterized
        public TrainTicket(string passengerName, string ticketType, string origin, string destination, string departure, double ticketPrice)
        {
            this.PassagerName = passengerName;
            this.TicketType = ticketType;
            this.Origin = origin;
            this.Destination = destination;
            this.Departure = departure;
            this.TicketPrice = ticketPrice;
        }

        //Static list of tickets object
        public static List<TrainTicket> tickets = new List<TrainTicket>();

        //Static collection of ticketType
        public static List<string> ticketTypes = new List<string>
        {
            "Minor",
            "Student",
            "Adult",
            "Senior"
        };

        //Overriding ToString method
        public override string ToString()
        {
            //return
            //    "Passenger Name: " + this.PassagerName + "\n" +
            //    "Ticket Type: " + this.TicketType + "\n" +
            //    "Origin: " + this.Origin + "\n" +
            //    "Destination: " + this.Destination + "\n" +
            //    "Departure: " + this.Departure + "\n" +
            //    "Ticket Price: " + this.TicketPrice + "\n";

            //inline tostring 
            return $"{PassagerName} | {TicketType} | {Origin} | {Destination} | {Departure} | {TicketPrice}";
        }
    }
}
