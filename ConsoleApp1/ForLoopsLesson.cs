namespace ConsoleApp1;

public class ForLoopsLesson
{
    static void Main(string[] args)
    {
        for (int count = 1; count <= 5; count++)
        {
            Console.WriteLine("Hello World");
        }

        for (int row = 1; row <= 10; row++)
        {
            for (int col = 1; col <= 10; col++)
            {
                System.Console.Write($"{row * col} \t");
            }
            System.Console.WriteLine();
        }

        int[] array = { 1, 2, 3, 4, 5 };
        foreach (int item in array)
        {
            System.Console.WriteLine(item);
        }
        String[] colors = { "red", "black", "pink", "yellow", "white", "blue", "green" };
        foreach (String color in colors)
        {
            System.Console.WriteLine($"this is color {color}");
        }

        for (int row = 1; row <= 10; row++)
        {
            if (row == 5)
                {
                    break;
                }
            for (int col = 1; col <= 10; col++)
            {
                
                System.Console.Write($"{row * col} \t");
            }
            System.Console.WriteLine();
        }
    }
}