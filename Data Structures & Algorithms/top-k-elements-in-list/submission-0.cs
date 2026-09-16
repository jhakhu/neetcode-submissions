public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        List<int> topFreq = new List<int>();
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int key = nums[i];
            if (!dict.ContainsKey(key)) {
                dict.Add(key, 1);
            } else {
                int val = dict[key];
                int ctr = val + 1;
                dict[key] = ctr;
            }
        }
        var orderedColl = dict.OrderByDescending(kvp => kvp.Value).Take(k).ToList();
        int [] arr = orderedColl.Select(kvp=>kvp.Key).ToArray();
        return arr;
    }
}
