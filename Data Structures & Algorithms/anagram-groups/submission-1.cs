public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> res = new();
        foreach(var num in strs){ var chars = num.ToCharArray();
            Array.Sort(chars);
            string str = new string(chars);
            if(!res.TryGetValue(str,out var list)){
                list = new List<string>();
                res.Add(str,list);
            }
            res[str].Add(num);
        }
        return res.Values.ToList<List<string>>();
    }
}
