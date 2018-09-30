public class Solution {
    public IList<int> SpiralOrder(int[,] matrix) {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int rings = rows <= cols ? rows/2 : cols/2;
        IList<int> spiralOrder = new List<int>();
        
        for(int ring = 0; ring < rings; ring++){
            for(int col = ring; col < cols - ring; col++){
                spiralOrder.Add(matrix[ring, col]);
            }
            for(int row = ring + 1; row < rows - ring - 1; row++){
                spiralOrder.Add(matrix[row, cols - ring - 1]);
            }
            for(int col = cols - 1 - ring; col >= ring; col--){
                spiralOrder.Add(matrix[rows - 1 - ring, col]);
            }
            for(int row = rows - 2 - ring; row >= ring + 1; row--){
                spiralOrder.Add(matrix[row, ring]);
            }
        }
        
        if(rows <= cols && rows % 2 == 1) {
            for(int col = rings; col < cols - rings; col++){
                spiralOrder.Add(matrix[rings, col]);
            }
        }
        else if(rows > cols && cols % 2 == 1){
            for(int row = rings; row < rows - rings; row++){
                spiralOrder.Add(matrix[row, rings]);
            }
        }
        
        return spiralOrder;
    }
}