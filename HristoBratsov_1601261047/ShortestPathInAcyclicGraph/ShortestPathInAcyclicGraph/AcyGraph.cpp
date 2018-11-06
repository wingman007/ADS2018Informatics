#include <iostream>
#include <vector>
#include <climits>
#include <iomanip>
using namespace std;

struct Edge {
	int src, dest, weight;
};
class Graph
{
public:
	vector<vector<Edge>> adjList;

	Graph(vector<Edge> const &edges, int N)
	{

		adjList.resize(N);


		for (Edge const &edge : edges)
			adjList[edge.src].push_back(edge);
	}
};
int DFS(Graph const &graph, int v, vector<bool> &discovered,
	vector<int> &departure, int& time)
{
	discovered[v] = true;

	for (Edge e : graph.adjList[v])
	{
		int u = e.dest;
		if (!discovered[u])
			DFS(graph, u, discovered, departure, time);
	}

	departure[time] = v;
	time++;
	return 0;
}
void findShortestDistance(Graph const& graph, int source, int N)
{
	vector<int> departure(N, -1);


	vector<bool> discovered(N);
	int time = 0;

	for (int i = 0; i < N; i++)
		if (!discovered[i])
			DFS(graph, i, discovered, departure, time);

	vector<int> cost(N, INT_MAX);
	cost[source] = 0;

	for (int i = N - 1; i >= 0; i--)
	{

		int v = departure[i];
		for (Edge e : graph.adjList[v])
		{
		
			int u = e.dest;
			int w = e.weight;

			if (cost[v] != INT_MAX && cost[v] + w < cost[u])
				cost[u] = cost[v] + w;
		}
	}

	for (int i = 0; i < N; i++)
	{
		cout << "Shortest distance of source vertex " << source <<
			" to vertex " << i << " is " << setw(2) << cost[i] << '\n';
	}
}

int main()
{
	vector<Edge> edges =
	{
		{0, 6, 2}, {1, 2, -4}, {1, 4, 1}, {1, 6, 8}, {3, 0, 3}, {3, 4, 5},
		{5, 1, 2}, {7, 0, 6}, {7, 1, -1}, {7, 3, 4}, {7, 5, -4}
	};

	
	int N = 8;

	
	Graph graph(edges, N);

	int source = 7;

	
	findShortestDistance(graph, source, N);
	system("pause");
	return 0;
}
