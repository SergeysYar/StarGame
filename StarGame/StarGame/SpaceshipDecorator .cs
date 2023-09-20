using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGame
{
    // Абстрактный декоратор
    public abstract class SpaceshipDecorator : ISpaceship
    {
        private ISpaceship _spaceship;

        public SpaceshipDecorator(ISpaceship spaceship)
        {
            _spaceship = spaceship;
        }

        public string GetName()
        {
            return _spaceship.GetName();
        }

        public double GetHullStrength()
        {
            return _spaceship.GetHullStrength();
        }

        public double GetMass()
        {
            return _spaceship.GetMass();
        }

        public abstract double GetTotalDamageResistance();

        public bool CanPassNebula(double density)
        {
            throw new NotImplementedException();
        }
    }
}
