using System;

namespace MenuExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
              
                Console.WriteLine("|              MENU OPTIONS                  |");
                Console.WriteLine("=============================================");
                Console.WriteLine("| 1. Print Rectangle                         |");
                Console.WriteLine("| 2. Print Square Triangle                   |");
                Console.WriteLine("| 3. Print Isosceles Triangle                |");
                Console.WriteLine("| 4. Exit                                    |");
                Console.WriteLine("=============================================");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                       

                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j <7; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                       

                        for (int i = 1; i <= 5; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                       

                        for (int i = 7; i >=1; i--)
                        {
                            for (int j = 0; j <=i ; j++)
                            {
                                Console.Write(" ");
                            }
                            for (int k = 0; k < 2 * i + 1; k++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 4);
        }
    }
}
