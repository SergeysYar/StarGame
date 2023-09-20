using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGame
{
    // Класс Дефлектор
    public class Deflector
    {
        private string _type;
        private double _resistance;

        public Deflector(string type, double resistance)
        {
            _type = type;
            _resistance = resistance;
        }

        public string GetType()
        {
            return _type;
        }

        public double GetResistance()
        {
            return _resistance;
        }
    }
}
