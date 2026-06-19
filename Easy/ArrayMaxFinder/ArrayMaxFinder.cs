

namespace FterDev.Easy.ArrayMaxFinder;

public class ArrayMaxFinder
{
    public int FindMax(int[] nums)
    {
        int currentMax = nums[0];

        if(nums.Length == 1)
            return currentMax;

        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] > currentMax)
                currentMax = nums[i];
        }

        return currentMax;
    }

    public (int firstMax, int secondMax) FinddTopTwo(int[] nums)
    {
        throw new NotImplementedException();
    }
}