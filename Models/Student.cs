using System;


namespace BasicOOPSRevise.Models
{
    public class Student : Person
    {
        private string courseCode;

        public Student(string name, int age, string course) : base(name, age)
        {
            courseCode = course;
        }


        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine($"I'm studying {courseCode}");
        }


        public void Study()
        {
            Console.WriteLine($"{Name} is studying {courseCode}");
        }


    }
}
