using _05.InheritanceAndAbstraction_2.Characters;
using System;

namespace _05.InheritanceAndAbstraction_2
{
    class AbstractionExercise
    {
        static void Main()
        {
            Priest p = new Priest();

            Warrior w = new Warrior();

            w.Attack(p);
            p.Heal(p);
        }
    }
}
