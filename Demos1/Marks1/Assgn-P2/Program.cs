using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] studMarks = new int[4, 5]; // Rectangular array to store marks of 4 students

        // Input marks for each student
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"Enter details for Student {i + 1}:");
            Console.Write("RollNo: ");
            studMarks[i, 0] = int.Parse(Console.ReadLine());

            Console.Write("Sem1 Marks: ");
            studMarks[i, 1] = int.Parse(Console.ReadLine());

            Console.Write("Sem2 Marks: ");
            studMarks[i, 2] = int.Parse(Console.ReadLine());

            Console.Write("Sem3 Marks: ");
            studMarks[i, 3] = int.Parse(Console.ReadLine());

            Console.Write("Sem4 Marks: ");
            studMarks[i, 4] = int.Parse(Console.ReadLine());

            Console.WriteLine();
        }

        // Print the details
        Console.WriteLine("RollNo  Sem1  Sem2  Sem3  Sem4  Total");
        for (int i = 0; i < 4; i++)
        {
            int rollNo = studMarks[i, 0];
            int sem1 = studMarks[i, 1];
            int sem2 = studMarks[i, 2];
            int sem3 = studMarks[i, 3];
            int sem4 = studMarks[i, 4];
            int total = sem1 + sem2 + sem3 + sem4;

            Console.WriteLine($"{rollNo,-7} {sem1,-6} {sem2,-6} {sem3,-6} {sem4,-6} {total}");
        }

        Console.ReadLine();
    }
}