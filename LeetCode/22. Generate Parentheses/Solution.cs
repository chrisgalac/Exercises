public class Solution {
    
    public void helper(ref List<string> list, StringBuilder sb, int open, int closed){
        if(open == 0 && closed == 0){
            list.Add(sb.ToString());
        }
        else if(open == 0){
            helper(ref list, builtStr + ")", open, closed - 1);
            helper(ref list, sb.Append(")"), open, closed - 1);
            sb.Length--;
        }
        else if(open == closed){
            helper(ref list, sb.Append("("), open - 1, closed);
            sb.Length--;
        }
        else{
            helper(ref list, sb.Append("("), open - 1, closed);
            sb.Length--;
            helper(ref list, sb.Append(")"), open, closed - 1);
            sb.Length--;
        }
    }
    
    public IList<string> GenerateParenthesis(int n) {
        List<string> l = new List<string>();
        helper(ref l, new StringBuilder(), n, n);
        return l;
    }
}