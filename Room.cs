using System.Collections;
using System.Collections.Generic;

public class Room
{
	int[][] bounds = new int[2][2];
	
	public int Min
	{
		get{ return bounds[0]; }
		set{ bounds[0] = value; }
	}
	
	public int Max
	{
		get{ return bounds[1]; }
		set{ bounds[1] = value; }
	}
}