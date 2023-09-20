using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGame
{
    // Класс для представления маршрута
    public class Route
    {
        private List<IEnvironment> _environments = new List<IEnvironment>();
        private List<IObstacle> _obstacles = new List<IObstacle>();

        public void AddEnvironment(IEnvironment environment)
        {
            _environments.Add(environment);
        }

        public void AddObstacle(IObstacle obstacle)
        {
            _obstacles.Add(obstacle);
        }

        public bool CanSpaceshipNavigate(ISpaceship spaceship)
        {
            foreach (var environment in _environments)
            {
                if (!environment.CanSpaceshipPass(spaceship))
                {
                    Console.WriteLine($"Корабль {spaceship.GetName()} не может пройти среду {environment.GetName()}");
                    return false;
                }
            }

            double hullStrength = spaceship.GetHullStrength();
            double totalDamageResistance = spaceship.GetTotalDamageResistance();

            foreach (var obstacle in _obstacles)
            {
                double damage = obstacle.GetDamage();
                if (damage > hullStrength)
                {
                    Console.WriteLine($"Корабль {spaceship.GetName()} уничтожен препятствием {obstacle.GetName()}");
                    return false;
                }

                double damageResistance = totalDamageResistance;
                if (obstacle is SpaceWhale spaceWhale)
                {
                    double size = spaceWhale.GetSize();
                    if (size > 10)
                    {
                        // Если размер космо-кита больше 10, то уменьшаем стойкость к урону
                        damageResistance -= (size - 10) * 0.1;
                    }
                }

                if (damage > damageResistance)
                {
                    Console.WriteLine($"Корабль {spaceship.GetName()} получил урон от препятствия {obstacle.GetName()}");
                    return false;
                }
            }

            Console.WriteLine($"Корабль {spaceship.GetName()} успешно преодолел маршрут!");
            return true;
        }
    }
}
