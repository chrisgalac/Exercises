public class Solution {
    private void outlet(char[,] board, int r, int c){
        int rows = board.GetLength(0);
        int cols = board.GetLength(1);
        
        if(r < 0 || r >= rows || c < 0 || c >= cols) return;
        
        if(board[r,c] == 'O'){
            board[r,c] = 'R';
            
            outlet(board, r, c-1);
            outlet(board, r, c+1);
            outlet(board, r-1, c);
            outlet(board, r+1, c);
        }
    }
    
    public void Solve(char[,] board) {
        int rows = board.GetLength(0);
        int cols = board.GetLength(1);
        
        for(int col = 0; col < cols; col++){
            if(board[0,col] == 'O'){
                outlet(board, 0, col);
            }
            
            if(board[rows-1,col] == 'O'){
                outlet(board, rows-1, col);
            }
        }
        
        for(int row = 1; row < rows-1; row++){
            if(board[row,0] == 'O'){
                outlet(board, row, 0);
            }
            
            if(board[row, cols-1] == 'O'){
                outlet(board, row, cols-1);
            }
        }
        
        for(int row = 0; row < rows; row++){
            for(int col = 0; col < cols; col++){
                if(board[row,col] == 'O'){
                    board[row,col] = 'X';
                }
                
                if(board[row,col] == 'R'){
                    board[row, col] = 'O';
                }
            }
        }
        
    }
}