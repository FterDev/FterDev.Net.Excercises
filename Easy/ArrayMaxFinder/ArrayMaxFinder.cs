

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

    public (int firstMax, int secondMax) FindTopTwo(int[] nums)
    {
        int currentMax = nums[0];
        int secondMax = nums[0];

        if(nums.Length == 1)
            throw new Exception("Only one element in array");


        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] > currentMax)
            {
                secondMax = currentMax;
                currentMax = nums[i];
            }
                
        }

        return (currentMax, secondMax);

    }
}