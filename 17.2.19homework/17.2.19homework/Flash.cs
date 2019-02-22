using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._2._19homework
{
    class Flash : Human, IFlash
    {
        public  int Voltage { get;private set; }

        public Flash(int voltage, string name,int age):base(name,age)
        {
            Voltage = voltage;
            
        }

        public override string Name
        {
            get
            {
                return Name;
            }

            set
            {
                if (Name!=null)
                {
                    this.Name = Name;
                }
            }
        }

        public void FireLightnings()
        {
            Console.WriteLine("fire,fire");
        }
        public void ActiveSuperPowers()
        {
            FireLightnings();
        }

        public override string ToString()
        {
            return $"Flash volt{Voltage},{base.ToString()}";
        }
    }
}
