class Solution {
public:
    string fractionToDecimal(int numerator, int denominator) {
        if(denominator == 1) return to_string(numerator); // return "x" for x/1
        if(numerator == INT_MIN && denominator == -1) return "2147483648"; // prevent overflow with INT_MIN/(-1)
        
        // Start return string with '-' if the result will be negative
        string decimal = (numerator < 0 ^ denominator < 0) ? "-" : "";
        
        // Add the integer part of the decimal to the string
        decimal += to_string(abs(numerator/denominator));
        
        // Set the numerator to the remainder of numerator/denominator
        numerator %= denominator;
        
        // Set the numerator/denominator to their absolute values
        numerator = abs(numerator);
        denominator = abs(denominator);
        
        if(numerator == 0) return decimal; //No decimal part, return string
        
        decimal.append(".");
        
        unordered_map<int, int> numsSeen;
        while(numerator > 0){
            
            // The numerator has already been encountered, meaning the section is repeating
            if(numsSeen.find(numerator) != numsSeen.end()){
                decimal.insert(numsSeen[numerator], 1, '(');
                decimal += ')';
                break;
            }
            
            // Mark where the current numerator has been encountered in the string
            numsSeen[numerator] = decimal.size();
            
            // Add a digit from the decimal part to the string
            numerator *= 10;
            decimal += to_string(numerator/denominator);
            
            numerator %= denominator;
        }
        
        return decimal;
    }
};