public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> seen = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int needed = target - nums[i];

            if (seen.ContainsKey(needed))
            {
                return new int[] { seen[needed], i };
            }

            seen[nums[i]] = i;
        }

        return new int[0];
    }
}