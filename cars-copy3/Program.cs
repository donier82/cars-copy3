using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cars_copy3
{
    internal class Program
    {
      

        class Cars
        {
            public int wheels;
            public float speed;
            public bool isworking;
            public void setr(int wheels, float speed, bool isworking)
            {
                this.wheels = wheels;
                this.speed = speed;
                this.isworking = isworking;
            }
            public void getr()
            {
                Console.WriteLine("wheels is: " + this.wheels+ " scored is: "+this.speed+"motors is: "+this.isworking);
            }
        }
       
        static void Main(string[] args)
        {
            Cars nexia = new Cars();
            nexia.setr(4, 180, true);
            nexia.getr();
        }
    }
}
