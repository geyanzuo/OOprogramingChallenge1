using System;
using ShapeProject;

namespace ShapeGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Shape Generator, Type [S] for generate Square, Type [R] to generate Rectangle...");
            string inputshape = Console.ReadLine();
            try
            {
                string InputShape = inputshape;
            }
            catch(InvalidCastException e)
            {
                Console.WriteLine("[Typing Erorr] Please Type [S] for generate Square, Type [R] to generate Rectangle", e);
            }
            

            if (inputshape == "S")
            {
                Console.WriteLine("You selected Square, please type the color");
                
                string scolor = Console.ReadLine();
                try
                {
                    string Scolor = scolor;
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine("[Typing Erorr]", e);
                }

                Console.WriteLine("Please type the side length");
                int side = int.Parse(Console.ReadLine());
                try
                {
                    int Side = side;
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine("[Typing Erorr]", e);
                }
                catch (LessThanZeroExecption)
                {

                }


                Square sq = new Square(scolor, side);

                Console.WriteLine("Your shape is a" + sq.Color + "Square, with Side Length: " + sq.SideLength1);

            }

            else if (inputshape == "R")
            {
                Console.WriteLine("You selected Square, please type the color");
                string color = Console.ReadLine();

                try
                {
                    string Color = color;
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine("[Typing Erorr]", e);
                }
                Console.WriteLine("Please type the length");
                int side1 = int.Parse(Console.ReadLine());

                try
                {
                    int Side1 = side1;
                }
                catch(InvalidCastException e)
                {
                    Console.WriteLine("[Typing Erorr]", e);
                }

                catch (LessThanZeroExecption)
                {

                }
                

                Console.WriteLine("Please type the width");
                int side2 = int.Parse(Console.ReadLine());

                try
                {
                    int Side2 = side2;
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine("[Typing Erorr]", e);
                }
                catch (LessThanZeroExecption)
                {

                }
                Rectangle re = new Rectangle(color, side1, side2);

                Console.WriteLine("Your shape is a" + re.Color + "Square, with Length: " + re.SideLength1 + " and width: " +re.SideLength2);
            }

            Console.ReadKey();
        }
    }
}
