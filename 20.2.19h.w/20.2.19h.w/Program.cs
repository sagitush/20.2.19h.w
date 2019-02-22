using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._2._19h.w
{
    class Program
    {
        static void Main(string[] args)
        {
            Person itamar = new Person(335, 34, 65.2f, "Itamar");
            Person noam = new Person(555, 9, 20.2f, "Noam");
            Person shir = new Person(777, 6, 17.2f, "Shir");
            Person alma = new Person(222, 2, 10.2f, "Alma");
            Person sagit = new Person(666, 34, 50.2f, "Sagit");
            Person[] persons = { itamar, noam, shir, alma, sagit };
            Array.Sort(persons, new PersonCompareByName());
            Console.WriteLine("name:");
            PrintPersonArray(persons);
            Array.Sort(persons, new PersonCompareById());
            Console.WriteLine("ID:");
            PrintPersonArray(persons);
            Array.Sort(persons, new PersonCompareByHeight());
            Console.WriteLine("Height:");
            PrintPersonArray(persons);
            Array.Sort(persons, new PersonCompareByAge());
            Console.WriteLine("Age");
            PrintPersonArray(persons);

        }
        static void PrintPersonArray(Person[]people)
        {
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
            
        }
    }
}
