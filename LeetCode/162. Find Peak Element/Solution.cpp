class Solution {
public:
    int findPeakElement(vector<int>& nums) {
        int l = 0;
        int r = nums.size() - 1;
        
        while (l < r) {
            // Get the midpoint of the current search area
            int m = l + (r - l) / 2;
            
            if (nums[m] < nums[m+1]) {
                l = m+1; // Midpoint creates valley, search for a peak in the right half
            } else {    
                r = m; // Midpoint is a possible peak, search for a peak in the left half
            }
        }
        
        // There is a peak at the last searchable area
        return l;
    }
};