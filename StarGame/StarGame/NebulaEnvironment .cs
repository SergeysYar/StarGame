using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGame
{
    // Класс среды "Туманность нитринных частиц"
    public class NebulaEnvironment : IEnvironment
    {
        private string _name;
        private double _length;
        private double _density;

        public NebulaEnvironment(string name, double length, double density)
        {
            _name = name;
            _length = length;
            _density = density;
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
            // Проверка, может ли корабль пройти туманность нитринных частиц,
            // учитывая плотность частиц и характеристики корабля
            return spaceship.CanPassNebula(_density);
        }
    }
}
