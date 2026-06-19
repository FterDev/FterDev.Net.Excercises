#Find the maximum in an array
---

Tests: Basic iteration, comparisons, off-by-one mistakes
Given an integer array, return the largest value without using Array.Max() or LINQ. Then return both the largest AND second-largest value in a single pass.

**Starting Signature**
```
public int FindMax(int[] nums)
public (int max, int secondMax) FindTopTwo(int[] nums)
```
**Constraints/Edgecases**
- Array with only 1 element
- All elements identical
- Negative numbers

**Posible follow-ups**

- Why would Array.Max() not be allowed in some interview settings?
- What happens if the array is empty — what should your method do?

**Target complexity**: O(n) time, O(1) space