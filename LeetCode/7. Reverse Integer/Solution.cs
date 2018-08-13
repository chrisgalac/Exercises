public class Solution 
{
    public int Reverse(int x) 
    {
        bool negative = x < 0;
        int input = negative ? x * -1 : x;
        
        int output = 0;
        
        checked
        {    
            try
            {
                while(input > 0){
                    output = (output * 10) + (input % 10);
                    input /= 10;
                }
            }
            catch(OverflowException)
            {
                return 0;
            } 
        }
        
        return negative ? output * -1 : output;
        
    }
}