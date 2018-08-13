public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int, int> indices = new Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(indices.ContainsKey(target-nums[i])) 
            {
            	return new int[2]{indices[target-nums[i]], i};
            }
            else 
            {
            	indices.Add(nums[i], i);
            }
        }
        
        return null;
    }
}