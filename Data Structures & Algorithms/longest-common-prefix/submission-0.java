class Solution {
    public String longestCommonPrefix(String[] strs) {
        
        StringBuilder prefix = new StringBuilder(strs[0]);
        int n = strs.length;

        for(int i=1;i<n;i++){
            int j = 0;

            while(j < Math.min(prefix.length(),strs[i].length())){
                if(prefix.charAt(j) != strs[i].charAt(j)){
                    break;
                }
                j++;
            }

            prefix = new StringBuilder(prefix.substring(0,j));

        }
        return prefix.toString();
    }
}