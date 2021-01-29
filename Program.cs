using System;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade do you expect to recieve in this course?");

            try
            {
                string input = Console.ReadLine();
                int grade = int.Parse(input);

                if((grade >= 98) && (grade <= 100))
                {
                    Console.WriteLine("Your letter grade would be A+");
                }
                else if((grade >= 92) && (grade <=97))
                {
                    Console.WriteLine("Your letter grade would be A");
                }
                else if ((grade >= 90) && (grade <= 91))
                {
                    Console.WriteLine("Your letter grade would be A-");
                }
                else if ((grade >= 88) && (grade <= 89))
                {
                    Console.WriteLine("Your letter grade would be B+");
                }
                else if ((grade >= 82) && (grade <= 87))
                {
                    Console.WriteLine("Your letter grade would be B");
                }
                 else if ((grade >= 80) && (grade <= 81))
                {
                    Console.WriteLine("Your letter grade would be B-");
                }
                else if ((grade >= 78) && (grade <= 79))
                {
                    Console.WriteLine("Your letter grade would be C+");
                }
                else if ((grade >= 72) && (grade <= 77))
                {
                    Console.WriteLine("Your letter grade would be C");
                }
                else if ((grade >= 70) && (grade <= 71))
                {
                    Console.WriteLine("Your letter grade would be C-");
                }
                else if ((grade >= 68) && (grade <= 69))
                {
                    Console.WriteLine("Your letter grade would be D+");
                }
                 else if ((grade >= 62) && (grade <= 67))
                {
                    Console.WriteLine("Your letter grade would be D");
                }
                else if ((grade >= 60) && (grade <= 61))
                {
                    Console.WriteLine("Your letter grade would be D-");
                }
                else
                {
                    Console.WriteLine("Your letter grade would be F");
                }
            }
            catch
            {
                Console.WriteLine("Please enter an interger.");
            }
        }
    }
}
