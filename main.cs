public class Solution {
    public int RemoveDuplicates(int[] nums) {
        List<int> li = new List<int>(nums.Length);
        for(int i = 0; i < nums.Length; i++)
        {
            if(!li.Contains(nums[i]))
            {
                li.Add(nums[i]);
                continue;
            }
        }
        for(int i = 0; i < nums.Length; i++)
        {
            if(i >= li.Count)
            {
                nums[i] = -1;
            }
            else
            {
                nums[i] = li[i];
            }
        }
        return li.Count();
    }
}
