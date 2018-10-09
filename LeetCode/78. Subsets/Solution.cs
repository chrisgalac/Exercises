public class Solution {
    public IList<IList<int>> subsetsHelper(int[] nums, int elem){
        IList<IList<int>> subsets;
        
        if(elem == nums.Length){
            subsets = new List<IList<int>>();
            subsets.Add(new List<int>());
        }
        else{
            subsets = subsetsHelper(nums, elem + 1);
            int a = nums[elem];
            
            IList<IList<int>> allAppended = new List<IList<int>>();
            foreach(List<int> l in subsets){
                IList<int> appended = new List<int>();
                appended.Add(a);
                foreach(int e in l){
                    appended.Add(e);
                }
                allAppended.Add(appended);
            }
            
            foreach(List<int> l in allAppended){
                subsets.Add(l);
            }
        }
        
        return subsets;
    }
    
    public IList<IList<int>> Subsets(int[] nums) {
        return subsetsHelper(nums, 0);
    }
    
}