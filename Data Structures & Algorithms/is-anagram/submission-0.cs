public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        if (s.Length != t.Length)
            return false;

        char[] sortedS = s.ToCharArray();
        Array.Sort(sortedS);
        char[] sortedT = t.ToCharArray();
        Array.Sort(sortedT);

        for (int i = 0; i < s.Length; i++)
        {
            if (sortedS[i] != sortedT[i])
                return false;
        }

        return true;
    }
}
