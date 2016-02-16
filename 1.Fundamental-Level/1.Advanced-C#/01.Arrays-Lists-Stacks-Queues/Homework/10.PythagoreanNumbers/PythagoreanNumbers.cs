namespace _10.PythagoreanNumbers
{
    using System;

    public class PythagoreanNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            bool isFound = false;
            for (int a = 0; a < n; a++)
            {
                for (int b = 0; b < n; b++)
                {
                    for (int c = 0; c < n; c++)
                    {
                        if (nums[a] * nums[a] + nums[b] * nums[b] == nums[c] * nums[c])
                        {
                            if (nums[a] <= nums[b])
                            {
                                Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", nums[a], nums[b], nums[c]);
                                isFound = true;
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
}