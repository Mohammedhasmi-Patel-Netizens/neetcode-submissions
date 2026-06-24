public class Solution {
    public bool IsAnagram(string s, string t) {
        if(t.Length != s.Length) return false;

        int [] counts = new int[256];

        for(int i=0;i<t.Length;i++){
           int idx = (int) t[i];
           counts[idx-1]++;
        }

        for(int i=0;i<s.Length;i++){
           int idx = (int) s[i];
            counts[idx-1]--;

            if(counts[idx-1] < 0){
                return false;
            }
        }

        return true;
    }
}
