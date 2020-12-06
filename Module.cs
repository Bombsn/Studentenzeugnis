using System;
using System.Collections.Generic;
using System.Text;

namespace Studentenzeugnis
{
    public class Module
    {
        private string subject;
        private float grade = 0.0f;
        
        
        public string Subject
        {
            get => Subject = subject;
            set
            {
                if (value != string.Empty || value == null)
                {
                    subject = value;
                }
            }
        }
        public float Grade
        { 
            get => Grade = (float)Math.Round(grade, 1);
            set 
            {
                if (value >= 1 && value <= 6)
                {
                    grade = value;
                }   
            }
        }


        public Module(string subject)
        {
            Subject = subject;
            float grade;
            bool result;
            do
            {
                Console.WriteLine($"Geben Sie die Note für das Fach {this.subject} ein:");
                result = float.TryParse(Console.ReadLine(), out grade);
                Grade = grade;
            } while (!result || Grade == 0); 
        }


        public string ToString(int length)
        {
            length = (length < 25) ? 25 : length;
            string gradeStr = GradeString(grade);
            string leerzeichen = new string(' ', length - Subject.Length - gradeStr.Length);

            return Subject + leerzeichen + gradeStr;
        }

        private string GradeString(float grade)
        {
            int gradeInt = (int)Math.Round(grade, 0);

            string gradeString;
            switch (gradeInt)
            {
                case 1:
                    gradeString = "übelst schlecht";
                    break;
                case 2:
                    gradeString = "absolute Schande";
                    break;
                case 3:
                    gradeString = "unterste";
                    break;
                case 4:
                    gradeString = "naja gerade so";
                    break;
                case 5:
                    gradeString = "gut";
                    break;
                case 6:
                    gradeString = "perfekt gespickt";
                    break;
                default:
                    gradeString = "nicht besucht";
                    break;
            }

            return gradeString;
        }
    }
}
