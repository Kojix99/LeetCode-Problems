public class Solution {
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;


        int[] LettersCount = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            LettersCount[s[i] - 'a']++;
            LettersCount[t[i] - 'a']--;
        }

        foreach(int count in LettersCount)
        {
            if (count != 0) return false;
        }
        return true;
    }
}