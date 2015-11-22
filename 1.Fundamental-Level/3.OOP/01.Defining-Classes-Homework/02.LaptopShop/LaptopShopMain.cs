using System;

class LaptopShopMain
{
    public static void Main()
    {
        Laptop firstLaptop = new Laptop(
            "Lenovo Yoga 2 Pro",
            "Lenovo",
            "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
            8,
            "Intel HD Graphics 4400",
            "128GB SSD",
            "13.3\"(33.78 cm) – 3200 x 1800(QHD +), IPS sensor display",
            new Battery("Li-Ion, 4-cells, 2550 mAh", 4.5),
            2259.00m);
        Laptop secondLaptop = new Laptop("Lenovo Yoga 2 Pro", 2259.00m);

        //Laptop thirdLaptop = new Laptop("Acer Laptop", -15);

        Console.WriteLine(firstLaptop.ToString());
        Console.WriteLine(secondLaptop.ToString());
        //Console.WriteLine(thirdLaptop.ToString());
    }
}

