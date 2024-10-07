using System.Collections;
using System.Collections.Generic;

public class Field
{
	int size;
	int[] field;
	Dictionary<int[2], int> map;
	
	public Field(int s)
	{
		field = new int[s];
		this.size = s;
		map = new Dictionary<int[2], int>();
		
		int index = 0;
		
		for(int i = 0; i < size; i++) 
        {
            for(int j = 0; j < size; j++)
            {
                //map[index] = new Vector3(j, 0.0f, i);
                //map.Add(grid[index], index);
                map.Add([j,i], index);

                index++;
            }
        }
	}
	
	public int PositionToIndex(int[2] pos)
	{
		return map[pos];
	}
	
	public int[2] IndexToPosition(int index)
	{
		//to do
		return 0;
	}
}