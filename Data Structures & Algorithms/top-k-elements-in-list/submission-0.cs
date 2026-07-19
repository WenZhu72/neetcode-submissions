public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        Dictionary<int, int> frequency = new();

        foreach(int num in nums)
        {
            if (frequency.ContainsKey(num))
            {
                frequency[num] += 1;
            }
            else
            {
                frequency.Add(num, 1);
            }
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach (var pair in frequency)
        {
            int number = pair.Key;
            int count = pair.Value;

            if (buckets[count] == null)
            {
                buckets[count] = new List<int>();
            }

            buckets[count].Add(number);
        }

        List<int> result = new();
        for (int i = buckets.Length - 1; i >= 0; i--)
        {
            if (buckets[i] != null)
            {
                foreach (int number in buckets[i])
                {
                    result.Add(number);

                    if (result.Count == k)
                    {
                        return result.ToArray();
                    }
                }
            }
        }

        return result.ToArray();
    }
}
