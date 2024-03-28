public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        if(s.Length != t.Length)
        {
            return false;
        }

        char[] stringS = s.ToCharArray();
        char[] stringT = t.ToCharArray();
        Array.Sort(stringS);
        Array.Sort(stringT);
        return Enumerable.SequenceEqual(stringS, stringT);
    }
}
