public class RunningTotal
{
    public static int[] runningTotals(int[] xs)
    {
        int currentTotal = 0;

        int[] total = new int[xs.Length];
        //result[0] = 0;
        for (int i = 0; i < xs.Length; i++)
        {

            currentTotal += xs[i];
            total[i] = currentTotal;
        }
        return total;
    }
}
