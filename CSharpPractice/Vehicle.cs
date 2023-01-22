using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "1990";
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "Mustang";

        public abstract void DriveAbstract();//abstract - no implementation (stubbed out method)
       
        public virtual void DriveVirtual()
        {
            Console.WriteLine("This is virtual");
        }
    }
}
