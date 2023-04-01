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
                        Console.Write("Enter the width of the rectangle: ");
                        int width = int.Parse(Console.ReadLine());
                        Console.Write("Enter the height of the rectangle: ");
                        int height = int.Parse(Console.ReadLine());

                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < width; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        Console.Write("Enter the size of the triangle: ");
                        int size = int.Parse(Console.ReadLine());

                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j <= i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.Write("Enter the height of the triangle: ");
                        int triangleHeight = int.Parse(Console.ReadLine());

                        for (int i = 0; i < triangleHeight; i++)
                        {
                            for (int j = 0; j < triangleHeight - i; j++)
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
