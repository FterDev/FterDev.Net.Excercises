# FizzBuzz, extended

**Tests**: Conditional logic, modulo operator, clean branching

Classic FizzBuzz: print numbers 1 to 100, but print 'Fizz' for multiples of 3, 'Buzz' for multiples of 5, and 'FizzBuzz' for multiples of both. Then generalize it to accept a Dictionary<int, string> of arbitrary divisor-to-word mappings.

**Starting Signature**

```
public static void FizzBuzz(int n)
public static string FizzBuzzGeneral(int number, Dictionary<int,string> rules)
```

**Constraints/Edgecases**

* Divisor of 0 in the rules dictionary (should not crash)
* Multiple rules matching the same number — what order should words appear in?

**Possible follow-ups**

* How would you make this work efficiently for n up to 10 million?
* Why might an interviewer ask this even though it seems 'too simple' — what are they actually checking?

**Target complexity**: O(n) time for the main loop.

# Answers

