public class Solution {
    public bool checkRow(char[,] board, int row){
        HashSet<char> seen = new HashSet<char>();
        for(int i = 0; i < 9; i++){
            char digit = board[row, i];
            if((int)digit >= (int)'1' && (int)digit <= (int)'9'){
                if(seen.Contains(digit)) return false;
                else seen.Add(digit);
            }
        }
        return true;
    }
    
    public bool checkCol(char[,] board, int col){
        HashSet<char> seen = new HashSet<char>();
        for(int i = 0; i < 9; i++){
            char digit = board[i, col];
            if((int)digit >= (int)'1' && (int)digit <= (int)'9'){
                if(seen.Contains(digit)) return false;
                else seen.Add(digit);
            }
        }
        return true;
    }
    
    public bool checkSubBox(char[,] board, int x, int y){
        HashSet<char> seen = new HashSet<char>();
        for(int i = 0; i < 3; i++){
            for(int j = 0; j < 3; j++){
                char digit = board[y * 3 + i, x * 3 + j];
                if((int)digit >= (int)'1' && (int)digit <= (int)'9'){
                    if(seen.Contains(digit)) return false;
                    else seen.Add(digit);
                }
            }
        }
        return true;
    }
    
    public bool IsValidSudoku(char[,] board) {
        for(int i = 0; i < 9; i++){
            if(!checkRow(board, i)) return false;
            if(!checkCol(board, i)) return false;
        }
        
        for(int i = 0; i < 3; i++){
            for(int j = 0; j < 3; j++){
                if(!checkSubBox(board, i, j)) return false;
            }
        }
        
        return true;
    }
}