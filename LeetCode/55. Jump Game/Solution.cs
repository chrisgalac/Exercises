public class Solution {
    public bool CanJump(int[] nums) {
        bool[] canReachEnd = new bool[nums.Length];
        
        for(int i = nums.Length - 2; i >= 0; i--){
            if(i + nums[i] >= nums.Length - 1){
                canReachEnd[i] = true;
            }
            else{
                for(int j = 1; j <= nums[i]; j++){
                    if(canReachEnd[i + j]){
                        canReachEnd[i] = true;
                        break;
                    }
                }
            }
        }
        
        return canReachEnd[0];
    }
}