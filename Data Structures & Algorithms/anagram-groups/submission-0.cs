public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> groupMap = new Dictionary<string, List<string>>();
        foreach(string word in strs)
        {
            char[] charArray = word.ToCharArray();
            Array.Sort(charArray);
            string signature = new string(charArray);

            if(!groupMap.ContainsKey(signature))
            {
                groupMap[signature] = new List<string>();
            }
            groupMap[signature].Add(word);
        }
        return new List<List<string>>(groupMap.Values);
    }
}
