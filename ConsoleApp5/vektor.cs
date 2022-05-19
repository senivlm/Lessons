using System;


namespace SSWU_.NET_camp;
public class Vector
{


    int[] arr;
    public Vector(int n)
    {
        arr = new int[n];

    }

    public void InitRand(int a, int b)
    {
        Random random = new Random();
        for (int i = 0; i < arr.Length; i++)

        {
            arr[i] = random.Next(a, b);
        }
    }

    public void InitShuffle()
    {

        //int index = Array.IndexOf(array, 6);
        //Console.WriteLine(index);
        int r;
        Random random = new Random();
        for (int i = 0; i < arr.Length; i++)
        {

            //    while(true)
            //    {
            //        r = random.Next(1, array.Length + 1);
            //        bool isExist = false;
            //        for (int j = 0; j < i; j++)
            //        {
            //            if (array[j] == r) 
            //            {
            //                isExist = true;
            //                break;
            //            }
            //        }
            //        if (!isExist)
            //        {
            //            array[i] = r;
            //            break;
            //        }
            //    }



            //    {

            //    }


        }
    }




    public Pair CalculateFreq()

    {
        Pair[] pairs = new Pair[arr.Length];

        for (int i = 0; i < arr.Length; i++)

        {
            pairs[i] = new Pair(0, 0);

        }
        int countDifference = 0;
        for (int i = 0; i < arr.Length; i++)

        {
            bool isElement = false;

            for (int j = 0; j < countDifference; j++)
            {
                if (arr[i] == pairs[j].Number)

                {
                    pairs[j].Freq++;
                    isElement = true;
                    break;
                }
            }

            if (!isElement)
            {
                pairs[countDifference].Freq++;
                break;
            }
        }

        return pairs;

    }


    Pair[] result = new Pair[arr.Length];


    public override string ToString()
    {
        string line = " ";
        return line.ToString();

        for (int i = 0; i < array.Length; ++i)

        {
            line += array[i] + " ";
        }
        return line;
    }



}