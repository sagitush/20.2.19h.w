using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._2._19homework
{
    class SpiderMan:Human,IClimb
    {
        public int Speed { get; private set; }

        public SpiderMan(int speed,string name,int age):base(name,age)
        {
            Speed = speed;
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
        public void Climb()
        {
            Console.WriteLine("I climb higher");
        }
        public void ActiveSuperPowers()
        {
            Climb();
        }

        public override string ToString()
        {
            return $"Spiderman speed{Speed},{base.ToString()}";
        }
    }
}
