using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomSize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Joey's Room Size Calculator");

            Console.Write("What is the length of your classroom? ");
            decimal length = Convert.ToDecimal(Console.ReadLine());
            Console.Write("What is the width of your classroom? ");
            decimal width = Convert.ToDecimal(Console.ReadLine());
            decimal area = length * width;
            decimal perimiter = (2 * length + 2 * width);

            Console.WriteLine("The area of your room is: " + area + " sq ft");
            Console.WriteLine("The perimiter of your room is: " + perimiter + " ft.");

            if (area <= 250)
            {
                Console.WriteLine("You have a small room.");

            }
            else if (area > 250 && area < 650)
            {
                Console.WriteLine("You have a medium sized room.");
            }
            else
            {
                Console.WriteLine("You have a large room.");
            }


            Console.Write("What is the height of your classroom? ");
            decimal height = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("The volume of your room is:" + length * width * height + " ft cu");
            decimal surface = (2 * length * height + 2 * length * width + 2 * height * width);
            Console.WriteLine("The surface area of your room is: " + surface + " sq ft");
            Console.WriteLine("Thank you for using Joey's Room Size Calculator.");

            Console.ReadLine();
        }

    }
}