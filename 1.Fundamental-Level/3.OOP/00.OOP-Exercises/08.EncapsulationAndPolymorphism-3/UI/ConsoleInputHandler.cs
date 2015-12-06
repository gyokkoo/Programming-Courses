using _08.EncapsulationAndPolymorphism_3.Interfaces;
using System;

namespace _08.EncapsulationAndPolymorphism_3.UI
{
    public class ConsoleInputHandler : IInputHandler
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
