public class Solution 
{
    public int RemoveDuplicates(int[] nums) 
    {
        int pointerIndex = 1;

        for(int i=1;i<nums.Length;i++)
        {
            //Steps:
            //1. Check if current element is a duplicate
            //2. if the pointer index has more than 2 duplicates skip this one
            if(nums[i] != nums[pointerIndex - 1] || (pointerIndex < 2 || nums[i] != nums[pointerIndex-2]))
            {
                nums[pointerIndex] = nums[i];
                pointerIndex++;
            }
        }

        return pointerIndex;
    }
}
