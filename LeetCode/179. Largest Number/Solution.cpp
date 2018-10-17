class Solution {
    struct comp{
        bool operator()(string a, string b){
            return a + b > b + a;
        }
    } greater;

public:
    string largestNumber(vector<int>& nums) {
        
        // Copy the int vector as a vector of strings
        vector<string> strings;
        for(int num : nums){
            strings.push_back(to_string(num));
        }
        
        // Sort such that concatenating any two strings will produce the largest result
        sort(strings.begin(), strings.end(), greater);

        // Another option of sorting
        //sort(strings.begin(), strings.end(), [](string &a, string &b){ return a + b > b + a;});

        
        // Create the string from the vector
        string answer = "";
        for(int i = 0; i < strings.size(); i++){
            answer += strings[i];
        }
        return answer;
    }
};