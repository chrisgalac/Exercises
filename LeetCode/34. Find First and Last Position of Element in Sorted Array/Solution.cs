public class Solution {
    public int findIndex(int[] nums, int target, bool first){
        int l = 0;
        int r = nums.Length - 1;
        
        while(l <= r){
            int mid = (l + r)/2;
            if(nums[mid] == target){
                if(first){
                    if(nums[mid-1] != target){ return mid; }
                    else{ r = mid - 1; }
                }
                else{
                    if(nums[mid + 1] != target){ return mid; }
                    else{ l = mid + 1; }
                }
            }
            else if(target < nums[mid]){ r = mid - 1; }
            else{ l = mid + 1; }
        }
        
        return -1;
    }
    
    public int[] SearchRange(int[] nums, int target) {
        int first = findIndex(nums, target, true);
        int last = first == -1 ? -1: findIndex(nums, target, false);
        return new int[]{first, last};
    }
}