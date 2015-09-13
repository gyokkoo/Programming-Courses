using System;
/*
Write a program, which creates an array of 20 elements of type integer and initializes 
each of the elements with a value equals to the index of the element multiplied by 5. 
Print the elements to the console. 
 */
class InitializingArray
{
    static void Main()
    {
        int[] myArray = new int[20];

        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = i * 5;
            Console.Write(myArray[i] + " ");
        }

        Console.WriteLine();
    }
}