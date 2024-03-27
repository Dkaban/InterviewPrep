public class Solution 
{
    public int LengthOfLastWord(string s) 
    {
        s = s.Trim();
        int wordSize = 0;
        for(int i=s.Length-1;i>=0;i--)
        {
            if(!s[i].Equals(' '))
            {
                wordSize++;
            }
            else
            {
                return wordSize;
            }
        }

        return wordSize;
    }
}
