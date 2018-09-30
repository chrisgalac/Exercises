public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, IList<string>> anags = new Dictionary<string, IList<string>>();
        
        for(int i = 0; i < strs.Length; i++){
            string s = strs[i];
            char[] toSort =  s.ToCharArray();
            Array.Sort(toSort);
            string sorted = new string(toSort);
            
            if(!anags.ContainsKey(sorted)){
                anags.Add(sorted, new List<string>());
            }
            
            anags[sorted].Add(s);
        }
        
        IList<IList<string>> grouped = new List<IList<string>>();
        foreach(string key in anags.Keys){
            grouped.Add(anags[key]);
        }
        
        return grouped;
    }
}