public class Solution {
    public int MyAtoi(string str) {
        
        StringBuilder sb = new StringBuilder();
        
        int i = 0;
        while(i < str.Length && str[i] == ' '){
            i++;
        }
        
        if(i >= str.Length) return 0;
        
        bool isNeg = false;
        
        if(str[i] == '-'){
            isNeg = true;
            i++;
        }
        else if(str[i] == '+') {
            i++;
        }
        else if((int)str[i] < (int)'0' || (int)str[i] > (int)'9') {
            return 0;
        }
        
        while(i < str.Length && (int)str[i] >= (int)'0' && (int)str[i] <= (int)'9' ){
            sb.Append(str[i]);
            i++;
        }
        
        String s = sb.ToString();
        const string intmax = "2147483647";
        const string intmin = "2147483648";
        
        if(s.Length == 0) return 0;
        
        if(isNeg){
            if(s.Length > intmin.Length) return int.MinValue;
            if(s.Length == intmin.Length){
                for(int j = 0; j < s.Length; j++){
                    if((int)s[j] > (int)(intmin[j])) return int.MinValue;
                }
            }
        } 
        else{
            if(s.Length > intmax.Length) return int.MaxValue;
            if(s.Length == intmax.Length){
                for(int j = 0; j < s.Length; j++){
                    if((int)s[j] > (int)(intmax[j])) return int.MaxValue;
                }
            }
        }
        
        int rv = 0;
        for(int j = 0; j < s.Length; j++){
            rv *= 10;
            rv += (int)(s[j] - '0');
        }
        
        return isNeg? rv * -1 : rv;
         
    }
}