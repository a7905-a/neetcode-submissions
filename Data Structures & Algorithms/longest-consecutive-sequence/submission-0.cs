public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;

        Array.Sort(nums);

        int count = 1;
        int secutive = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1]) continue;
            if (nums[i] - nums[i - 1] == 1)
            {
                count++;
            }
            else
            {
                if (secutive <= count)
                {
                    secutive = count;
                }
                count = 1;
            }
        }

        return Math.Max(secutive, count);
    }
}
