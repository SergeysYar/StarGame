using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGame
{
    // Базовый класс корабля
    public class Spaceship : ISpaceship
    {
        private string _name;
        private double _hullStrength;
        private double _mass;

        public Spaceship(string name, double hullStrength, double mass)
        {
            _name = name;
            _hullStrength = hullStrength;
            _mass = mass;
        }

        public string GetName()
        {
            return _name;
        }

        public double GetHullStrength()
        {
            return _hullStrength;
        }

        public double GetMass()
        {
            return _mass;
        }

        public double GetTotalDamageResistance()
        {
            return _hullStrength / _mass;
        }

        public bool CanPassNebula(double density)
        {
            throw new NotImplementedException();
        }
    }
}
