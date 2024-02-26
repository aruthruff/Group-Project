using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter a character for the triangle:");
            char character = Console.ReadKey().KeyChar;

            Console.WriteLine("\nEnter the size of the peak for the triangle (max 10):");
            string sizeInput = Console.ReadLine();

            int size;
            if (!int.TryParse(sizeInput, out size) || size <= 0 || size > 10)
            {
                Console.WriteLine("Invalid input for size. Using default size 3 and default character '*'.");
                size = 3;
                character = '*';
            }

            PrintIsoscelesTriangle(character, size);

            Console.WriteLine("\nDo you want to print another triangle? (y/n)");
            char continueInput = Console.ReadKey().KeyChar;

            if (continueInput != 'y' && continueInput != 'Y')
                break;

            Console.Clear();
        }
    }

    static void PrintIsoscelesTriangle(char character, int size)
    {
        for (int i = 1; i <= size; i++)
        {
            for (int j = 0; j < size - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < 2 * i - 1; j++)
            {
                Console.Write(character);
            }

            Console.WriteLine();
        }
    }
}
