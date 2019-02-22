using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._2._19homework
{
    class SuperMan:Human,IFly
    {
        public int WebLeft { get;private set; }

        public SuperMan(int webLeft,int age,string name):base(name,age)
        {
            WebLeft = webLeft;
        }
        public override string Name
        {
            get
            {
                return Name;
            }

            set
            {
                if (Name != null)
                {
                    this.Name = Name;
                }
            }
        }
        public void Fly()
        {
            Console.WriteLine("I fly....");
        }
        public void ActiveSuperPowers()
        {
            Fly();
        }

        public override string ToString()
        {
            return $"Superman webleft:{WebLeft},{base.ToString()}";
        }
    }
}
