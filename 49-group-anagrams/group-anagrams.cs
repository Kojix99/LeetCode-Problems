public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) 
    {
        IList<IList<string>> GroupedAnagrams = new List<IList<string>>();
        Dictionary<string, List<string>> AnagramsDict = new Dictionary<string, List<string>>();

        for(int i = 0; i < strs.Length; i++)
        {
            char[] chars = strs[i].ToArray<char>();
            Array.Sort(chars);
            if(!AnagramsDict.ContainsKey(new string(chars)))
            {
                AnagramsDict[new string(chars)] = new List<string>();
            }
            AnagramsDict[new string(chars)].Add(strs[i]);

        }
        foreach(List<string> OneAnagramGroup in AnagramsDict.Values)
        {
            GroupedAnagrams.Add(OneAnagramGroup);
        }

        return GroupedAnagrams;
    }
}