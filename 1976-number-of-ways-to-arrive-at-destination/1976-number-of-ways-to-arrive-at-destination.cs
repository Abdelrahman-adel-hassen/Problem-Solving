public class Solution {
    public int CountPaths(int n, int[][] roads)
{
    const long oo = long.MaxValue;
    const long mod = 1000000007;
    var adj = Enumerable.Range(0, n)
                        .Select(_ => new List<(int cost, int destination)>())
                        .ToArray();
    var roadCost = new (long cost, long ways)[n];
    var vis = new int[n];
    var minMinutes = oo;
    for (int i = 0; i < n; i++)
        roadCost[i] = (oo, 0);

    for (int i = 0; i < roads.Length; i++)
    {
        int src = roads[i][0];
        int dest = roads[i][1];
        int cost = roads[i][2];
        adj[src].Add((cost, dest));
        adj[dest].Add((cost, src));
    }
    roadCost[0] = (0, 1);
    var q = new PriorityQueue<(long cost, int destination), long>();
    q.Enqueue((0, 0), 0);
    while (q.Count > 0)
    {
        (long cost, int src) road = q.Dequeue();
        if (road.cost != roadCost[road.src].cost)
            continue;

        if (road.src == n - 1)
            minMinutes = road.cost;

        foreach (var neigb in adj[road.src])
        {
            if (roadCost[neigb.destination].cost > road.cost + neigb.cost)
            {
                roadCost[neigb.destination].cost = road.cost + neigb.cost;
                roadCost[neigb.destination].ways = roadCost[road.src].ways;
                q.Enqueue((roadCost[neigb.destination].cost, neigb.destination), roadCost[neigb.destination].cost);
            }
            else if (roadCost[neigb.destination].cost == road.cost + neigb.cost)
                roadCost[neigb.destination].ways = (roadCost[neigb.destination].ways + roadCost[road.src].ways) % mod;
        }
    }
    Console.WriteLine("minutes " + minMinutes);
    return (int)roadCost[n - 1].ways;

}
}