class Solution {

    public static String sortString(String s) {
        int[] freq = new int[26];   // count of each character

        // count frequency
        for (char c : s.toCharArray()) {
            freq[c - 'a']++;
        }

        // rebuild sorted string
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 26; i++) {
            while (freq[i]-- > 0) {
                sb.append((char)(i + 'a'));
            }
        }

        return sb.toString();
    }


    public List<List<String>> groupAnagrams(String[] strs) {
        HashMap<String,List<String>> hashmap = new HashMap<>();
        int n = strs.length;

        List<List<String>> list = new ArrayList<>();

        for(int i=0;i<n;i++){
            String ans = sortString(strs[i]);

            hashmap.putIfAbsent(ans,new ArrayList<>());
            hashmap.get(ans).add(strs[i]);
        }

        for(String key : hashmap.keySet()){
            list.add(hashmap.get(key));
        }

        return list;
    }
}
