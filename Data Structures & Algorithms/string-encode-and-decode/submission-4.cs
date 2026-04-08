public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new();
        foreach(string str in strs){
            sb.Append(str.Length).Append("#").Append(str);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> res = new();
        int i = 0;
        while(i<s.Length){
            int j = i;
            while(s[j] != '#') j++;
            int len = int.Parse(s.Substring(i, j - i));
            j++;
            res.Add(s.Substring(j,len));
            i = j+len;
        }
        return res;
   }
}