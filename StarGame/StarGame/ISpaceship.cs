using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGame
{
    // Интерфейс для кораблей
    public interface ISpaceship
    {
        string GetName();
        double GetHullStrength();
        double GetMass();
        double GetTotalDamageResistance();
        bool CanPassNebula(double density);
    }
}
