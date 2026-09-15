public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var anagram = new Dictionary<string, List<string>>();

        List<List<string>> grpAnagrams = new List<List<string>>();
        for (int i = 0; i < strs.Length; i++) {
            char[] strArray = strs[i].ToCharArray();
            Array.Sort(strArray);
            var sortedKey = new string(strArray);
            if (!anagram.ContainsKey(sortedKey))
                anagram[sortedKey] = new List<string>();
            anagram[sortedKey].Add(strs[i]);
        }

        foreach (KeyValuePair<string, List<string>> kvp in anagram) {
            grpAnagrams.Add(kvp.Value);
        }

        return grpAnagrams;
    }
}
