public class Solution {
    public bool CanReach(string s, int minJump, int maxJump)
    {
        if (s[s.Length - 1] == '1')
            return false;
        Queue<int> bfs = new();
        bfs.Enqueue(0);
        int coverSteps = 0;
        while (bfs.Count > 0)
        {
            var currentStep = bfs.Dequeue();
            var maxStep = Math.Min(currentStep + maxJump, s.Length - 1);
            coverSteps = Math.Max(currentStep + minJump, coverSteps);
            for (int i = coverSteps; i <= maxStep; i++)
            {
                if (i == s.Length - 1)
                    return true;

                if (s[i] == '0')
                    bfs.Enqueue(i);
            }
            coverSteps = Math.Min(currentStep + maxJump+1, s.Length);
        }

        return false;
    }
}