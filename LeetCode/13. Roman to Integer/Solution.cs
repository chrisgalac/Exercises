public class Solution {
    public int RomanToInt(string s) {
        int total = 0;
        
        for(int i = 0; i < s.Length; i++){
            
            if(s[i] == 'I'){
                if(i < s.Length - 1){
                    i++;
                    
                    if(s[i] == 'V'){
                        total += 4;
                    }
                    else if (s[i] == 'X'){
                        total += 9;
                    }
                    else {
                        total++;
                        i--;
                    }
                }
                else {
                    total++;
                }
            }
            else if(s[i] == 'X'){
                if(i < s.Length - 1){
                    i++;
                    
                    if(s[i] == 'L'){
                        total += 40;
                    }
                    else if (s[i] == 'C'){
                        total += 90;
                    }
                    else {
                        total += 10;
                        i--;
                    }
                }
                else {
                    total += 10;
                }
            }
            else if(s[i] == 'C'){
                if(i < s.Length - 1){
                    i++;
                    
                    if(s[i] == 'D'){
                        total += 400;
                    }
                    else if (s[i] == 'M'){
                        total += 900;
                    }
                    else {
                        total += 100;
                        i--;
                    }
                }
                else {
                    total += 100;
                }
            }
            else if(s[i] == 'V'){
                total += 5;
            }
            else if(s[i] == 'L'){
                total += 50;
            }
            else if(s[i] == 'D'){
                total += 500;
            }
            else if(s[i] == 'M'){
                total += 1000;
            }
            
        }
        
        return total;
    }
}