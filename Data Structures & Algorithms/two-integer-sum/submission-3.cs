public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> seen = new();

        for (int i = 0; i < nums.Length; i++)
        {
            int needed = target - nums[i];

            if (seen.TryGetValue(needed, out int index))
            {
                return new int[] { index, i };
            }

            seen[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}