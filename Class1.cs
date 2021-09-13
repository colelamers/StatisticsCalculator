using System;
using System.Collections.Generic;

public class IntGrouped
{
	public Dictionary<int, int> dict { get; set };

	public IntGrouped(int key, int value)
	{
		dict.Add(key, value);
	}
}
