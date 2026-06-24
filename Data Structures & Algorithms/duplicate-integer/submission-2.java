class Solution {
    public boolean hasDuplicate(int[] nums) {
        Set<Integer> hm = new HashSet<>();

        for(int num : nums){
            if(hm.contains(num)){
                return true;
            }else{
                hm.add(num);
            }
        }

        return false;
    }
}
