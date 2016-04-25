using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console
{
    public class Cat : Animal
    {
        public static readonly string catSound = "Meow";
        public Cat()
        {
            Sound = catSound;
        }
    }
}
