class Solution {
    public boolean hasDuplicate(int[] nums) {
        int count = 1;

        for(int i=0;i<nums.length;i++){
            for(int j=i+1;j<nums.length;j++){
                if(nums[i]==nums[j]){
                    count++;
                }
            }
            if(count>=2){
                return true;
            }
        }
        return false;
    }
}
