public class Solution {
    public int NumDecodings(string s) {
        if(s.Length <= 1) return 1;
        
        int numWays = NumDecodings(s.Substring(1));
        int twoDigits = 0;
        if(!Int32.TryParse(s.Substring(0,2), out twoDigits)) twoDigits = -1;
        
        if(twoDigits >= 10 && twoDigits <= 26) numWays += NumDecodings(s.Substring(2));
        
        return numWays;
    }
}