public class Solution {
    private bool isPalindrome(string s){
        for(int i = 0; i < s.Length/2; i++){
            if(s[i] != s[s.Length-1-i]) return false;
        }
        
        return true;
    }
    
    public IList<IList<string>> Partition(string s) {
        IList<IList<string>> partitions = new List<IList<string>>();
        
        if(s.Length == 1){
            IList<string> partition = new List<string>();
            partition.Add(s);
            partitions.Add(partition);
            return partitions;
        }
        
        for(int i = 1; i < s.Length; i++){
            string post = s.Substring(s.Length-i);
            if(isPalindrome(post)){
                IList<IList<string>> subPartitions = Partition(s.Substring(0,s.Length-i));
                foreach(List<string> list in subPartitions){
                    list.Add(post);
                    partitions.Add(list);
                }
                    
            }
        }
        
        if(isPalindrome(s)){
            IList<string> list = new List<string>();
            list.Add(s);
            partitions.Add(list);
        }
        
        return partitions;
    }
}