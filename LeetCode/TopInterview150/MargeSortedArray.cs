public class Solution 
{
    public void Merge(int[] nums1, int m, int[] nums2, int n) 
    {
        int nums2Index = 0;
        for(int i=m;i<nums1.Length;i++)
        {
            nums1[i] = nums2[nums2Index];
            nums2Index++;
        }

        Array.Sort(nums1);
    }
}
