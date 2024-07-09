public class Solution {
    public int MinGroupsForValidAssignment(int[] balls) {
        Dictionary<int, int> groups = new();
        foreach (var item in balls)
        {
            if (!groups.ContainsKey(item))
                groups[item] = 0;

            groups[item]++;
        }
        int minGroup = 1000000;
        foreach (var group in groups)
            minGroup = Math.Min(minGroup, group.Value);
        int result = 0;
        for(int mid = minGroup; mid >= 1; --mid) {   
            int numberOfGroups = 0;
            bool weCan = true;
            foreach (var group in groups)
            {
                if (group.Value == mid)
                    numberOfGroups++;
                else
                {
                    int groupsOfCurrentValue = group.Value / (mid + 1);
                    int noOfValuesInLastGroup = (group.Value % (mid + 1));
                    numberOfGroups += groupsOfCurrentValue + (noOfValuesInLastGroup > 0 ? 1 : 0);
                    if (noOfValuesInLastGroup > 0 && groupsOfCurrentValue + noOfValuesInLastGroup < mid)
                    {
                        weCan = false;
                        break;
                    }
                }
            }
            if (weCan)
            {
                result = numberOfGroups;
                break;
            }

        }

        return result;
    }
}