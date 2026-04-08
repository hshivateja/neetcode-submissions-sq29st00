public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int len = nums.Length;
        Dictionary<int,int> hashMap = new();

        foreach(int num in nums){
            if(hashMap.ContainsKey(num)){
                hashMap[num]++;
            }
            else
                hashMap[num] = 1;
        }

        List<int>[] countArray = new List<int>[len+1];

        foreach(var pair in hashMap){
            if (countArray[pair.Value] == null) {
                countArray[pair.Value] = new List<int>();
            }
            countArray[pair.Value].Add(pair.Key);
        }

        int[] res = new int[k];
        int index = 0;
        for(int i = countArray.Length-1;i>0 && index<k;i--){
            if (countArray[i] == null) continue;
            foreach(int n in countArray[i]){
                res[index] = n;
                index++;
                if(index==k)
                    return res;
            }
        }
        return res;
    }
}
