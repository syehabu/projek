using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pewarisan
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Syeh";
            person.Age = 19;
            person.GetNameAndAge();

            Teacher teacher = new Teacher();
            teacher.Name = "Abu";
            teacher.Age = 35;
            teacher.TeacherId = "12345";
            teacher.Subject = "Math";
            teacher.GetNameAndAge();

            Students students = new Students();
            students.Name = "Laits";
            students.Age = 20;
            students.StudentsId = "18112306";
            students.Email = "Syeh20@amikom.ac.id";
            students.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
