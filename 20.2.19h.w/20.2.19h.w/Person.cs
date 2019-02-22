using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._2._19h.w
{
    class Person : IComparable<Person>
    {
        public int Id { get; private set; }
        public int Age { get; private set; }
        public float Height { get; private set; }
        public string Name { get; private set; }

     
        public Person(int id, int age, float height, string name)
        {
            Id = id;
            Age = age;
            Height = height;
            Name = name;
        }
        private static readonly IComparer<Person> idComparer;
        private static readonly IComparer<Person> ageComparer;
        private static readonly IComparer<Person> heightComparer;
        private static readonly IComparer<Person> nameComparer;

        public IComparer<Person> IDComparer
        {
            get
            {
                return Person.idComparer;
            }
        }
        public IComparer<Person> AgeComparer
        {
            get
            {
                return Person.ageComparer;
            }
        }
        public IComparer<Person> HeightComparer
        {
            get
            {
                return Person.heightComparer;
            }
        }
        public IComparer<Person> NameComparer
        {
            get
            {
                return Person.nameComparer;
            }
        }

        static Person()
        {
            


        }

        public static void ModifyDefaultComparer(string b)
        {

        }



        public override string ToString()
        {
            return $"Person name:{Name}, ID:{Id}, Age:{Age}, Height:{Height}";
        }


        public int CompareTo(Person other)
        {
            return this.Id - other.Id;
        }
    }
    class PersonCompareById : IComparer<Person>
    {

        public int Compare(Person x, Person y)
        {
            return x.Id - y.Id;
        }


    }
    class PersonCompareByAge : IComparer<Person>
    {

        public int Compare(Person x, Person y)
        {
            return x.Age - y.Age;
        }
  

    }
    class PersonCompareByHeight : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Height-y.Height==0)
            {
                return 0;
            }
            else if(x.Height-y.Height>0)
            {
                return 1;
            }
            else 
            {
                return -1;
            }
          
        }
    }
    class PersonCompareByName : IComparer<Person>
    {

        public int Compare(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name);
        }


    }

}
