
using System;
using System.Collections.Generic;
using System.Collections;

namespace CBusManager
{

	/// <summary>
	/// Description of Node.
	/// </summary>
	public class Node
	{
		#region fields
		
		// номер узла
		public int n;
		
		// минимальный автобусный маршрут
		int r;
		
		Graph graph;
		
		#endregion
		
		struct AdjNode {
			Node node;
			int route;
		
			Graph graph;
			
			// струкутра предназначенная для хранения
			// пары соседний узел - номер маршрута
			public AdjNode(Graph g, int nn, int rn){
				graph = g;
				node = g.Node(nn+1);
				route = rn;
			}
		}
		
		ArrayList neighbors = new ArrayList();
		
		// пары соседняя остановка - номер маршрута последнего участка перед ней
		// neighbors[i] - соседний узел 
		// nr[i] 		- автобусный маршрут в этот узел
		//ArrayList neighbors;
		
		//public Edge[] edges;
		
		// посещена
		public bool v;
		
		
		public Node(Graph g, int bn)
		{
			graph = g;
			n = bn;
		}
		
		public Node(){
			
		}
		
		// добавление смежного 
		public void AddAdj(int n, int r){
			neighbors.Add(new AdjNode(graph,n,r));
		}
		
		public override string ToString()
		{
			return n.ToString();
		}
	}
}
