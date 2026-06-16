public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        int[] result = new int[2] { 0, 0 };

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (i != j && nums[i] + nums[j] == target)
                {
                    result[0] = i;
                    result[1] = j;
                    continue;
                }
            }

            if (result[0] != 0 && result[1] != 0)
                break;
        }

        return result;
    }
}
