using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi_1_OOP
{
    public enum TicketType
    {
        Standard,
        VIP,
        IMAX
    }

    public struct Seat
    {
        public char Row { get; set; }
        public int Number { get; set; }

        public Seat(char row, int number)
        {
            Row = row;
            Number = number;
        }

        public override string ToString()
        {
            return $"{Row}{Number}";
        }
    }
    internal class Ticket
    {
        public string MovieName { get; set; }
        public TicketType Type { get; set; }
        public Seat Seat { get; set; }

        private double Price;

        public Ticket(string _MovieName, TicketType _Type, Seat _Seat, double _Price)
        {
            MovieName = _MovieName;
            Type = _Type;
            Seat = _Seat;
            Price = _Price;
        }

        public Ticket(string movieName): this(movieName, TicketType.Standard, new Seat('A', 1), 50){}


        public double CalcTotal(double taxPercent)
        {
            double taxAmount = Price * taxPercent / 100;
            return Price + taxAmount;
        }

        public void ApplyDiscount(ref double discountAmount)
        {
            if (discountAmount > 0 && discountAmount <= Price)
            {
                Price -= discountAmount;
                discountAmount = 0;
            }
        }

        public void PrintTicket()
        {
            
            Console.WriteLine($"Movie: {MovieName}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Seat: {Seat}");
            Console.WriteLine($"Price: {Price:F2}");
            Console.WriteLine($"Total (14% tax): {CalcTotal(14):F2}");
            Console.WriteLine("========================");
        }



    }
}
