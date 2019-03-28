using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nsSearching
{
    public class ContainsDuplicates
    {

        public static void ContainsNearbyDuplicates(int[] nums, int k)
        {
            Boolean isMatch = false;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for(int i=0; i<nums.Length; i++){
                if(dic.ContainsKey(nums[i])){
                    int val = dic[nums[i]];
                    dic[nums[i]] = i;
                    if(i - val <= k){
                        isMatch = true;
                        break;
                    }
                }else{
                dic.Add(nums[i], i);}
            }
            Console.WriteLine(isMatch ? "YES" : "NO");
        }

    }
}