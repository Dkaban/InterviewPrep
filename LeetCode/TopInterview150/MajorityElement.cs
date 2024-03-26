public class Solution {
    public int MajorityElement(int[] nums) 
    {
        if(nums.Length == 1) return nums[0];

        Array.Sort(nums);
        int majorElement = 0;
        int majorElementCount = 0;
        int count = 0;

        for(int i=1;i<nums.Length;i++)
        {
            if(nums[i] == nums[i-1])
            {
                count++;

                if(count > majorElementCount)
                {
                    majorElement = nums[i];
                    majorElementCount = count;
                }
            }
            else
            {
                count = 0;
            }
        }

        return majorElement;
    }
}
