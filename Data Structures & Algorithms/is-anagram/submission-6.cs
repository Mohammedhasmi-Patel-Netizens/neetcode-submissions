public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        Dictionary<char,int> dic1 = new Dictionary<char,int>();

        foreach(char ch in s){
            if(dic1.ContainsKey(ch)){
                int currentValue = dic1[ch];
                dic1[ch] = currentValue + 1;
            }else{
                dic1.Add(ch,1);
            }
        }

        foreach(char ch in t){
            if(!dic1.ContainsKey(ch)) return false;
            // get current value 
            int value = dic1[ch];
            // already value become zero so in one string the character is extra 
            if(value == 0) return false;

            dic1[ch] = dic1[ch] - 1;
        }
return true;

    }
}
