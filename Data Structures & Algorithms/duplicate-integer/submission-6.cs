public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int> dic = new Dictionary<int,int>();

        for(int i=0;i<nums.Length;i++){
            if(dic.ContainsKey(nums[i])){
                return true;
            }else{
                dic.Add(nums[i],1);
            }
        }

        return false;
    }
}