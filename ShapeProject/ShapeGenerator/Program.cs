using System;
using ShapeProject;

namespace ShapeGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This is Shape Generator, Type [S] for generate Square, Type [R] to generate Rectangle...");
            
               
            string inputshape = Console.ReadLine().ToUpper();
            try
            {
                if (inputshape != "S" && inputshape != "R")
                    throw new IndexOutOfRangeException();

                if (inputshape == "S")
                {
                    Console.WriteLine("You selected Square, please type the color");

                    string scolor = Console.ReadLine();


                    Console.WriteLine("Please type the side length");

                    try
                    {
                        int side = int.Parse(Console.ReadLine());
                        try
                        {
                            if (side < 1)
                                throw new LessThanOneExecption();

                            Square sq = new Square(scolor, side);

                            Console.WriteLine("Your shape is a " + sq.Color + " Square, with Side Length: " + sq.SideLength1);
                        }
                        catch (LessThanOneExecption)
                        {
                            Console.WriteLine("The side length must be 1 or greater");
                        }
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("You must type number for side length");
                    }

                    




                }

                else if (inputshape == "R")
                {
                    Console.WriteLine("You selected Square, please type the color");
                    string color = Console.ReadLine();


                    Console.WriteLine("Please type the length");
                    

                    try
                    {
                        int side1 = int.Parse(Console.ReadLine());

                        try
                        {
                            if (side1 < 1)
                                throw new LessThanOneExecption();

                            try
                            {
                                int side2 = int.Parse(Console.ReadLine());

                                try
                                {
                                    if (side2 < 1)
                                        throw new LessThanOneExecption();

                                    Rectangle re = new Rectangle(color, side1, side2);

                                    Console.WriteLine("Your shape is a " + re.Color + " uare, with Length: " + re.SideLength1 + " and width: " + re.SideLength2);
                                }
                                catch (LessThanOneExecption)
                                {
                                    Console.WriteLine("The side length must be 1 or greater");
                                }

                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("You need to put number for side length");
                            }
                        }
                        catch (LessThanOneExecption)
                        {
                            Console.WriteLine("The side length must be 1 or greater");
                        }

                        Console.WriteLine("Please type the width");

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("You need to put number for side length");
                    }

                   
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("You Need to type [S] or [R] to create shape");
            }



           

            

            

            Console.ReadKey();
        }
    }
}
