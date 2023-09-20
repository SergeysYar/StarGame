using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGame
{
    // Класс "Метеорит"
    public class Meteorite : IObstacle
    {
        private string _name;
        private double _damage;

        public Meteorite(string name, double damage)
        {
            _name = name;
            _damage = damage;
        }

        public string GetName()
        {
            return _name;
        }

        public double GetDamage()
        {
            return _damage;
        }
    }
}
