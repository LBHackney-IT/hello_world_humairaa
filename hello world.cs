using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// This is the namespace which means it will display 'Hello World' on the screen.
namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a variable which has an expression to display the message we want to add.
            string greeting = "Hello World!";
            //This will call the print method.
            Print(greeting);
            // This will stop hte console from closing, which means until the user doesn't press the key the console will not close.
            Console.ReadKey();
        }
        // This would print which is given in the method below, i.e. it will print hello world.
        static void Print(string input)
        {
            Console.WriteLine(input);              
        }
    }
}
