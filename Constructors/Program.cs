using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Pesho Studenta");

            Console.WriteLine(student.name);

        }
    }
}
