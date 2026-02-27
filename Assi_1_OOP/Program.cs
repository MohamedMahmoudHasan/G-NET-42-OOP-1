using MathLibrary;
using System.ComponentModel;
using System.Security.AccessControl;

namespace Assi_1_OOP
{
    internal class Program
    {
        struct PersonStruct
        {
            public string Name;
        }
        static void Main(string[] args)
        {
            //| Feature     | class                | struct                                  |
            //| ----------- | -------------------- | --------------------------------------- |
            //| Type        | Reference Type       | Value Type                              |
            //| Memory      | Heap                 | Stack(usually)                          |
            //| Assignment  | Copies reference     | Copies full value                       |
            //| Inheritance | Supports inheritance | Does NOT support inheritance            |
            //| Null        | Can be null          | Cannot be null (unless nullable struct) |

            PersonClass p1 = new PersonClass();
            p1.Name = "Mohamed";
            PersonClass p2 = p1;
            p2.Name = "Ahmed";
            Console.WriteLine(p1.Name);  

            PersonStruct s1 = new PersonStruct();
            s1.Name = "Mohamed";
            PersonStruct s2 = s1;
            s2.Name = "Ahmed";
            Console.WriteLine(s1.Name);

            /////////////////////////////////////////////////////////////////////////////////////////////////

            // public
            //Accessible from anywhere.

            // private
            //Accessible only inside the same class.

            PersonClass s = new PersonClass();
            s.Name = "Ali";     


            s.SetAge(20);
            Console.WriteLine(s.GetAge());

            /////////////////////////////////////////////////////////////////////////////////////////////////
            
            
            int result = Calculator.Add(5, 3);
            Console.WriteLine(result);

            /////////////////////////////////////////////////////////////////////////////////////////////////

            //What is a Class Library?

            //A Class Library is a collection of reusable classes, methods, and logic compiled into a DLL file.

            // Why Do We Use It ?

            // Code Reusability

            // Clean Project Structure

            // Team Collaboration

            // Security(hide internal implementation)

            // Faster Development

            /////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine();

            Console.Write("Enter Movie Name: ");
            string movie = Console.ReadLine();

            Console.Write("Choose Ticket Type (0 = Standard, 1 = VIP, 2 = IMAX): ");
            TicketType type = (TicketType)int.Parse(Console.ReadLine());

            Console.Write("Enter Seat Row (A,B,C...): ");
            char row = char.Parse(Console.ReadLine());

            Console.Write("Enter Seat Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter Price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Enter Discount Amount: ");
            double discount = double.Parse(Console.ReadLine());

            Seat seat = new Seat(row, number);

            Ticket ticket = new Ticket(movie, type, seat, price);

            Console.WriteLine();

            Console.WriteLine("===== Ticket Info =====");
            ticket.PrintTicket();

            ticket.ApplyDiscount(ref discount);

            //double total = ticket.CalcTotal(14);

            Console.WriteLine();
            Console.WriteLine("===== After Discount =====");
            ticket.PrintTicket();

        }
    }
}
