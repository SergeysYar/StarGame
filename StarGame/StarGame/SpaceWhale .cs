using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGame
{
    // Класс "Космо-кит"
    public class SpaceWhale : IObstacle
    {
        private string _name;
        private double _damage;
        private double _size;

        public SpaceWhale(string name, double damage, double size)
        {
            _name = name;
            _damage = damage;
            _size = size;
        }

        public string GetName()
        {
            return _name;
        }

        public double GetDamage()
        {
            return _damage;
        }

        public double GetSize()
        {
            return _size;
        }
    }

}
