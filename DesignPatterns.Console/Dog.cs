using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console
{
    public class Dog : Animal
    {
        public static readonly string dogSound = "Bark";
        public Dog()
        {
            Sound = dogSound;
        }
    }
}
