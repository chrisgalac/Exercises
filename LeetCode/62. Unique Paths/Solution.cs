public class Solution {
    public int UniquePaths(int m, int n) {
        return (m == 1 || n == 1) ? 1 : UniquePaths(m-1, n) + UniquePaths(m, n-1);
    }
}