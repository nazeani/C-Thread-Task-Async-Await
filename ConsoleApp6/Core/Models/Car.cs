using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Car
    {
        public int Id { get; set; }
        private static int _id;
        public string Name { get; set; }
        public int Speed {  get; set; }
        public Car(string name,int speed)
        {
            Name = name;
            Speed = speed;
        }
        public override string ToString()
        {
            return $"Name:{Name}-Speed:{Speed}";
        }

    }
}
