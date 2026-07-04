public class Solution {
    public int[] TwoSum(int[] nums, int target) {
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if(numbers.TryGetValue(target - nums[i], out int j))
                {
                    return new int[] { j, i };
                }
                numbers.TryAdd(nums[i], i);
            }
        return new int[2] { 0, 0 };
    }
}