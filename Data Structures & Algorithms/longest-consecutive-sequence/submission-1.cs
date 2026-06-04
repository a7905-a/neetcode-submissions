public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;

        HashSet<int> numbers = new HashSet<int>(nums);
        int consecutive = 0;

        foreach (int number in numbers)
        {
            if (!numbers.Contains(number - 1))
            {
                int currentNum = number;
                int count = 1;

                while(numbers.Contains(currentNum + 1))
                {
                    currentNum++;
                    count++;
                }

                if (consecutive <= count)
                {
                    consecutive = count;
                }
            }
        }
        return consecutive;
    }
}
