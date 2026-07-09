public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string, List<string>> groups = 
        new Dictionary<string, List<string>>();

        for (int wordCount = 0; wordCount < strs.Length; wordCount++)
        {

            int[] count = new int[26];

            for ( int letterCount = 0; 
                letterCount < strs[wordCount].Length; 
                letterCount++)
            {
                count[strs[wordCount][letterCount] - 'a'] ++;
            }

            string key = string.Join("#", count);

            if (!groups.ContainsKey(key))
            {
                groups[key] = new List<string>();
            }

            groups[key].Add(strs[wordCount]);
        }

        return groups.Values.ToList();

    }
}
