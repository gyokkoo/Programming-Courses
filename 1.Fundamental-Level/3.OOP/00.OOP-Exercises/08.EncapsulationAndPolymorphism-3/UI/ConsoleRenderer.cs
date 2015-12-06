using _08.EncapsulationAndPolymorphism_3.Interfaces;
using System;

namespace _08.EncapsulationAndPolymorphism_3.UI
{
    public class ConsoleRenderer : IRenderer
    {
        public void WriteLine(string message, params object[] parameters)
        {
            Console.WriteLine(message, parameters);
        }
    }
}