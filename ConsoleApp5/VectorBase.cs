namespace SSWU_.NET_camp
{
    public class VectorBase
    {




        public static Pair[] CalculateFreq()

        {
            Pair[] pairs = new Pair[arr.Length];

            for (int i = 0; i < arr.Length; i++)

            {
                pairs[i] = new Pair(0, 0);

            }
            int countDifference = 0;
            for (int i = 0; i < Array.Length; i++)

            {
                bool isElement = false;

                for (int j = 0; j < countDifference; j++)
                {
                    if (Array[i] == pairs[j].Number)

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
    }
}