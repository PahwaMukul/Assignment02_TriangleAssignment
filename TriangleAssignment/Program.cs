using System;
namespace TriangleAssignment
{
    class Program
    {

        static int userinput;
        static int ValidatemenuSelection()
        {
            bool validMenuSelection = false;
            while (validMenuSelection == false)
            {
                Console.WriteLine("\n\nSelect the operation which you want to perform from below options.....\n");
                Console.WriteLine("1. Enter Triangle Dimensions");
                Console.WriteLine("2. Exit");
                try
                {
                    userinput = Convert.ToInt32(Console.ReadLine());
                    if (userinput != 1 && userinput != 2)
                    {
                        Console.WriteLine("\nInvalid menu option, please try again:\n");
                    }
                    else
                    {
                        validMenuSelection = true;
                    }
                }
                catch (Exception e)
                {   
                    Console.WriteLine("Invalid menu option, please try again:\n");
                }

            }

            return userinput;
        }

        static void Main(string[] args)
        {
            bool run = true;
            while (run = true)
            {
                int selection = ValidatemenuSelection();
                bool flag = true;
                while (flag == true)
                {
                    switch (selection)
                    {
                        case 1:
                            try
                            {
                                Console.WriteLine("\nEnter the 3 dimensions of the triangle:\n");
                                Console.WriteLine("Side A:");
                                int Side_A = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Side B:");
                                int Side_B = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Side C:");
                                int Side_C = Convert.ToInt32(Console.ReadLine());
                                if ((Side_A + Side_B > Side_C) && (Side_B + Side_C > Side_A) && (Side_A + Side_C > Side_B))
                                {
                                    Console.WriteLine("Triangle can be formed with these inputs.");
                                    string typeoftriangle = TriangleSolver.Analyze(Side_A, Side_B, Side_C);
                                    Console.WriteLine("This is a {0} triangle", typeoftriangle);
                                    flag = false;
                                }
                                else
                                {
                                    Console.WriteLine("Triangle can not be formed with these inputs");
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Invalid Line, Please try again");
                            }
                            break;

                        case 2:
                            run = false;
                            Environment.Exit(0);
                            break;
                    }

                }
            }
        }
    }
}


