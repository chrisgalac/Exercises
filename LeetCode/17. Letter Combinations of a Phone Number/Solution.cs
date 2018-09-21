public class Solution {
    public IList<string> Letters(char digit){
        switch(digit){
            case '2':
                return new List<string>(new string[]{"a","b","c"});
            case '3':
                return new List<string>(new string[]{"d","e","f"});
            case '4':
                return new List<string>(new string[]{"g","h","i"});
            case '5':
                return new List<string>(new string[]{"j","k","l"});
            case '6':
                return new List<string>(new string[]{"m","n","o"});
            case '7':
                return new List<string>(new string[]{"p","q","r","s"});
            case '8':
                return new List<string>(new string[]{"t","u","v"});
            case '9':
                return new List<string>(new string[]{"w","x","y","z"});
            default:
                return new List<string>();
        }
    }
    
    
    public IList<string> LetterCombinations(string digits) {
        
        IList<string> first = Letters(digits[0]);
        
        if(digits.Length <= 1) return first;
        
        IList<string> sub = LetterCombinations(digits.Substring(1));
        
        IList<string> combinations = new List<string>();
        foreach(string prefix in first){
            foreach(string affix in sub){
                combinations.Add(prefix + affix);
            }
        }
        
        return combinations;
    }
}