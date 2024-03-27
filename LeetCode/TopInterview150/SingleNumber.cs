public class Solution {
    public int SingleNumber(int[] nums) 
    {
        HashSet<int> set = new HashSet<int>();
        int setSum = 0;
        int totalSum = 0;

        foreach(int num in nums)
        {
            if(!set.Contains(num))
            {
                set.Add(num);
                setSum += num;
            }
            totalSum+=num;
        }

        return 2 * setSum - totalSum;
    }
}
