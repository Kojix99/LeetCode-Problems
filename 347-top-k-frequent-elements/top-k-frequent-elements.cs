public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> numsFrequent = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            if(numsFrequent.ContainsKey(nums[i]))
            {
                numsFrequent[nums[i]]++;
            }
            else
            {
                numsFrequent[nums[i]] = 1;
            }
        }

        int[] FrequentOrder = numsFrequent.Values.ToArray();
        Array.Sort(FrequentOrder);
        Array.Reverse(FrequentOrder);
        int[] TopFrequentK = new int[k];
        int j = 0;

        foreach(KeyValuePair<int, int> kvp in numsFrequent)
        {
            for(int i = 0; i < k; i++)
            {
                if(FrequentOrder[i] == kvp.Value)
                {
                    TopFrequentK[j] = kvp.Key;
                    j++;
                    break;
                }
            }
            if(j == k)
            {
                return TopFrequentK;
            }
        }
        return TopFrequentK;
    }
}