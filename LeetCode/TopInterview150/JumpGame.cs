public class Solution {
    public bool CanJump(int[] nums) 
    {
        int goal = nums.Length-1;

        //We go backwards through the array
        //If we find we can move to the goal value, we move the goal to the next index
        //If we reach the end, that means we can move from the first index to the end
        //but if the index is >0 we cannot reach the initial index
        for(int i=nums.Length-1;i>=0;i--)
        {
            if(i + nums[i] >= goal)
            {
                goal = i;
            }
        }

        return goal == 0;
    }
}
