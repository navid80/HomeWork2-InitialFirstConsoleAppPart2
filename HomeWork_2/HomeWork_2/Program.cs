using HomeWork_2.Exercise_3;
using HomeWork_2.Exercise_4;

public class Program
{
    //Exercise 3
    public void Exercise_3()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int num3 = int.Parse(Console.ReadLine());

        int result;

        Statistics statistics = new Statistics();
        Console.WriteLine($"Number 1 :{num1}, Number 2 : {num2}, Number 3 : {num3}");
        statistics.AnalyzeNumbers(num1, ref num2, out result);
        Console.WriteLine($"Number 1 :{num1}, Number 2 : {num2}, Number 3 : {result}");
    }

    //Exercise 4
    public void Exercise_4()
    {
        Console.Write("Enter array length: ");
        int length = int.TryParse(Console.ReadLine(), out int input) ? input : 0;

        int[] numbers = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write($"Enter number {i + 1} : ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int max = 0;
        double average;
        ArrayAnalyzer arrayAnalyzer = new ArrayAnalyzer();

        arrayAnalyzer.AnalyzeArray(numbers, ref max, out average);

        Console.WriteLine($"Max : {max}, Average : {average}");
    }

    public static void Main()
    {
        Program program = new Program();

        Console.Write("Choose an exercise (3 or 4): ");
        int exercise = int.Parse(Console.ReadLine());

        switch (exercise)
        {
            case 3:
                program.Exercise_3();
                break;
            case 4:
                program.Exercise_4();
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter 3 or 4.");
                break;
        }
    }
}

