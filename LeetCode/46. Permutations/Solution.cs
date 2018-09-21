public class Solution {
    public void permutations(IList<IList<int>> lol, List<int> l, int[] nums){
        if(l.Count == nums.Length){
            IList<int> built = new List<int>();
            for(int i = 0; i < l.Count; i++){ built.Add(l[i]); }
            lol.Add(built);
        }
        else{
            for(int i = 0; i < nums.Length; i++){
                if(l.Contains(nums[i])) continue;
                l.Add(nums[i]);
                permutations(lol, l, nums);
                l.Remove(nums[i]);
            }
        }
    }
    
    public IList<IList<int>> Permute(int[] nums) {
        IList<IList<int>> listOfLists = new List<IList<int>>();
        List<int> permutation = new List<int>();
        permutations(listOfLists, permutation, nums);
        return listOfLists;
    }
}