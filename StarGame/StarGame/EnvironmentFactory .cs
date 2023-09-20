using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGame
{
    // Реализация фабрики для создания сред
    public class EnvironmentFactory : IEnvironmentFactory
    {
        public IEnvironment CreateEnvironment(string name, double length, double density)
        {
            // Здесь можно добавить логику создания разных типов сред на основе параметров
            // В данном примере мы создаем два типа сред: SpaceEnvironment и NebulaEnvironment
            // в зависимости от плотности нитринных частиц.

            if (density <= 1)
            {
                return new SpaceEnvironment(name, length);
            }
            else
            {
                return new NebulaEnvironment(name, length, density);
            }
        }

        public IEnvironment CreateEnvironment(string name, double length)
        {
            throw new NotImplementedException();
        }
    }
}
