public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // in bruteforce we need to use another loop just to get the b such that a+b = target so there is data structure called dictionary that help us to get the value in O(1)

        Dictionary<int,int> dic = new Dictionary<int,int>();

        for(int i=0;i<nums.Length;i++){
            int targetNum = target - nums[i];
            // check whtehr the element exist in the dic
            if(dic.TryGetValue(targetNum,out int index)){
                return new int[] {index,i};
            }

            dic[nums[i]] = i;
        }

        return new int[] {-1,-1};
    }
}
