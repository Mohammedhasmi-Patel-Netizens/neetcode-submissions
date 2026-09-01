public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        Dictionary<char,int> dic1 = new Dictionary<char,int>();
        Dictionary<char,int> dic2 = new Dictionary<char,int>();

        foreach(char ch in s){
            if(dic1.ContainsKey(ch)){
                int currentValue = dic1[ch];
                dic1[ch] = currentValue + 1;
            }else{
                dic1.Add(ch,1);
            }
        }

        foreach(char ch in t){
            if(dic2.ContainsKey(ch)){
                int currentValue = dic2[ch];
                dic2[ch] = dic2[ch] + 1;
            }else{
                dic2.Add(ch,1);
            }
        }

        return dic1.Count == dic2.Count && 
        dic1.All(x => dic2.ContainsKey(x.Key) && dic2[x.Key] == x.Value);
    }
}
