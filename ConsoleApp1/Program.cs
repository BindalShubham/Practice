using System;
using System.Linq;

namespace PracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public int LargestPerimeter(int[] A)
        {
            Array.Sort(A);
            for (int i = A.Length - 3; i >= 0; --i)
                if (A[i] + A[i + 1] > A[i + 2])
                    return A[i] + A[i + 1] + A[i + 2];
            return 0;
        }

        public int[] Intersection(int[] nums1, int[] nums2)
        {
            if (nums2.Length > nums1.Length)
            {
                return nums1.Intersect(nums2).ToArray();
            }
            else
            {
                return nums2.Intersect(nums1).ToArray();
            }
        }

        public bool IsAnagram(string s, string t)
        {
            char[] ch1 = s.ToCharArray();
            char[] ch2 = t.ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            return val1 == val2;
        }
    }
}
