public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 1; i <= nums.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] {j, i};
                }
            }
        }
        return new int[0];
    }
}
