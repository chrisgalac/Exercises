class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        vector<int> answer;
        
        unordered_map<int,int> seen;
        for(int i = 0; i < nums.size(); i++){
            if(seen.find(target-nums[i]) != seen.end()){
                answer.push_back(seen[target-nums[i]]);
                answer.push_back(i);
                return answer;
            }
            
            seen[nums[i]] = i;
        }
        
        return answer;
    }
};