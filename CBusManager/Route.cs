
using System;

namespace CBusManager
{
	/// <summary>
	/// Description of Route.
	/// </summary>
	public class Route
	{
		public int[] nodes;
		public int Length {
			get {
				return nodes.Length;
			}
		}
		public Route(string s)
		{
			string[] ns = s.Split();
			nodes = new int[ns.Length];
			for (int i = 0; i< ns.Length; i++){
				nodes[i] = int.Parse(ns[i]);
			}
		}
		
		public Route(int[] nn){
			nodes = nn;
		}
	}
}
