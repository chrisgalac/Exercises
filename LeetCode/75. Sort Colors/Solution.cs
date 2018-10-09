public class Solution {
    public void SortColors(int[] nums) {
        int l = 0;
        int r = nums.Length - 1;
        int i = 0;
        while(i <= r && l < r){
            if(i < l) i = l;
            
            if(nums[i] == 0){
                nums[i] = nums[l];
                nums[l] = 0;
                l++;
            }
            else if(nums[i] == 2){
                nums[i] = nums[r];
                nums[r] = 2;
                r--;
            }
            else{
                i++;
            }
        }
    }
}