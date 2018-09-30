public class Solution {
    public void SetZeroes(int[,] matrix) {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        HashSet<int> zeroRows = new HashSet<int>();
        HashSet<int> zeroCols = new HashSet<int>();
        
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(matrix[i,j] == 0){
                    zeroRows.Add(i);
                    zeroCols.Add(j);
                }
            }
        }
        
        foreach(int row in zeroRows){
            for(int i = 0; i < n; i++){
                matrix[row,i] = 0;
            }
        }
        
        foreach(int col in zeroCols){
            for(int i = 0; i < m; i++){
                matrix[i,col] = 0;
            }
        }
    }
}