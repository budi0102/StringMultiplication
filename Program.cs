using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputeList(ref Data);
            Console.ReadKey();
        }

        public static List<string> Data = new List<string>(new string[] { "cat", "dog", "meow", "bow", "elephant", "monkey", "human", "xxx", "funky" });

        public static bool Collision(ref string a, ref string b)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
            {
                return false;
            }

            Hashtable ht = new Hashtable();

            foreach (char c in a)
            {
                if (!ht.ContainsKey(c))
                    ht.Add(c, 1);
            }
            foreach (char c in b)
            {
                if (ht.ContainsKey(c))
                    return true;
            }

            return false;
        }

        public static int Compute(string a, string b)
        {
            if(string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
            {
                return 0;
            }
            if (Collision(ref a, ref b))
            {
                return 0;
            }

            return a.Length * b.Length;
        }

        public static void ComputeList(ref List<string> str)
        {
            if (str == null || str.Count <= 0)
            {
                return;
            }

            int result = 0;

            for (int i = 0; i < str.Count - 1; i++)
            {
                for (int j = i + 1; j < str.Count; j++)
                {
                    result = Compute(str[i], str[j]);
                    Console.WriteLine("{0}:<{1}> * {2}:<{3}> = {4}", i, str[i], j, str[j], result);
                }
            }
        }
    }
}
