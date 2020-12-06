using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Studentenzeugnis
{
    class Program
    {
        public const int ZEUGNIS_ZEILENLAENGE = 55;

        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Console.WriteLine("Dieses Programm erstellt Zeugnisse.");

            do
            {
                Console.WriteLine("Name des Studenten:");
                students.Add(new Student(Console.ReadLine()));

                Console.WriteLine("Möchten Sie ein weiteres Zeugnis erfassen? (j/n)");
            } while (Console.ReadKey(true).Key == ConsoleKey.J);

            Console.WriteLine("Möchten Sie alle Zeugnisse ausgeben? (j/n)");
            if (Console.ReadKey(true).Key == ConsoleKey.J)
            {
                foreach (var stud in students)
                {
                    PrintReport(stud);
                }
            }

            Console.ReadKey();
        }


        static void PrintReport(Student student)
        {
            Console.WriteLine("\n\n" + new string('-', ZEUGNIS_ZEILENLAENGE));
            Console.WriteLine($"Zeugnis von {student.Subject}:\n");

            foreach (var mod in student.Modules)
            {
                Console.WriteLine(mod.ToString(ZEUGNIS_ZEILENLAENGE));
            }

            Console.WriteLine(new string('-', ZEUGNIS_ZEILENLAENGE));
            float average = student.Modules.Select(x => x.Grade).Average();
            Console.WriteLine("Durchschnittsnote" + new string(' ', ZEUGNIS_ZEILENLAENGE - 20) + string.Format("{0:0.0}", average));
            Console.WriteLine(new string('-', ZEUGNIS_ZEILENLAENGE));
        }
    }
}
