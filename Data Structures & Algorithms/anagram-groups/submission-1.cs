public class Solution {

    public bool IsAnagram(string s1,string s2) {

        Dictionary<char,int> dic = new Dictionary<char,int>();

        for(int i=0;i<s1.Length;i++){
            if(dic.ContainsKey(s1[i])){
                dic[s1[i]]++;
            }else{
                dic[s1[i]] = i;
            }
        }

        for(int i=0;i<s2.Length;i++){
            if(dic[s2[i]]==0 || !dic.ContainsKey(s2[i])) return false;
                dic[s2[i]]--;
        }

        return true;
    }
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> arr = new List<List<string>>();
        Dictionary<string,List<string>> dic = new Dictionary<string,List<string>>();

        for(int i=0;i<strs.Length;i++){
            string currentStr = strs[i];
            char [] currentstrArr = currentStr.ToCharArray();
            Array.Sort(currentstrArr);
            string res = new String(currentstrArr);

            if(dic.ContainsKey(res)){
                List<string> valuesArr = dic[res];
                valuesArr.Add(currentStr);
                dic[res] = valuesArr;
            }else{
                dic[res] = [currentStr];
            }
        }

        foreach(var kv in dic){
            List<string> values = kv.Value;
            arr.Add(values);
        }
        return arr;
    }
}
