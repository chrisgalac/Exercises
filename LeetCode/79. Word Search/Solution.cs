public class Solution {
    public bool helper(char[,] board, bool[,] seen, int r, int c, string word){
        if(word.Length == 0) return true;
        if(r < 0 || r >= board.GetLength(0) || c < 0 || c >= board.GetLength(1)) return false;
        if(seen[r,c]) return false;
        if(board[r,c] != word[0]) return false;
        else{
            seen[r,c] = true;
            bool checkL = helper(board, seen, r, c-1, word.Substring(1));
            bool checkR = helper(board, seen, r, c+1, word.Substring(1));
            bool checkU = helper(board, seen, r-1, c, word.Substring(1));
            bool checkD = helper(board, seen, r+1, c, word.Substring(1));
            
            if(checkL || checkR || checkU || checkD) return true;
            
            seen[r,c] = false;
            return false;
        }
    }
    
    public bool Exist(char[,] board, string word) {
        int numRows = board.GetLength(0);
        int numCols = board.GetLength(1);
        
        for(int i = 0; i < numRows; i++){
            for(int j = 0; j < numCols; j++){
                if(board[i,j] == word[0] && helper(board, new bool[numRows, numCols], i, j, word)){
                    return true;
                }
            }
        }
        
        return false;
    }
}