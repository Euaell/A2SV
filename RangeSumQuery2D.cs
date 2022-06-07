public class NumMatrix {
    private int[][] matrix;
    private int n;
    private int m;
    public NumMatrix(int[][] matrix) {
        this.n = matrix.Length;
        this.m = matrix[0].Length;
        if (n == 0 || m == 0) return;
        this.matrix = new int[n + 1][];
        for (int i = 0; i <= n; i++){
            this.matrix[i] = new int[m + 1];
        }
        
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++){
                this.matrix[i + 1][j + 1] = this.matrix[i + 1][j] + this.matrix[i][j + 1] + matrix[i][j] - this.matrix[i][j];
            }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
         return matrix[row2 + 1][col2 + 1] - matrix[row1][col2 + 1] - matrix[row2 + 1][col1] + matrix[row1][col1];
    }
}
