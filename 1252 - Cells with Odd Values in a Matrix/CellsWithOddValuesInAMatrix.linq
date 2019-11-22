<Query Kind="Program" />

void Main()
{
	int y = 2;
	int x = 3;
	int[][] indices = new int[][]
	{
		new int[]{0,1},
		new int[]{1,1}
	};
	
	Console.WriteLine(CellsOddValuesInaMatrix(y, x, indices));
}

public int CellsOddValuesInaMatrix(int y, int x, int[][] indices)
{
	BitArray rows = new BitArray(y);
	int rowCount = 0;
	BitArray columns = new BitArray(x);
	int columnCount = 0;
	
	foreach(var index in indices)
	{
		rows.Set(index[0], !rows.Get(index[0]));
		rowCount += rows.Get(index[0]) ? 1 : - 1;
		columns.Set(index[0], !columns.Get(index[1]));		
		columnCount += columns.Get(index[1]) ? 1 : - 1;
	}
	
	return rowCount * (x - columnCount) + columnCount * (y - rowCount);
}
// Define other methods and classes here
