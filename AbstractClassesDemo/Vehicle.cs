using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace AbstractClassesDemo

{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "default make";
        public string Model { get; set; } = "default model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This{GetType().Name} is virtually in drive");

        }





    }

}
