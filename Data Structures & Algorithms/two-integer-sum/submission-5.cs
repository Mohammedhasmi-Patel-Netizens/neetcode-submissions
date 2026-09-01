public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // in bruteforce we need to use another loop just to get the b such that a+b = target so there is data structure called dictionary that help us to get the value in O(1)

        Dictionary<int,int> dic = new Dictionary<int,int>();
        
        for(int i=0;i<nums.Length;i++){
            dic.Add(i,nums[i]);
        }

        for(int i=0;i<nums.Length;i++){
            int currentNum = nums[i];
            int targetNumber = target - currentNum;

            int firstKey = dic.FirstOrDefault(x => x.Value == targetNumber && x.Key != i).Key;
            if(firstKey != 0){
                return new int[] {i,firstKey};
            }
        }

        return new[] {-1,-1};
    }
}
