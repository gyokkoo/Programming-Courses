using System;
/*
This problem is from the Java Basics Exam (1 June 2014).
*/
class StuckNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] nums = Console.ReadLine().Split(' ');

        bool isFound = false;

        for (int a = 0; a < n; a++)
        {
            for (int b = 0; b < n; b++)
            {
                for (int c = 0; c < n; c++)
                {
                    for (int d = 0; d < n; d++)
                    {
                        if ((nums[a] + nums[b]) == (nums[c] + nums[d]))
                        {
                            if (nums[a] != nums[b] && nums[a] != nums[c] &&
                                nums[a] != nums[d] && nums[b] != nums[c] &&
                                nums[b] != nums[d] && nums[c] != nums[d])
                            {
                                Console.WriteLine("{0}|{1}=={2}|{3}",
                                    nums[a], nums[b], nums[c], nums[d]);
                                isFound = true;
                            }
                        }
                    }
                }
            }
        }

        if (!isFound)
        {
            Console.WriteLine("No");
        }
    }
}