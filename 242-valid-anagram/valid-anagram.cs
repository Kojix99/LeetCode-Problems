public class Solution {
    public bool IsAnagram(string s, string t)
    {
        // I don't know if sorting is the best practice
        if(s.Length != t.Length)
        {
            return false;
        }
        char[] characters01 = s.ToCharArray();
        Array.Sort(characters01);
        char[] characters02 = t.ToCharArray();
        Array.Sort(characters02);
        for(int i = 0; i < s.Length; i++)
        {
            if (characters01[i] != characters02[i])
            {
                return false;
                }
            }
        return true;
    }
}