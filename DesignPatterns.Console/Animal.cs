using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console
{
    public class Animal
    {
        private int weight;
        public string Name { get; set; }
        public int Weight
        {
            get { return weight; }
            set
            {
                if (value > 0) { weight = value; }
                else
                {
                    System.Console.WriteLine("Weight must be greater than zero");
                    weight = 0;
                }
            }
        }
        public string Sound { get; set; }
        public Animal()
        {

        }

    }
}
