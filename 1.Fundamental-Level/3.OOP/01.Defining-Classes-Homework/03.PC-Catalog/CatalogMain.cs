using System;
using System.Linq;

class CatalogMain
{
    public static void Main()
    {
        Component monitor = new Component("screen", 200);
        Component keyboard = new Component("keyboard", 43);
        Component mouse = new Component("mouse", 15);

        Component motherboard = new Component("motherboard", "G560 Intel Motherboard LA-5752P", 540);
        Component HDD = new Component("HDD", "256GB SSD", 200);
        Component proccesor = new Component("processor", " Intel Pentium G6950 (2.80 GHz, 3 MB)", 433);

        Computer firstPC = new Computer("Lenovo", motherboard, proccesor, HDD, monitor, mouse, keyboard);
        Computer secondPC = new Computer("HP", motherboard, proccesor, HDD, monitor);
        Computer thirdPC = new Computer("Acer", motherboard, proccesor, HDD);

        Computer[] arr = { firstPC, secondPC, thirdPC };

        arr = arr.OrderBy(pc => pc.Price()).ToArray();

        foreach (Computer pc in arr)
        {
            Console.WriteLine(pc.ToString());
        }
    }
}

