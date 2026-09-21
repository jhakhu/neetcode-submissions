public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        //O(n)
        foreach(var s in strs){
          sb.Append(s.Length).Append("#").Append(s);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> res = new List<string>();
        int i=0;
        while(i<s.Length){
            int j = i;
            while(s[j] != '#'){
                j++;
            }
                int len = int.Parse(s.Substring(i, j-i));
            
            i=j+1;
            j= i+len;
            res.Add(s.Substring(i, len));
            i=j;
        }
        return res;
   }
}
