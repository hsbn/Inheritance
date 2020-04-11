using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Habib", 20);
            person.GetNameAndAge();
            Console.WriteLine();
            Teacher teacher = new Teacher("Kamarudin", 35, "190302", "Pemrograman");
            teacher.GetNameAndAge();
            Console.WriteLine();
            Student student = new Student("Habib", 20, "19.11.2636", "habib.h@students.amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}