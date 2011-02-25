
using System;

namespace CBusManager
{
	/// <summary>
	/// Description of Edge.
	/// </summary>
	public class Edge
	{
		public Node nTo;
		public int r;
		int length;
		
		public int Length(int cr)
		{
			if (r == cr) {
				return 1;
			}
			else return 3+1;
		}
		
		public Edge(Node t, int rn)
		{
			nTo = t;
			r = rn;
		}
		
		
		
		public override string ToString()
		{
			return "["+r+"]-"+nTo.n+")";
		}
		
		
	}
}
