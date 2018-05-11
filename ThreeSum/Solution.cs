public class Solution {

    public IList<IList<int>> ThreeSum(int[] nums) {
                
        var hashset = new HashSet<string>();
        var answer = new List<IList<int>>();
        
        Array.Sort(nums);
        
        for(int i = 0; i < nums.Length - 2 && nums[i] <= 0; i++) {
            
            if (i > 0 && nums[i] == nums[i-1]) {
                 continue;   
            }
            
            var l = i + 1; 
            var r = nums.Length - 1;

            while (l < r)
            {
                if(nums[i] + nums[l] + nums[r] == 0)
                {
                    var validSequence = new List<int>() {nums[i], nums[l], nums[r]};
                    var hashedSequence = string.Join(",", validSequence);

                    if (!hashset.Contains(hashedSequence)) {
                        answer.Add(validSequence);   
                        hashset.Add(hashedSequence);
                    }

                    l++;
                }
                else if (nums[i] + nums[l] + nums[r] < 0)
                    l++;
                else 
                    r--;
            }
        }
        
        return answer;
    }
}
