# Check if a string is a palindrome

**Tests**: Two-pointer comparison, case/whitespace normalization

Determine whether a given string is a palindrome, ignoring case, spaces, and punctuation (e.g. 'A man, a plan, a canal: Panama' should return true).

**Starting Signature**

```
public static bool IsPalindrome(string input)
```

**Constraints/Edgecases**

* Empty string (should be considered a palindrome)
* String with only punctuation
* Mixed case input

**Possible follow-ups**

* Could you solve this without allocating a new cleaned-up string, scanning the original directly with two pointers?
* How would you check if a string can be REARRANGED into a palindrome instead?

Target complexity: O(n) time, O(1) extra space if done with two pointers directly on the original string.

# Answers

*