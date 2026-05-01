public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hashList = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
           if(hashList.Add(nums[i]) == false)
           {
            return true;
           }
        }
        return false;

        
    }
}