public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> res = new();
        foreach(string str in strs){
            char[] ch = str.ToCharArray();
            Array.Sort(ch);
            var key = new string(ch);
            if(res.ContainsKey(key))
                res[key].Add(str);
            else{
                res.Add(key,new List<string> {str});
            }
        }
        return res.Values.ToList();
    }
}
