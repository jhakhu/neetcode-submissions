public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
       
        Dictionary<string, List<string>> dicAnagram = new Dictionary<string, List<string>>();
        
        foreach(var s in strs) {
           int[] charArray = new int[26];
            foreach(char c in s){
                charArray[c-'a']++;
            }

            string key = string.Join(",", charArray);
          
            if (!dicAnagram.ContainsKey(key)) {
                dicAnagram[key] = new List<string>();
            }
            dicAnagram[key].Add(s);
        }

        return dicAnagram.Values.ToList<List<string>>();
    }
}
