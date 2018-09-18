public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int longest = 0;
        HashSet<char> seen = new HashSet<char>();
        
        for(int i = 0; i < s.Length; i++){
            if(seen.Contains(s[i])){
                if(seen.Count > longest) longest = seen.Count;
                seen.Clear();
            }
            seen.Add(s[i]);
        }
        
        if(seen.Count > longest) longest = seen.Count;
        return longest;
    }
}