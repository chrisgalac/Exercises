class Solution {
public:
    int maxProduct(vector<int>& nums) {
        int largestOvrl = nums[0];
        
        // The first elem in nums is the largest/smallest number so far
        int largestPre = nums[0]; 
        int smallestPre = nums[0];
        
        int largestAti, smallestAti;
        for(int i = 0; i < nums.size(); i++){
            
            // Largest/smallest product ending at i is either the current elem or
            // the current elem * the previous largest/smallest (takes negs into account)
            largestAti = max(max(largestPre * nums[i], smallestPre * nums[i]), nums[i]);
            smallestAti = min(min(smallestPre * nums[i], largestPre * nums[i]), nums[i]);
            
            // Keep track of the largest product overall
            largestOvrl = max(largestOvrl, largestAti);
            
            // Update current largest/smallest products to previous
            largestPre = largestAti;
            smallestPre = smallestAti;
        }
        
        
        return largestOvrl;
    }
};