using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGame
{
    // Декоратор для добавления дефлекторов к кораблю
    public class DeflectorDecorator : SpaceshipDecorator
    {
        private List<Deflector> _deflectors;

        public DeflectorDecorator(ISpaceship spaceship, List<Deflector> deflectors) : base(spaceship)
        {
            _deflectors = deflectors;
        }

        public override double GetTotalDamageResistance()
        {
            double totalResistance = GetTotalDamageResistance();
            foreach (var deflector in _deflectors)
            {
                totalResistance += deflector.GetResistance();
            }
            return totalResistance;
        }
    }
}
