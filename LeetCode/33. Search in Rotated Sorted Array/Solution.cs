public class Solution {
    public int Search(int[] nums, int target) {
        
        int l = 0;
        int r = nums.Length -1;
        while(l <= r){
            
            int mid = (l + r)/2;
            if(nums[mid] == target) return mid;
            
            bool leftSorted = nums[l] <= nums[mid];
            bool rightSorted = nums[mid] <= nums[r];
            
            if(leftSorted && target >= nums[l] && target < nums[mid]){
                r = mid - 1;
            }
            else if(rightSorted && target > nums[mid] && target <= nums[r]){
                l = mid + 1;
            }
            else if(leftSorted){
                l = mid + 1;
            }
            else{
                r = mid - 1;
            }
        }
        
        return -1;
    }
}