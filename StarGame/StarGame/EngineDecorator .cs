using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGame
{
    // Декоратор для добавления двигателя к кораблю
    public class EngineDecorator : SpaceshipDecorator
    {
        private double _enginePower;

        public EngineDecorator(ISpaceship spaceship, double enginePower) : base(spaceship)
        {
            _enginePower = enginePower;
        }

        public override double GetTotalDamageResistance()
        {
            return GetTotalDamageResistance() + _enginePower;
        }
    }
}
