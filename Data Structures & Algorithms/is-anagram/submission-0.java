class Solution {
    public boolean isAnagram(String s, String t) {

        HashMap<Character, Integer> map = new HashMap<>();

        if(s.length() != t.length()){
            return false;
        }

        for(int i=0;i<s.length();i++){
            char ch = s.charAt(i);
            int value = map.getOrDefault(ch,0);

            map.put(ch,value+1);
        }

        for(int i=0;i<t.length();i++){
            char ch = t.charAt(i);
            int value = map.getOrDefault(ch,0);

            if(value == 0){
                return false;
            }

            int val = (int) map.put(ch,value-1);

            if(val < 0){
                return false;
            }
        }

        for(char ch : map.keySet()){
            int value = map.get(ch);
            if(value != 0){
                return false;
            }
        }

        return true;


    }
}
