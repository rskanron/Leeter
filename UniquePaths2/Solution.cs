public class Solution {
    public int UniquePathsWithObstacles(int[,] obstacleGrid) {
        
        if (obstacleGrid[0,0] == 1) {
            return 0;
        }
        
        var m = obstacleGrid.GetLength(0);
        var n = obstacleGrid.GetLength(1);
        
        int[,] pathCountGrid = new int [m,n];
        // create count of paths to the first square (top left)
        pathCountGrid[0,0] = 1;
        
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                // skip the first one
                if (i == 0 && j == 0) {
                    continue;
                }
                
                if (obstacleGrid[i,j] == 1) {
                    // if there is an obstacle, there are no paths to this square
                    pathCountGrid[i,j] = 0;
                    continue;
                }
								
		var numPathsToHere = 0;
								
                if (i == 0) {
                    numPathsToHere = pathCountGrid[i, j-1];
                } else if (j == 0) {
                    numPathsToHere = pathCountGrid[i-1, j];
                } else {
                    numPathsToHere = pathCountGrid[i-1, j] + pathCountGrid[i, j-1]; 
                }
                                
                pathCountGrid[i,j] = numPathsToHere;
            }
        }
        
        return pathCountGrid[m-1, n-1];
    }
}
