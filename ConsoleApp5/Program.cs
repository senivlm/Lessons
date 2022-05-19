using System;

namespace qSSWU_.NET_camp;
 public class Program
{



	static void Main(string[] args)
    {
        Vector arr1 = new Vector(5);
        arr1.InitShuffle(0, 10);
        Console.WriteLine(arr1);

        Pair[] pairs = arr.CalculateFreq();
         for (int i = 0; i < pairs.Length; i++)
        {
            Console.WriteLine(pairs[i] + " ");
        }

        Console.WriteLine();
        //arr1.InitRandom(0, 10);
    }

}
