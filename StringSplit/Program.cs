using System;

namespace StringSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReadLn(a,b,c);10 20 30 Pascal
            string s=Console.ReadLine();
            string[] ss = s.Split(" ");
            for(int i=0;i<ss.Length;i++)
                Console.WriteLine(ss[i]);
            int[] a = new int[ss.Length];
            for (int i = 0; i < ss.Length; i++)
                a[i] = Convert.ToInt32(ss[i]);

            //int[] b = Array.ConvertAll<string, int>(ss, new Converter<string, int>(Convert.ToInt32));

        }
    }
}
