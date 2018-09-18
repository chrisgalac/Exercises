public class Solution {
    public int MaxArea(int[] height) {
        int mostContained = 0;
        
        // Brute Force Method
        //
        // for(int i = 0; i < height.Length; i++){
        //     for(int j = i + 1; j < height.Length; j++){
        //         int h = height[i] < height[j] ? height[i] : height[j];
        //         int contained = (j - i) * h;
        //         if(contained > mostContained) mostContained = contained;
        //     }
        // }
        
        int l = 0;
        int r = height.Length - 1;
        
        while(l < r){
            int h = height[l] < height[r] ? height[l] : height[r];
            int contained = (r-l)*h;
            
            if(contained > mostContained) mostContained = contained;
            
            if(height[l] < height[r]) l++;
            else r--;
        }
        
        return mostContained;
    }
}