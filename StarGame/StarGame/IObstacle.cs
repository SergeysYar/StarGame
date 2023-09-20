using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGame
{
    // Интерфейс для препятствий
    public interface IObstacle
    {
        string GetName();
        double GetDamage();
    }
}
