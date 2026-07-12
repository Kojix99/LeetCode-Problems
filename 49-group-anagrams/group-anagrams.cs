public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) 
    {
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

        return new List<IList<string>>(AnagramsDict.Values);
    }
}