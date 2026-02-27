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


        }
    }
}
