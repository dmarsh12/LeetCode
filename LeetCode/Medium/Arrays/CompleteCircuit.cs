namespace LeetCode.Medium.Arrays;

public static class CompleteCircuit
{
    public static int Execute(int[] gas, int[] cost)
    {
        // var result = -1;
        // var max = -1;
        //
        var total = 0;
        var balance = 0;
        int start = 0;

        for (int i = 0; i < gas.Length; i++)
        {
            total += gas[i] - cost[i];
            balance += gas[i] - cost[i];
            if (balance < 0)
            {
                balance = 0;
                start = i+1;
            }
        }

        return total >= 0 ? start : -1;
    }
}