public class Solution {
    public bool IsAnagram(string s, string t) {
        char [] s1 = s.ToCharArray();
        char [] t1 = t.ToCharArray();
           if((s1.Length!=t1.Length) || (s1.Length==0 || t1.Length==0)) return false;
            int [] charCount = new int[26];
           for(int i=0;i<s1.Length;i++){
            charCount[s1[i]-'a'] ++;
            charCount[t1[i]-'a'] --;
           }

           foreach(int cnt in charCount){
            if(cnt!=0)
                return false;
           }

           return true;

    }
}
