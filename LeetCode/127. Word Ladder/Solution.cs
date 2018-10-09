public class Solution {
    private void nextTransformations(string beginWord, IList<string> wordList, HashSet<string> visited, HashSet<string> toVisit){
        for(int i = 0; i < beginWord.Length; i++){
            char[] transformed = beginWord.ToCharArray();
            for(int a = (int)'a'; a <= (int)'z'; a++){
                transformed[i] = (char)a;
                string newStr = new string(transformed);
                if(wordList.Contains(newStr) && !visited.Contains(newStr)){
                    toVisit.Add(newStr);
                    visited.Add(newStr);
                }
            }
        }
    }
    
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        
        HashSet<string> visited = new HashSet<string>();
        HashSet<string> visiting = new HashSet<string>();
        visiting.Add(beginWord);
        
        int ladderLength = 1;
        while(visiting.Count != 0){
            
            if(visited.Contains(endWord)) return ladderLength;
            
            string[] visitingArr = visiting.ToArray();
            HashSet<string> toVisit = new HashSet<string>();
            for(int i = 0; i < visitingArr.Length; i++){
                nextTransformations(visitingArr[i], wordList, visited, toVisit);
            }
            
            ladderLength++;
            visiting = toVisit;
        }
        
        return 0;
    }
}