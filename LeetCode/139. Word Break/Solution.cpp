class Solution {
public:
    bool wordBreak(string s, vector<string>& wordDict) {
        for(string word : wordDict){
            if(s.compare(word) == 0) return true;
            if(s.find(word) == 0) {
                if(wordBreak(s.substr(word.length()), wordDict)) return true;
            }
        }
        return false;
    }
};