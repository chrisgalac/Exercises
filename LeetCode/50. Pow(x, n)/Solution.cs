public class Solution {
    public double MyPow(double x, int n) {
        if(n == 0) return 1;
        if(n == int.MinValue) return MyPow(x, int.MinValue + 1) / x;
        if(n < 0) return 1 / MyPow(x, n * -1);
       
        double product = x;
        for(int i = 1; i < n; i++){
            product *= x;
        }
        
        return product;
    }
}