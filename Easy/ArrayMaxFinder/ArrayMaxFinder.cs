

namespace FterDev.Easy.ArrayMaxFinder;

public class ArrayMaxFinder
{
    public int FindMax(int[] nums)
    {
        

        if(nums.Length == 0)
            throw new Exception("No elements in array");

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


        if(nums.Length == 0)
            throw new Exception("No elements in array");

        if(nums.Length == 1)
            throw new Exception("Only one element in array");
        

        int currentMax = 0;
        int secondMax = 0;

        for(int i = 0; i < nums.Length; i++)
        {

            if(i == 0)
            {
                currentMax = nums[i];
                secondMax = nums[i+1];
                continue;
            }

            if(nums[i] > currentMax)
            {
                secondMax = currentMax;
                currentMax = nums[i];
            }
            else if(nums[i] > secondMax)
            {
                secondMax = nums[i];
            }
                
        }

        return (currentMax, secondMax);

    }
}