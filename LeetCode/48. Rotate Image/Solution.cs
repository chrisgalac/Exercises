public class Solution {
    public void swap(int[,] matrix, int ax, int ay, int bx, int by){
        int temp = matrix[ax,ay];
        matrix[ax,ay] = matrix[bx,by];
        matrix[bx,by] = temp;
    }
    
    public void Rotate(int[,] matrix) {
        int n = matrix.GetLength(0);
        for(int ring = 0; ring < n/2; ring++){
            for(int i = 0; i < n - ring*2 - 1; i++){
                swap(matrix, ring, ring + i, ring + i, n - 1 - ring);
                swap(matrix, ring, ring + i, n - 1 - ring, n - 1 - ring - i);
                swap(matrix, ring, ring + i, n - 1 - ring - i, ring);
            }
        }
    }
}