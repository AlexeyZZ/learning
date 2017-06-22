using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Car
    {
        public readonly int maxSpeed;
        int currentSpeed;
        public Car(int max)
        {
            this.maxSpeed = max;
        }
        public Car() { this.maxSpeed = 55; }
        public int Speed
        {
            get { return currentSpeed; }
            set
            {
                currentSpeed = value;
                if (currentSpeed > maxSpeed)
                { currentSpeed = maxSpeed; }
            }
        }
    }
}
