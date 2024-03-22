public class Solution
{
    public bool IsValid(string s)
    {
        string[] options = { "()", "{}", "[]" };
        for (int i = 0; i < 1000000; i++)
        {
            bool foundPair = false;
            foreach (string option in options)
            {
                if (s.Contains(option))
                {
                    s = s.Replace(option, ""); //removes the bracket 
                    foundPair = true;
                }
            }
            if (!foundPair)
            {
                break;
            }
        }
        return s.Length == 0;
    }
}