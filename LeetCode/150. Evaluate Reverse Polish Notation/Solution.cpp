class Solution {
public:
    int evalRPN(vector<string>& tokens) {
        return eval(tokens, 0, tokens.size() - 1);
    }
    
private:
    int eval(vector<string>& tokens, int l, int op) {
        if(op - l == 2){
            int o1 = stoi(tokens[l]);
            int o2 = stoi(tokens[l+1]);
            return operate(o1, o2, tokens[op]);
        }
        else if(isOperator(tokens[op-1])){
            int o1 = stoi(tokens[l]);
            int o2 = eval(tokens, l+1, op-1);
            return operate(o1, o2, tokens[op]);
        }
        else{
            int o1 = eval(tokens, l, op-2);
            int o2 = stoi(tokens[op-1]);
            return operate(o1, o2, tokens[op]);
        }
    }
    
    int operate(int o1, int o2, string op){
        if(op == "+"){
            return o1 + o2;
        }
        else if(op == "-"){
            return o1 - o2;
        }
        else if(op == "*"){
            return o1 * o2;
        }
        else if(op == "/"){
            return o1 / o2;
        }
        else return 0;
    }
    
    bool isOperator(string s){
        return s == "+" || s == "-" || s == "*" || s == "/";
    }
};