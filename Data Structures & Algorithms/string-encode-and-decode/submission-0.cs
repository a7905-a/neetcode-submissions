public class Solution {

    public string Encode(IList<string> strs) 
    {
        string result = "";
        foreach(string word in strs)
        {
            result += word.Length + "#" + word;
        }
        return result;
    }

    public List<string> Decode(string s)
    {
        List<string> result = new List<string>();
        int i = 0;
        while (i < s.Length)
        {
            int hashindex = s.IndexOf('#', i);
            int length = int.Parse(s.Substring(i, hashindex - i));

            int wordStartIndex = hashindex + 1;
            string word = s.Substring(wordStartIndex, length);
            result.Add(word);

            i = wordStartIndex + length;
        }

        return result;
    }
}
