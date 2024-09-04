public class Solution {
    public int CountPaths(int n, int[][] roads)
{
    const long oo = long.MaxValue;
    var adj = Enumerable.Range(0, n)
                        .Select(_ => new List<(int cost, int destination)>())
                        .ToArray();
    var roadCost = new long[n];
    var vis = new int[n];
    var noOfWays = 0;
    var minMinutes = oo;
    for (int i = 0; i < n; i++)
        roadCost[i] = oo;

    for (int i = 0; i < roads.Length; i++)
    {
        int src = roads[i][0];
        int dest = roads[i][1];
        int cost = roads[i][2];
        adj[src].Add((cost, dest));
        adj[dest].Add((cost, src));
    }
    roadCost[0] = 0;
    var q = new PriorityQueue<(long cost, int destination), long>();
    q.Enqueue((0, 0), 0);
    while (q.Count > 0)
    {
        (long cost, int src) road = q.Dequeue();
        if (road.cost != roadCost[road.src])
            continue;

        if (road.src == n - 1)
            minMinutes = road.cost;

        foreach (var neigb in adj[road.src])
        {
            if (roadCost[neigb.destination] > road.cost + neigb.cost)
            {
                roadCost[neigb.destination] = road.cost + neigb.cost;
                q.Enqueue((roadCost[neigb.destination], neigb.destination), roadCost[neigb.destination]);
            }
        }
    }
    Console.WriteLine("minutes " + minMinutes);
    return DFS(0, n, 0, vis, roadCost, adj);

}
int DFS(int src, int n, long minCost, int[] vis, long[] roadCost, List<(int cost, int destination)>[] adj)
{
    if (minCost != roadCost[src])
        return 0;
    if (vis[src] != 0)
        return vis[src];
    if (src == n - 1)
        return 1;
    int result = 0;
    int mod = 1000000007;
    foreach (var neigb in adj[src])
    {
        result += DFS(neigb.destination, n, neigb.cost + minCost, vis, roadCost, adj);
        result %= mod;
    }
    return vis[src] = result;
}
}