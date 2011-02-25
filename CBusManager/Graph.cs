
using System;

namespace CBusManager
{
	/// <summary>
	/// Description of Graph.
	/// </summary>
	public class Graph
	{
		
		Node[] nodes;
		//Edge[] edges;
		
		Node current;
		int route;
		
		public Node Node(int i){
			Console.WriteLine(i);
			if (i>=0 && i<nodes.Length) return nodes[i];
			return new Node();
			//throw new Exception("Не существует такого узла");
		}
			
		
		public Graph(int n, Route[] r)
		{
			nodes = new Node[n];
			for (int i = 0; i<n; i++)
				nodes[i] = new Node(this, i);
			
			for (int i = 0; i < r.Length; i++){
				for (int j = 0; j< r[i].Length - 1; j++){
					nodes[r[i].nodes[j]].AddAdj(r[i].nodes[j+1], i);
					nodes[r[i].nodes[j+1]].AddAdj(r[i].nodes[j], i);
				}
					
			}
		}
					
		public string ShortestRoute(int s,int f){
			
			throw new NotImplementedException();
			/*
			int[] d 	= 	new int[nodes.Length];
			string[] p 	= 	new string[nodes.Length];
			
			int vc = 0; // счетчик посещенных вершин
			
			d[s] = 0;
			p[s]+=s;
			vc++;
			
			int cn = s; // текущий узел
			int cr = 0;	// текущий маршрут
			
			for (int i=0; i< nodes.Length; i++) {
				if (i!=s){
					d[i] = int.MaxValue;
				}
			}
			// пока есть непосещенные узлы
			while (vc < nodes.Length){
				// ищем соседний с наименьшим ребром
				int min = int.MaxValue;
				int minn = 0;
				int i;
				for (i=0; i<nodes[cn].edges.Length; i++){
				
					if (d[cn]+nodes[cn].edges[i].Length(cr) < d[nodes[cn].edges[i].nTo.n])
					
				}
				// нашли минимальное ребро
				
				if (d[nodes[cn].edges[i].nTo] > min)
				cr = nodes[cn].edges[i].r;
				cn = nodes[cn].edges[i].nTo;
				
				vc++;
				
				
			}
			*/
		}
	}
}
