# Reverse a string without built-ins

**Tests**: Two-pointer technique, char arrays, basic string manipulation

Reverse a string in place (or build a reversed copy) without calling string.Reverse() or Array.Reverse(). Use a two-pointer swap approach.

**Starting signature**
```
public string ReverseString(string input)
```

**Constraints / Edge cases to handle**

- Empty string
- Single character
- String with spaces and punctuation

**Interviewer follow-ups (be ready)**

- Why is a string immutable in C#, and how does that affect your approach (hint: char[])?
- How would you reverse only the words in a sentence, but keep word order — e.g. 'Hello World' becomes 'olleH dlroW'?

**Target complexity:** O(n) time, O(n) space (since strings are immutable).

# Answers
