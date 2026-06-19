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

# Answers
---

- Why would Array.Max() not be allowed in some interview settings?
    - Because it doen't give insight on the iteration process and the algorithm performance (O(x) time / space) is not cleary satisfied 

- What happens if the array is empty — what should your method do?
    - It should throw an exception which states, that the given array is empty

    - That's actually a good follow-up question in its own right for an interview: "why not just throw Exception?" Do you know the answer to that one, or want to think it through?

        - My thought was that in a real case I'd throw a custom exceprion which can be assigned to a specific application error code / it will be processed in a special way, that's why I went with a general exception as it's not defined. The alternative would be to throw an ArgumentException and a message that there is a length x expected

    - Specifically: what's the difference between writing catch (ArgumentException ex) versus catch (Exception ex) in terms of what you're able to express about what you're prepared to handle? And if every single method in a codebase throws the same bare Exception type for completely different failure reasons (empty array, network timeout, null reference, file not found...), what does that do to your ability to catch specifically the empty-array case without accidentally also swallowing bugs you didn't intend to catch?

        - The differnce is that Exception catches any Type of Exceptions so it could have a deeply rooted cause than the ArgumentException and it would mislead me. Also that means I would catch a wrong exception in some cases covering up any other issue