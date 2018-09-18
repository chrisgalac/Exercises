public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> solution = new List<IList<int>>();
        
        Array.Sort(nums);
        
        for(int i = 0; i < nums.Length - 2; i++){
            
            if(i == 0 || nums[i] != nums[i - 1]){
                
                int l = i + 1;
                int r = nums.Length - 1;
                int target = 0 - nums[i];
                
                while(l < r){
                    
                    if(nums[l] + nums[r] == target){
                        IList<int> triplet = new List<int>();
                        triplet.Add(nums[i]);
                        triplet.Add(nums[l]);
                        triplet.Add(nums[r]);
                        solution.Add(triplet);
                        
                        while(l < r && nums[l] == nums[l + 1]) l++;
                        while(l < r && nums[r] == nums[r - 1]) r--;
                        
                        l++;
                        r--;
                    }
                    else if(nums[l] + nums[r] > target){ r--; }
                    else { l++; }
                }
            }
        }
        
        return solution;
    }
}