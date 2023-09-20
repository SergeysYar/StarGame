using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGame
{
    // Интерфейс для среды
    public interface IEnvironment
    {
        string GetName();
        double GetLength();
        bool CanSpaceshipPass(ISpaceship spaceship);
    }
}
