using System;
using System.Collections.Generic;
using System.Text;

namespace Studentenzeugnis
{
    public class Student
    {
        private string subject;
        private List<Module> modules;


        public string Subject 
        { 
            get => Subject = subject;
            private set 
            {
                subject = value;
            } 
        }
        public List<Module> Modules
        { 
            get => Modules = modules;
            private set
            {
                if (value.GetType() == typeof(List<Module>))
                {
                    modules = value;
                }
            }
        }


        public Student(string subject)
        {
            Subject = subject;
            List<Module> tempMod = new List<Module>();
            do
            {
                tempMod.Add(GetModule());

                Console.WriteLine("Möchten Sie ein weiteres Fach eingeben? (j/n)");

            } while (Console.ReadKey(true).Key == ConsoleKey.J);

            Modules = tempMod;
        }

        private Module GetModule()
        {
            Console.WriteLine("Name des Fachs:");
            string fach = Console.ReadLine();
            var tempMod = new Module(fach);

            return tempMod;
        }

    }
}
