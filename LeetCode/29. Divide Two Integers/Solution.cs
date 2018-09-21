public class Solution {
    public int Divide(int dividend, int divisor) {
        
        if(dividend == 0) return 0;
        if(dividend == int.MinValue && divisor == -1) return int.MaxValue;
        
        bool isNeg = false;
        
        if(dividend < 0){
            dividend = ~dividend + 1;
            isNeg = !isNeg;
        }
        
        if(divisor < 0){
            divisor = ~divisor + 1;
            isNeg = !isNeg;
        }
        
        int quotient = 0;
        while(dividend - divisor >= 0){
            dividend -= divisor;
            quotient++;
        }
        
        return isNeg ? ~quotient + 1 : quotient;
    
    }
}