using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGame
{
    // Класс среды "Обычный космос"
    public class SpaceEnvironment : IEnvironment
    {
        private string _name;
        private double _length;

        public SpaceEnvironment(string name, double length)
        {
            _name = name;
            _length = length;
        }

        public string GetName()
        {
            return _name;
        }

        public double GetLength()
        {
            return _length;
        }

        public bool CanSpaceshipPass(ISpaceship spaceship)
        {
            // В данном примере, корабль всегда может пройти обычный космос
            return true;
        }
    }

}
