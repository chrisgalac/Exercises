public class Solution {
    public bool isPalindrome(string s){
        int l = 0;
        int r = s.Length - 1;
        
        while(l < r){
            if(s[l] != s[r]) return false;
            l++;
            r--;
        }
        
        return true;
    }
    
    public string LongestPalindrome(string s) {
        
        for(int winSize = s.Length; winSize > 1; winSize--){
            for(int i = 0; i + winSize <= s.Length; i++){
                String substr = s.Substring(i,winSize);
                if(isPalindrome(substr)) return substr;
            }
        }
        
        return s.Substring(0,1);
    }
}