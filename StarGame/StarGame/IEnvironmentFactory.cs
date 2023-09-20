using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGame
{
    // Интерфейс для создания сред
    public interface IEnvironmentFactory
    {
        IEnvironment CreateEnvironment(string name, double length);
    }
}
