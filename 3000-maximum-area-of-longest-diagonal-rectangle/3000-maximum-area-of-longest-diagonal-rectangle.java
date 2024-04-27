class Solution {
    public int areaOfMaxDiagonal(int[][] dimensions) {
          int maxDiagonalSQ = 0;
    int maxArea = 0;
    for (int i = 0; i < dimensions.length; i++) {
      int currentDiagonal =(dimensions[i][0] * dimensions[i][0]) + (dimensions[i][1] * dimensions[i][1]);

      if (currentDiagonal > maxDiagonalSQ || (currentDiagonal == maxDiagonalSQ && maxArea<dimensions[i][1] * dimensions[i][0])) {
        maxDiagonalSQ = currentDiagonal;
        maxArea = dimensions[i][1] * dimensions[i][0];
      }
    }

    return maxArea;
    }
}